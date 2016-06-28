﻿using Aci.Flex.Core;
using Aci.Flex.Plugins.AnsellAfe.Server.DataModel;
using Aci.Flex.Plugins.AnsellAfe.Server.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server.Interfaces
{
    [ServiceContract]
    [GenerateAsyncServiceInterface("IAnsellAfeService")]
    public interface IAnsellAfeService
    {
        [OperationContract]
        bool DummyDatabaseCall();

        [OperationContract]
        IEnumerable<Division> GetDivisions();

        [OperationContract]
        IEnumerable<Function> GetFunctions();

        [OperationContract]
        IEnumerable<Site> GetSites();

        [OperationContract]
        IEnumerable<Nature> GetNatures();

        [OperationContract]
        IEnumerable<Purpose> GetPurposes();

        [OperationContract]
        IEnumerable<Currency> GetCurrencies();

        [OperationContract]
        decimal GetExchangeRate(int fromCurrencyId, int toCurrencyId);

        [OperationContract]
        IEnumerable<Tuple<int, decimal>> GetUsdExchangeRate();

        [OperationContract]
        decimal GetBudget(int divisionId, int functionId, int siteId, int year);

        [OperationContract]
        SaveAfeReturnDetails SaveAfe(AfeSubmitData afeData, bool isDraft);
    }
}