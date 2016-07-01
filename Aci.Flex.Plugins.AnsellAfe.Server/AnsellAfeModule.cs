using Aci.Flex.Core;
using Aci.Flex.Core.Exceptions;
using Aci.Flex.Core.Logging;
using Aci.Flex.DataModel;
using Aci.Flex.DataModel.Enum;
using Aci.Flex.Interfaces;
using Aci.Flex.Plugins.AnsellAfe.Server.DataModel;
using Aci.Flex.Plugins.AnsellAfe.Server.Objects;
using Aci.Flex.Server.Core;
using Aci.Flex.Server.ObjectModel;
using Aci.Flex.Server.Workflow;
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
        private Guid m_ActiveEventIdentifier
        {
            get
            {
                return Guid.Parse("93E6436B-C3DA-47D9-A393-120E2C8BC5FA");
            }
        }
        private Guid m_ActiveInputIdentifer
        {
            get
            {
                return Guid.Parse("C327AA2C-B0D9-44D5-92A2-534093938842");
            }
        }
        internal Guid m_WorkflowKeyHierarchyIdentifier
        {
            get
            {
                return Guid.Parse("F964B824-263A-433D-805D-E74CDF395375");
            }
        }

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
                && w.SiteId == siteId && w.Year == year).Select(s => s.Data).Sum();
        }

        public decimal GetPreviousAfeCosts(int divisionId, int functionId, int siteId, int year)
        {
            var prevCosts = (from a in DbContext.Afes
                             join f in DbContext.FactFinancials on a.AfeId equals f.AfeId
                             where a.DivisionId == divisionId && a.FunctionId == functionId && a.SiteId == siteId && f.Year == year
                                && f.Money != null && f.AccountId == 1
                             select f.Money.Value);

            if (prevCosts == null || prevCosts.Count() == 0)
                return 0;

            return prevCosts.Sum();
        }

        public decimal GetPreviousAfeCosts(long afeId)//, int divisionId, int functionId, int siteId, int year)
        {
            var prevCosts = (from a in DbContext.Afes
                             join p in DbContext.Afes on new { a.DivisionId, a.FunctionId, a.SiteId } equals new { p.DivisionId, p.FunctionId, p.SiteId }
                             join f in DbContext.FactFinancials on p.AfeId equals f.AfeId
                             where a.AfeId == afeId && p.CreateDate < a.CreateDate &&
                                //a.DivisionId == divisionId && a.FunctionId == functionId && a.SiteId == siteId && 
                                f.Year == 2016 && f.Money != null && f.AccountId == 1
                             select f.Money.Value);

            if (prevCosts == null || prevCosts.Count() == 0)
                return 0;

            return prevCosts.Sum();
        }

        public SaveAfeReturnDetails SaveAfe(Guid userIdentifier, AfeSubmitData afeData, bool isDraft)
        {
            SaveAfeReturnDetails returnDetails = new SaveAfeReturnDetails() { Success = true };
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

                // Rebuild EHS
                PlatformServices.DataModel.BuildEntityHierarchy(ModelIdentifier, new List<Guid>() { Guid.Parse("768C8411-DC01-497C-BE34-A22FDEA5BBB0") }).Wait();

                // Workflow
                if (!isDraft)
                {
                    DynamicApprovals approvals = new DynamicApprovals()
                    {
                        UserIdentifier = userIdentifier,
                        AdditionalApprovers = afeData.AdditionalApprovers,
                        RequiredApprovers = GetAuthorizationChain(afe.NatureId, afe.DivisionId, afe.FunctionId, afeData.Financials.Where(w => w.AccountId == 1).Select(s => s.Value).SingleOrDefault()).ToList()
                    };
                    returnDetails.Success = ProcessBookmark<DynamicApprovals>(afe.AfeId, "Submit", approvals);
                }
                
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

        public bool ProcessBookmark<T>(long afeId, string bookmarkName, T resumptionDetails) where T : BaseWorkflowResumptionDetails
        {
            var workflowId = GetWorkflowId(afeId);
            if (workflowId != Guid.Empty)
            {
                return ProcessBookmark<T>(workflowId, bookmarkName, resumptionDetails);
            }

            // New AFE: no workflow definition exists yet.
            // DRY violation, but it works for now.
            BaseWorkflowResumptionDetails details = resumptionDetails as BaseWorkflowResumptionDetails;
            if (details != null && details.Comment != null)
            {
                details.Comment = details.Comment.Replace("\n", "<br />");
            }

            var workflowProcessor = PlatformServices.Workflow.GetWorkflowProcessor(
                this.ModelIdentifier,
                m_ActiveEventIdentifier,
                resumptionDetails.UserIdentifier,
                m_ActiveInputIdentifer,
                new List<KeyValuePair<Guid, string>>() { new KeyValuePair<Guid, string>(m_WorkflowKeyHierarchyIdentifier, afeId.ToString()) },
                true);

            if (workflowProcessor == null)
                throw new Exception("Could not find a workflow processor.");

            return workflowProcessor.ProcessBookmark(bookmarkName, resumptionDetails, true);
        }

        public bool ProcessBookmark<T>(Guid workflowInstanceId, string bookmarkName, T resumptionDetails) where T : BaseWorkflowResumptionDetails
        {
            BaseWorkflowResumptionDetails details = resumptionDetails as BaseWorkflowResumptionDetails;
            if (details != null && details.Comment != null)
            {
                details.Comment = details.Comment.Replace("\n", "<br />");
            }

            var workflowProcessor = PlatformServices.Workflow.GetWorkflowProcessor(workflowInstanceId);

            if (workflowProcessor == null)
                throw new Exception("Could not find a workflow processor.");

            return workflowProcessor.ProcessBookmark(bookmarkName, resumptionDetails, true);
        }

        internal Guid GetWorkflowId(long afeId)
        {
            var workflowDefs = PlatformServices.Workflow.GetWorkflowDefinitions(new List<KeyValuePair<Guid, string>>() { new KeyValuePair<Guid, string>(m_WorkflowKeyHierarchyIdentifier, afeId.ToString()) });
            if (workflowDefs == null || workflowDefs.Count() == 0)
            {
                Log.Exception(new FlexException(string.Format("Could not find WorkflowDefinition for HierarchyId: {0}, MemberKey: {1}.", m_WorkflowKeyHierarchyIdentifier, afeId)));
                return Guid.Empty;
            }
            if (workflowDefs.Count() > 1)
            {
                throw new FlexException(string.Format("Could not find unique WorkflowDefinition for HierarchyId: {0}, MemberKey: {1}.", m_WorkflowKeyHierarchyIdentifier, afeId));
            }

            return workflowDefs.Single().WorkflowIdentifier;
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

        internal IEnumerable<SearchResult> Search(string searchTerm)
        {
            List<SearchResult> results = new List<SearchResult>();

            using (var db = CreateSingleUseDataContext())
            {
                var query = string.Format("select * from Flex.Search('{0}')", searchTerm); ;
                var sr = db.Database.SqlQuery<AfeSearchResult>(query).ToList();

                sr.ForEach((result) =>
                {
                    var searchResult = new SearchResult()
                    {
                        DisplayText = result.ProjectName,
                        RelativeUrl = string.Format("Workflow?id={0}", result.WorkflowIdentifier.ToString())
                    };
                    results.Add(searchResult);
                });
            }

            return results;
        }


        public bool RecallAfe(Guid workflowId, Guid userIdentifier, string comments)
        {
            try
            {
                BaseWorkflowResumptionDetails details = new BaseWorkflowResumptionDetails()
                {
                    Comment = comments,
                    UserIdentifier = userIdentifier
                };

                return ProcessBookmark<BaseWorkflowResumptionDetails>(workflowId, "Recall", details);
            }
            catch(Exception ex)
            {
                Log.Exception(ex);
                return false;
            }
        }

        public bool SubmitApproval(Guid workflowId, Guid userIdentifier, string comments, bool isApproved)
        {
            try
            {
                ApprovalWorkflowResumptionDetails details = new ApprovalWorkflowResumptionDetails()
                {
                    Comment = comments,
                    UserIdentifier = userIdentifier,
                    IsApproved = isApproved
                };

                return ProcessBookmark<ApprovalWorkflowResumptionDetails>(workflowId, string.Format("Approval_{0}", userIdentifier), details);
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
                return false;
            }
        }

        public ApprovalAfeDetails GetApprovalAfeDetails(Guid workflowId)
        {
            try
            {
                var workflowDefinition = PlatformServices.Workflow.GetWorkflowDefinition(workflowId);
                long afeId = -1;
                long.TryParse(workflowDefinition.First().Value, out afeId);

                var afe = DbContext.Afes.Where(w => w.AfeId == afeId).SingleOrDefault();

                var details = (from a in DbContext.Afes
                               join d in DbContext.Divisions on a.DivisionId equals d.DivisionId
                               join f in DbContext.Functions on a.FunctionId equals f.FunctionId
                               join s in DbContext.Sites on a.SiteId equals s.SiteId
                               join c in DbContext.Currencies on a.CurrencyId equals c.CurrencyId
                               where a.AfeId == afeId
                               select new ApprovalAfeDetails() {
                                AfeId = afeId,
                                ProjectName = a.ProjectName,
                                ExpenditureType = a.ExpenditureType,
                                ReferenceNo = a.ReferenceNo,
                                StageGateProjectId = a.StageGateProjectId,
                                AfeType = a.OriginalAfeId.HasValue ? "Supplement" : "Original",
                                CreateDate = a.CreateDate,
                                CurrencyCode = c.CurrencyCode,
                                DivisionName = d.DivisionName,
                                FunctionName = f.FunctionName,
                                SiteName = s.SiteName
                               }).SingleOrDefault();

                var facts = DbContext.FactFinancials.Where(w => w.AfeId == afeId).ToList();
                facts.ForEach((f) => {
                    if (f.AccountId == 1)
                        details.Amount = f.Money.HasValue ? f.Money.Value : 0m;
                    else if (f.AccountId == 2)
                        details.Budget = f.Money.HasValue ? f.Money.Value : 0m;
                    else if (f.AccountId == 3)
                        details.CashBackBefore = f.Months.HasValue ? f.Months.Value : 0;
                    else if (f.AccountId == 4)
                        details.CashBackAfter = f.Months.HasValue ? f.Months.Value : 0;
                    else if (f.AccountId == 5)
                        details.ReturnOnAssets = f.Percentage.HasValue ? f.Percentage.Value : 0m;
                    else if (f.AccountId == 6)
                        details.NPV = f.Money.HasValue ? f.Money.Value : 0m;
                    else if (f.AccountId == 7)
                        details.IRR = f.Percentage.HasValue ? f.Percentage.Value : 0m;
                    else if (f.AccountId == 9)
                        details.NetWriteOff = f.Money.HasValue ? f.Money.Value : 0m;
                });

                details.Budget = GetBudget(afe.DivisionId, afe.FunctionId, afe.SiteId, 2016);
                details.PreviousAfes = GetPreviousAfeCosts(afe.AfeId);
                details.RemainingBudget = details.Budget - (details.Amount + details.PreviousAfes);

                var rate = 1m;
                var ex = GetUsdExchangeRate().Where(w => w.Item1 == afe.CurrencyId).SingleOrDefault();
                if (ex != null)
                    rate = ex.Item2;

                details.ExchangeRate = rate;

                return details;
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
                return null;
            }
        }
    }
}
