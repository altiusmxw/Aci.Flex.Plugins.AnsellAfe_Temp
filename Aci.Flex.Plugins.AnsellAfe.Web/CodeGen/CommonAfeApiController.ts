module Flex.ApiClient.CommonAfeApi {

    export function GetDivisions(): Q.Promise<Array<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Division>> {
        var baseUrl = $.url("portal");
        var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Division";
        var targetUrl = baseUrl + "api/commonafeapi/getdivisions";

        return Aci.Flex.Portal.ServiceHelper.GetArrayData<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Division>(targetUrl, typeHint);
    }

    export function ResolveGetDivisions(resolveTo: KnockoutObservableArray<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Division>): Q.Promise<boolean> {
        return GetDivisions().then((e) => {
            resolveTo(e);
            return true;
        }, (f) => { return false; });
    }

    export function GetFunctions(): Q.Promise<Array<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Function>> {
        var baseUrl = $.url("portal");
        var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Function";
        var targetUrl = baseUrl + "api/commonafeapi/getfunctions";

        return Aci.Flex.Portal.ServiceHelper.GetArrayData<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Function>(targetUrl, typeHint);
    }

    export function ResolveGetFunctions(resolveTo: KnockoutObservableArray<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Function>): Q.Promise<boolean> {
        return GetFunctions().then((e) => {
            resolveTo(e);
            return true;
        }, (f) => { return false; });
    }

    export function GetSites(): Q.Promise<Array<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Site>> {
        var baseUrl = $.url("portal");
        var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Site";
        var targetUrl = baseUrl + "api/commonafeapi/getsites";

        return Aci.Flex.Portal.ServiceHelper.GetArrayData<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Site>(targetUrl, typeHint);
    }

    export function ResolveGetSites(resolveTo: KnockoutObservableArray<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Site>): Q.Promise<boolean> {
        return GetSites().then((e) => {
            resolveTo(e);
            return true;
        }, (f) => { return false; });
    }

    export function GetNatures(): Q.Promise<Array<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Nature>> {
        var baseUrl = $.url("portal");
        var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Nature";
        var targetUrl = baseUrl + "api/commonafeapi/getnatures";

        return Aci.Flex.Portal.ServiceHelper.GetArrayData<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Nature>(targetUrl, typeHint);
    }

    export function ResolveGetNatures(resolveTo: KnockoutObservableArray<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Nature>): Q.Promise<boolean> {
        return GetNatures().then((e) => {
            resolveTo(e);
            return true;
        }, (f) => { return false; });
    }

    export function GetPurposes(): Q.Promise<Array<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Purpose>> {
        var baseUrl = $.url("portal");
        var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Purpose";
        var targetUrl = baseUrl + "api/commonafeapi/getpurposes";

        return Aci.Flex.Portal.ServiceHelper.GetArrayData<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Purpose>(targetUrl, typeHint);
    }

    export function ResolveGetPurposes(resolveTo: KnockoutObservableArray<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Purpose>): Q.Promise<boolean> {
        return GetPurposes().then((e) => {
            resolveTo(e);
            return true;
        }, (f) => { return false; });
    }

    export function GetCurrencies(): Q.Promise<Array<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Currency>> {
        var baseUrl = $.url("portal");
        var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Currency";
        var targetUrl = baseUrl + "api/commonafeapi/getcurrencies";

        return Aci.Flex.Portal.ServiceHelper.GetArrayData<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Currency>(targetUrl, typeHint);
    }

    export function ResolveGetCurrencies(resolveTo: KnockoutObservableArray<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Currency>): Q.Promise<boolean> {
        return GetCurrencies().then((e) => {
            resolveTo(e);
            return true;
        }, (f) => { return false; });
    }

    export function GetUsdExchangeRates(): Q.Promise<Array<System.Tuple<number, number>>> {
        var baseUrl = $.url("portal");
        var typeHint = "Tuple";
        var targetUrl = baseUrl + "api/commonafeapi/getusdexchangerates";

        return Aci.Flex.Portal.ServiceHelper.GetArrayData<System.Tuple<number, number>>(targetUrl, typeHint);
    }

    export function ResolveGetUsdExchangeRates(resolveTo: KnockoutObservableArray<System.Tuple<number, number>>): Q.Promise<boolean> {
        return GetUsdExchangeRates().then((e) => {
            resolveTo(e);
            return true;
        }, (f) => { return false; });
    }

    export function GetBudget(divisionId: number, functionId: number, siteId: number, year: number): Q.Promise<number> {
        var baseUrl = $.url("portal");
        var typeHint = "number";
        var targetUrl = baseUrl + "api/commonafeapi/getbudget";

        return Aci.Flex.Portal.ServiceHelper.GetData<number>(targetUrl, typeHint, true);
    }

    export function ResolveGetBudget(divisionId: number, functionId: number, siteId: number, year: number, resolveTo: KnockoutObservable<number>): Q.Promise<boolean> {
        return GetBudget(divisionId, functionId, siteId, year).then((e) => {
            resolveTo(e);
            return true;
        }, (f) => { return false; });
    }


}

