using Aci.Flex.Core;
using Aci.Flex.Core.Logging;
using Aci.Flex.DataModel;
using Aci.Flex.Interfaces;
using Aci.Flex.Plugins.AnsellAfe.Server.DataModel;
using Aci.Flex.Plugins.AnsellAfe.Server.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server
{
    [ExportAsFlexPlugin(typeof(AnsellAfeModule), typeof(IFlexDataModule), false)]
    public class AnsellAfeModule : BaseDataModule<AnsellAfeContext>
    {
        public bool DummyDatabaseCall()
        {
            try
            {
                var afes = DbContext.Afes.ToList();
                return true;
            }
            catch (Exception ex)
            {
                Log.Error("DummyDatabaseCall failed with message: {0}.", ex.Message);
                return false;
            }
        }

        public IEnumerable<Division> GetDivisions()
        {
            return DbContext.Divisions.OrderBy(o => o.DivisionName);
        }

        public IEnumerable<Function> GetFunctions()
        {
            return DbContext.Functions.OrderBy(o => o.FunctionName);
        }

        public IEnumerable<Site> GetSites()
        {
            return DbContext.Sites.OrderBy(o => o.SiteName);
        }

        public IEnumerable<Nature> GetNatures()
        {
            return DbContext.Natures.OrderBy(o => o.NatureName);
        }

        public IEnumerable<Purpose> GetPurposes()
        {
            return DbContext.Purposes.OrderBy(o => o.PurposeName);
        }

        public IEnumerable<Currency> GetCurrencies()
        {
            return DbContext.Currencies.OrderBy(o => o.CurrencyCode);
        }

        public decimal GetExchangeRate(int fromCurrencyId, int toCurrencyId)
        {
            return DbContext.ExchangeRates.Where(w => w.FromCurrency == fromCurrencyId && w.ToCurrency == toCurrencyId).Select(s => s.ExchangeRateValue).SingleOrDefault();
        }

        public IEnumerable<Tuple<int, decimal>> GetUsdExchangeRate()
        {
            var rates = (from ex in DbContext.ExchangeRates
                         join c in DbContext.Currencies on ex.ToCurrency equals c.CurrencyId
                         where c.CurrencyCode == "USD"
                         select ex).ToList();
            
            return rates.Select(s => new Tuple<int, decimal>(s.FromCurrency, s.ExchangeRateValue));
        }

        public decimal GetBudget(int divisionId, int functionId, int siteId, int year)
        {
            return DbContext.FactBudgets.Where(w => w.DivisionId == divisionId && w.FunctionId == functionId
                && w.SiteId == siteId && w.Year == year).Select(s => s.Data).SingleOrDefault();
        }

        public decimal GetPreviousAfeCosts(int divisionId, int functionId, int siteId, int year)
        {
            var prevCosts = (from a in DbContext.Afes
                             join f in DbContext.FactFinancials on a.AfeId equals f.AfeId
                             where a.DivisionId == divisionId && a.FunctionId == functionId && a.SiteId == siteId && f.Year == year
                                && f.Money != null && f.AccountId == 1
                             select f.Money.Value).Sum();

            return prevCosts;
        }

        public SaveAfeReturnDetails SaveAfe(Guid userIdentifier, AfeSubmitData afeData, bool isDraft)
        {
            SaveAfeReturnDetails returnDetails = new SaveAfeReturnDetails();
            try
            {
                var afe = afeData.Afe;
                if (afe.AfeId > 0)
                {
                    var existingAfe = DbContext.Afes.Where(w => w.AfeId == afe.AfeId).SingleOrDefault();

                    existingAfe.ProjectName = afe.ProjectName;
                    existingAfe.ControlMeasures = afe.ControlMeasures;
                    existingAfe.CurrencyId = afe.CurrencyId;
                    existingAfe.Description = afe.Description;
                    existingAfe.DivisionId = afe.DivisionId;
                    existingAfe.ExpenditureType = afe.ExpenditureType;
                    existingAfe.FunctionId = afe.FunctionId;
                    existingAfe.IsDraft = isDraft;
                    existingAfe.NatureId = afe.NatureId;
                    existingAfe.ProjectBenefits = afe.ProjectBenefits;
                    existingAfe.ProjectRisks = afe.ProjectRisks;
                    existingAfe.Proposal = afe.Proposal;
                    existingAfe.PurposeId = afe.PurposeId;
                    existingAfe.ReferenceNo = afe.ReferenceNo;
                    existingAfe.SiteId = afe.SiteId;
                    existingAfe.StageGateProjectId = afe.StageGateProjectId;

                    if (afe.OriginalAfeId.HasValue)
                    {
                        int maxSupIndex = 0;
                        var sups = DbContext.Afes.Where(w => !w.IsDraft && w.IsActive && w.OriginalAfeId == afe.OriginalAfeId.Value).ToList();
                        if (sups.Count > 0)
                            maxSupIndex = sups.Max(s => s.SupplementIndex);

                        existingAfe.SupplementIndex = ++maxSupIndex;
                    }
                }
                else
                {
                    afe.IsActive = true;
                    afe.Creator = userIdentifier;
                    afe.IsDraft = isDraft;
                    if (afe.OriginalAfeId.HasValue)
                    {
                        int maxSupIndex = 0;
                        var sups = DbContext.Afes.Where(w => !w.IsDraft && w.IsActive && w.OriginalAfeId == afe.OriginalAfeId.Value).ToList();
                        if (sups.Count > 0)
                            maxSupIndex = sups.Max(s => s.SupplementIndex);

                        afe.SupplementIndex = ++maxSupIndex;
                    }
                    DbContext.Afes.Add(afe);
                }

                DbContext.SaveChanges();
                
                // Financials
                var existingFacts = DbContext.FactFinancials.Where(w => w.AfeId == afe.AfeId);
                DbContext.FactFinancials.RemoveRange(existingFacts);
                DbContext.SaveChanges();

                afeData.Financials.ForEach((f) =>
                {
                    var account = DbContext.Accounts.Where(w => w.AccountId == f.AccountId).SingleOrDefault();
                    FactFinancial fact = new FactFinancial()
                    {
                        AfeId = afe.AfeId, 
                        AccountId = f.AccountId,                       
                        DivisionId = afe.DivisionId,
                        FunctionId = afe.FunctionId,
                        SiteId = afe.SiteId,
                        NatureId = afe.NatureId,
                        PurposeId = afe.PurposeId,
                        Year = 2016,
                        InsertedDate = DateTime.Now,
                        InsertedBy = userIdentifier
                    };

                    switch (account.FactType)
                    {
                        case 1:
                            fact.Money = f.Value;
                            break;
                        case 2:
                            fact.Months = (int)f.Value;
                            break;
                        case 3:
                            fact.Percentage = f.Value;
                            break;
                        default:
                            fact.Money = f.Value;
                            break;
                    };

                    DbContext.FactFinancials.Add(fact);
                });

                DbContext.SaveChanges();

                // Additional Approvers
                var existingAddApprovers = DbContext.AdditionalApprovers.Where(w => w.AfeId == afe.AfeId);
                DbContext.AdditionalApprovers.RemoveRange(existingAddApprovers);
                DbContext.SaveChanges();

                afeData.AdditionalApprovers.ForEach((aa) =>
                {
                    var a = new AdditionalApprover()
                    { 
                        AfeId = afe.AfeId,
                        ApproverIdentifier = aa.FlexIdentifier
                    };
                    DbContext.AdditionalApprovers.Add(a);
                });

                DbContext.SaveChanges();

                returnDetails.AfeId = afe.AfeId;
                returnDetails.Success = true;
                return returnDetails;
            }
            catch (Exception ex)
            {
                Log.Error("Failed to save afe.");
                Log.Exception(ex);
                returnDetails.Success = false;
                return returnDetails;
            }
        }

        public IEnumerable<Afe> FindAfes(string searchTerm)
        {
            try
            {
                return DbContext.Afes.Where(w => w.IsActive && !w.IsDraft && w.ProjectName.Contains(searchTerm));
            }
            catch (Exception ex)
            {
                Log.Error("Failed to find AFEs with search term: {0}.  Exception details to follow.", searchTerm);
                Log.Exception(ex);
                return null;
            }
        }

        public Afe GetAfe(long afeId)
        {
            try
            {
                return DbContext.Afes.Where(w => w.AfeId == afeId).SingleOrDefault();
            }
            catch (Exception ex)
            {
                Log.Error("Failed to get AFE with Id: {0}.  Exception details to follow.", afeId);
                Log.Exception(ex);
                return null;
            }
        }

        public IEnumerable<PersonInfo> GetAuthorizationChain(int natureId, int divisionId, int functionId, decimal amount)
        {
            var auths = (from ac in DbContext.AuthorizationCategories
                         join a in DbContext.Authorizations on ac.AuthorizationCategoryId equals a.AuthorizationCategoryId
                         where ac.NatureId == natureId && ac.DivisionId == divisionId && ac.FunctionId == functionId
                         select a).OrderBy(o => o.Authority).ToList();

            List<PersonInfo> chain = new List<PersonInfo>();

            foreach(var a in auths)
            {
                var pi = new PersonInfo();
                var user = Aci.Flex.Server.Core.PlatformServices.Security.GetUser(a.UserIdentifier);
                if (user != null)
                {
                    pi.Id = user.Id;
                    pi.FlexIdentifier = user.FlexIdentifier;
                    pi.Name = user.Name;
                    pi.Title = user.Title;
                }

                chain.Add(pi);

                if (a.Authority >= amount)
                    break;
            };

            return chain;
        }
    }
}
