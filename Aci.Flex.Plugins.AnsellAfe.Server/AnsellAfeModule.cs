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

        public SaveAfeReturnDetails SaveAfe(AfeSubmitData afeData, bool isDraft)
        {
            SaveAfeReturnDetails returnDetails = new SaveAfeReturnDetails();
            try
            {
                afeData.Afe.IsDraft = isDraft;
                DbContext.Afes.Add(afeData.Afe);

                //afeData.Financials.ForEach((f) =>
                //{
                //    var account = DbContext.Accounts.Where(w => w.AccountId == f.AccountId).SingleOrDefault();
                //    FactFinancial fact = new FactFinancial()
                //    {
                //        //DivisionId = afeData.Afe.DivisionId
                //    };
                //});

                DbContext.SaveChanges();

                returnDetails.AfeId = afeData.Afe.AfeId;
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
    }
}
