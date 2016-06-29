var Flex;
(function (Flex) {
    var ApiClient;
    (function (ApiClient) {
        var CommonAfeApi;
        (function (CommonAfeApi) {
            function GetDivisions() {
                var baseUrl = $.url("portal");
                var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Division";
                var targetUrl = baseUrl + "api/commonafeapi/GetDivisions";
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
                var targetUrl = baseUrl + "api/commonafeapi/GetFunctions";
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
                var targetUrl = baseUrl + "api/commonafeapi/GetSites";
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
                var targetUrl = baseUrl + "api/commonafeapi/GetNatures";
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
                var targetUrl = baseUrl + "api/commonafeapi/GetPurposes";
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
                var targetUrl = baseUrl + "api/commonafeapi/GetCurrencies";
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
                var typeHint = "System.Tuple<number, number>";
                var targetUrl = baseUrl + "api/commonafeapi/GetUsdExchangeRates";
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
                var targetUrl = baseUrl + "api/commonafeapi/GetBudget" + "?divisionId=" + divisionId + "&functionId=" + functionId + "&siteId=" + siteId + "&year=" + year;
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
            function GetPreviousAfeCosts(divisionId, functionId, siteId, year) {
                var baseUrl = $.url("portal");
                var typeHint = "number";
                var targetUrl = baseUrl + "api/commonafeapi/GetPreviousAfeCosts" + "?divisionId=" + divisionId + "&functionId=" + functionId + "&siteId=" + siteId + "&year=" + year;
                return Aci.Flex.Portal.ServiceHelper.GetData(targetUrl, typeHint, true);
            }
            CommonAfeApi.GetPreviousAfeCosts = GetPreviousAfeCosts;
            function ResolveGetPreviousAfeCosts(divisionId, functionId, siteId, year, resolveTo) {
                return GetPreviousAfeCosts(divisionId, functionId, siteId, year).then(function (e) {
                    resolveTo(e);
                    return true;
                }, function (f) { return false; });
            }
            CommonAfeApi.ResolveGetPreviousAfeCosts = ResolveGetPreviousAfeCosts;
            function FindAfes(searchTerm) {
                var baseUrl = $.url("portal");
                var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Afe";
                var targetUrl = baseUrl + "api/commonafeapi/FindAfes" + "?searchTerm=" + searchTerm;
                return Aci.Flex.Portal.ServiceHelper.GetArrayData(targetUrl, typeHint);
            }
            CommonAfeApi.FindAfes = FindAfes;
            function ResolveFindAfes(searchTerm, resolveTo) {
                return FindAfes(searchTerm).then(function (e) {
                    resolveTo(e);
                    return true;
                }, function (f) { return false; });
            }
            CommonAfeApi.ResolveFindAfes = ResolveFindAfes;
            function GetAfe(afeId) {
                var baseUrl = $.url("portal");
                var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Afe";
                var targetUrl = baseUrl + "api/commonafeapi/GetAfe" + "?afeId=" + afeId;
                return Aci.Flex.Portal.ServiceHelper.GetData(targetUrl, typeHint, true);
            }
            CommonAfeApi.GetAfe = GetAfe;
            function ResolveGetAfe(afeId, resolveTo) {
                return GetAfe(afeId).then(function (e) {
                    resolveTo(e);
                    return true;
                }, function (f) { return false; });
            }
            CommonAfeApi.ResolveGetAfe = ResolveGetAfe;
            function FindUsers(ntId, firstname, lastname, email) {
                var baseUrl = $.url("portal");
                var typeHint = "Aci.Flex.Core.PersonInfo";
                var targetUrl = baseUrl + "api/commonafeapi/FindUsers" + "?ntId=" + ntId + "&firstname=" + firstname + "&lastname=" + lastname + "&email=" + email;
                return Aci.Flex.Portal.ServiceHelper.GetArrayData(targetUrl, typeHint);
            }
            CommonAfeApi.FindUsers = FindUsers;
            function ResolveFindUsers(ntId, firstname, lastname, email, resolveTo) {
                return FindUsers(ntId, firstname, lastname, email).then(function (e) {
                    resolveTo(e);
                    return true;
                }, function (f) { return false; });
            }
            CommonAfeApi.ResolveFindUsers = ResolveFindUsers;
            function GetApprovers(natureId, divisionId, functionId, amount) {
                var baseUrl = $.url("portal");
                var typeHint = "Aci.Flex.Core.PersonInfo";
                var targetUrl = baseUrl + "api/commonafeapi/GetApprovers" + "?natureId=" + natureId + "&divisionId=" + divisionId + "&functionId=" + functionId + "&amount=" + amount;
                return Aci.Flex.Portal.ServiceHelper.GetArrayData(targetUrl, typeHint);
            }
            CommonAfeApi.GetApprovers = GetApprovers;
            function ResolveGetApprovers(natureId, divisionId, functionId, amount, resolveTo) {
                return GetApprovers(natureId, divisionId, functionId, amount).then(function (e) {
                    resolveTo(e);
                    return true;
                }, function (f) { return false; });
            }
            CommonAfeApi.ResolveGetApprovers = ResolveGetApprovers;
        })(CommonAfeApi = ApiClient.CommonAfeApi || (ApiClient.CommonAfeApi = {}));
    })(ApiClient = Flex.ApiClient || (Flex.ApiClient = {}));
})(Flex || (Flex = {}));
//# sourceMappingURL=CommonAfeApiController.js.map