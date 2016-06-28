using Aci.Flex.Core.Logging;
using Aci.Flex.Interfaces;
using Aci.Flex.Plugins.AnsellAfe.Server.DataModel;
using Aci.Flex.Plugins.AnsellAfe.Server.Interfaces;
using Aci.Flex.Server.Core;
using Aci.Flex.Server.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server
{
    [ExportAsFlexPlugin(typeof(AnsellAfeService), typeof(IFlexService), false)]
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false)]
    public class AnsellAfeService : BaseFlexService, IAnsellAfeService, IFlexService
    {
        private AnsellAfeModule GetAfeModule()
        {
#if DEBUG
            var modelIdentifier = AuthenticatedUser.ModelIdentifier;
            if (modelIdentifier == Guid.Empty)
                modelIdentifier = new Guid(ConfigurationManager.AppSettings["ModelIdentifier"]);

            return PlatformServices.Data.GetDataModule<AnsellAfeModule>(modelIdentifier);
#else
            Log.Information("AnsellAfeService.GetAfeModule()");
            return PlatformServices.Data.GetDataModule<AnsellAfeModule>(AuthenticatedUser.ModelIdentifier);
#endif
        }
        public bool DummyDatabaseCall()
        {
            return GetAfeModule().DummyDatabaseCall();
        }
        public IEnumerable<Division> GetDivisions()
        {
            return GetAfeModule().GetDivisions();
        }

        public IEnumerable<Function> GetFunctions()
        {
            return GetAfeModule().GetFunctions();
        }

        public IEnumerable<Site> GetSites()
        {
            return GetAfeModule().GetSites();
        }

        public IEnumerable<Nature> GetNatures()
        {
            return GetAfeModule().GetNatures();
        }

        public IEnumerable<Purpose> GetPurposes()
        {
            return GetAfeModule().GetPurposes();
        }

        public IEnumerable<Currency> GetCurrencies()
        {
            return GetAfeModule().GetCurrencies();
        }

        public decimal GetExchangeRate(int fromCurrencyId, int toCurrencyId)
        {
            return GetAfeModule().GetExchangeRate(fromCurrencyId, toCurrencyId);
        }

        public IEnumerable<Tuple<int, decimal>> GetUsdExchangeRate()
        {
            return GetAfeModule().GetUsdExchangeRate();
        }

        public decimal GetBudget(int divisionId, int functionId, int siteId, int year)
        {
            return GetAfeModule().GetBudget(divisionId, functionId, siteId, year);
        }

        public Objects.SaveAfeReturnDetails SaveAfe(Objects.AfeSubmitData afeData, bool isDraft)
        {
            return GetAfeModule().SaveAfe(afeData, isDraft);
        }

        #region IFlexService
        public bool EnableMex
        {
            get { return true; }
        }

        public Type JsonContract
        {
            get { return null; }
        }

        public Type WsContract
        {
            get { return typeof(IAnsellAfeService); }
        }

        public string Name
        {
            get { return this.GetType().FullName; }
        }
        #endregion
    }
}
