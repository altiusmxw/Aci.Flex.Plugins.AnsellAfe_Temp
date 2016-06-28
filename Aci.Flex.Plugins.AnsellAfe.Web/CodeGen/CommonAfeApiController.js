var Flex;
(function (Flex) {
    var ApiClient;
    (function (ApiClient) {
        var CommonAfeApi;
        (function (CommonAfeApi) {
            function GetDivisions() {
                var baseUrl = $.url("portal");
                var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Division";
                var targetUrl = baseUrl + "api/commonafeapi/getdivisions";
                return Aci.Flex.Portal.ServiceHelper.GetArrayData(targetUrl, typeHint);
            }
            CommonAfeApi.GetDivisions = GetDivisions;
            function ResolveGetDivisions(resolveTo) {
                return GetDivisions().then(function (e) {
                    resolveTo(e);
                    return true;
                }, function (f) { return false; });
            }
            CommonAfeApi.ResolveGetDivisions = ResolveGetDivisions;
            function GetFunctions() {
                var baseUrl = $.url("portal");
                var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Function";
                var targetUrl = baseUrl + "api/commonafeapi/getfunctions";
                return Aci.Flex.Portal.ServiceHelper.GetArrayData(targetUrl, typeHint);
            }
            CommonAfeApi.GetFunctions = GetFunctions;
            function ResolveGetFunctions(resolveTo) {
                return GetFunctions().then(function (e) {
                    resolveTo(e);
                    return true;
                }, function (f) { return false; });
            }
            CommonAfeApi.ResolveGetFunctions = ResolveGetFunctions;
            function GetSites() {
                var baseUrl = $.url("portal");
                var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Site";
                var targetUrl = baseUrl + "api/commonafeapi/getsites";
                return Aci.Flex.Portal.ServiceHelper.GetArrayData(targetUrl, typeHint);
            }
            CommonAfeApi.GetSites = GetSites;
            function ResolveGetSites(resolveTo) {
                return GetSites().then(function (e) {
                    resolveTo(e);
                    return true;
                }, function (f) { return false; });
            }
            CommonAfeApi.ResolveGetSites = ResolveGetSites;
            function GetNatures() {
                var baseUrl = $.url("portal");
                var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Nature";
                var targetUrl = baseUrl + "api/commonafeapi/getnatures";
                return Aci.Flex.Portal.ServiceHelper.GetArrayData(targetUrl, typeHint);
            }
            CommonAfeApi.GetNatures = GetNatures;
            function ResolveGetNatures(resolveTo) {
                return GetNatures().then(function (e) {
                    resolveTo(e);
                    return true;
                }, function (f) { return false; });
            }
            CommonAfeApi.ResolveGetNatures = ResolveGetNatures;
            function GetPurposes() {
                var baseUrl = $.url("portal");
                var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Purpose";
                var targetUrl = baseUrl + "api/commonafeapi/getpurposes";
                return Aci.Flex.Portal.ServiceHelper.GetArrayData(targetUrl, typeHint);
            }
            CommonAfeApi.GetPurposes = GetPurposes;
            function ResolveGetPurposes(resolveTo) {
                return GetPurposes().then(function (e) {
                    resolveTo(e);
                    return true;
                }, function (f) { return false; });
            }
            CommonAfeApi.ResolveGetPurposes = ResolveGetPurposes;
            function GetCurrencies() {
                var baseUrl = $.url("portal");
                var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Currency";
                var targetUrl = baseUrl + "api/commonafeapi/getcurrencies";
                return Aci.Flex.Portal.ServiceHelper.GetArrayData(targetUrl, typeHint);
            }
            CommonAfeApi.GetCurrencies = GetCurrencies;
            function ResolveGetCurrencies(resolveTo) {
                return GetCurrencies().then(function (e) {
                    resolveTo(e);
                    return true;
                }, function (f) { return false; });
            }
            CommonAfeApi.ResolveGetCurrencies = ResolveGetCurrencies;
            function GetUsdExchangeRates() {
                var baseUrl = $.url("portal");
                var typeHint = "Tuple";
                var targetUrl = baseUrl + "api/commonafeapi/getusdexchangerates";
                return Aci.Flex.Portal.ServiceHelper.GetArrayData(targetUrl, typeHint);
            }
            CommonAfeApi.GetUsdExchangeRates = GetUsdExchangeRates;
            function ResolveGetUsdExchangeRates(resolveTo) {
                return GetUsdExchangeRates().then(function (e) {
                    resolveTo(e);
                    return true;
                }, function (f) { return false; });
            }
            CommonAfeApi.ResolveGetUsdExchangeRates = ResolveGetUsdExchangeRates;
            function GetBudget(divisionId, functionId, siteId, year) {
                var baseUrl = $.url("portal");
                var typeHint = "number";
                var targetUrl = baseUrl + "api/commonafeapi/getbudget";
                return Aci.Flex.Portal.ServiceHelper.GetData(targetUrl, typeHint, true);
            }
            CommonAfeApi.GetBudget = GetBudget;
            function ResolveGetBudget(divisionId, functionId, siteId, year, resolveTo) {
                return GetBudget(divisionId, functionId, siteId, year).then(function (e) {
                    resolveTo(e);
                    return true;
                }, function (f) { return false; });
            }
            CommonAfeApi.ResolveGetBudget = ResolveGetBudget;
        })(CommonAfeApi = ApiClient.CommonAfeApi || (ApiClient.CommonAfeApi = {}));
    })(ApiClient = Flex.ApiClient || (Flex.ApiClient = {}));
})(Flex || (Flex = {}));
//# sourceMappingURL=CommonAfeApiController.js.map