module Flex.ApiClient.CommonAfeApi {

export function GetDivisions(): Q.Promise<Array<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Division>>
{
	var baseUrl = $.url("portal");
	var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Division";
	var targetUrl = baseUrl + "api/commonafeapi/GetDivisions";

	return Aci.Flex.Portal.ServiceHelper.GetArrayData<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Division>(targetUrl, typeHint);
}

export function ResolveGetDivisions(resolveTo: KnockoutObservableArray<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Division>) : Q.Promise<boolean>
{
	  return GetDivisions().then	((e) => 
	  {
		resolveTo(e); 
		return true;
	}, (f) => {return false;});
}

export function GetFunctions(): Q.Promise<Array<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Function>>
{
	var baseUrl = $.url("portal");
	var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Function";
	var targetUrl = baseUrl + "api/commonafeapi/GetFunctions";

	return Aci.Flex.Portal.ServiceHelper.GetArrayData<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Function>(targetUrl, typeHint);
}

export function ResolveGetFunctions(resolveTo: KnockoutObservableArray<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Function>) : Q.Promise<boolean>
{
	  return GetFunctions().then	((e) => 
	  {
		resolveTo(e); 
		return true;
	}, (f) => {return false;});
}

export function GetSites(): Q.Promise<Array<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Site>>
{
	var baseUrl = $.url("portal");
	var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Site";
	var targetUrl = baseUrl + "api/commonafeapi/GetSites";

	return Aci.Flex.Portal.ServiceHelper.GetArrayData<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Site>(targetUrl, typeHint);
}

export function ResolveGetSites(resolveTo: KnockoutObservableArray<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Site>) : Q.Promise<boolean>
{
	  return GetSites().then	((e) => 
	  {
		resolveTo(e); 
		return true;
	}, (f) => {return false;});
}

export function GetNatures(): Q.Promise<Array<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Nature>>
{
	var baseUrl = $.url("portal");
	var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Nature";
	var targetUrl = baseUrl + "api/commonafeapi/GetNatures";

	return Aci.Flex.Portal.ServiceHelper.GetArrayData<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Nature>(targetUrl, typeHint);
}

export function ResolveGetNatures(resolveTo: KnockoutObservableArray<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Nature>) : Q.Promise<boolean>
{
	  return GetNatures().then	((e) => 
	  {
		resolveTo(e); 
		return true;
	}, (f) => {return false;});
}

export function GetPurposes(): Q.Promise<Array<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Purpose>>
{
	var baseUrl = $.url("portal");
	var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Purpose";
	var targetUrl = baseUrl + "api/commonafeapi/GetPurposes";

	return Aci.Flex.Portal.ServiceHelper.GetArrayData<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Purpose>(targetUrl, typeHint);
}

export function ResolveGetPurposes(resolveTo: KnockoutObservableArray<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Purpose>) : Q.Promise<boolean>
{
	  return GetPurposes().then	((e) => 
	  {
		resolveTo(e); 
		return true;
	}, (f) => {return false;});
}

export function GetCurrencies(): Q.Promise<Array<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Currency>>
{
	var baseUrl = $.url("portal");
	var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Currency";
	var targetUrl = baseUrl + "api/commonafeapi/GetCurrencies";

	return Aci.Flex.Portal.ServiceHelper.GetArrayData<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Currency>(targetUrl, typeHint);
}

export function ResolveGetCurrencies(resolveTo: KnockoutObservableArray<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Currency>) : Q.Promise<boolean>
{
	  return GetCurrencies().then	((e) => 
	  {
		resolveTo(e); 
		return true;
	}, (f) => {return false;});
}

export function GetUsdExchangeRates(): Q.Promise<Array<System.Tuple<number, number>>>
{
	var baseUrl = $.url("portal");
	var typeHint = "System.Tuple<number, number>";
	var targetUrl = baseUrl + "api/commonafeapi/GetUsdExchangeRates";

	return Aci.Flex.Portal.ServiceHelper.GetArrayData<System.Tuple<number, number>>(targetUrl, typeHint);
}

export function ResolveGetUsdExchangeRates(resolveTo: KnockoutObservableArray<System.Tuple<number, number>>) : Q.Promise<boolean>
{
	  return GetUsdExchangeRates().then	((e) => 
	  {
		resolveTo(e); 
		return true;
	}, (f) => {return false;});
}

export function GetBudget(divisionId: number, functionId: number, siteId: number, year: number): Q.Promise<number>
{
	var baseUrl = $.url("portal");
	var typeHint = "number";
	var targetUrl = baseUrl + "api/commonafeapi/GetBudget"+"?divisionId=" + divisionId+ "&functionId=" + functionId+ "&siteId=" + siteId+ "&year=" + year;

	return Aci.Flex.Portal.ServiceHelper.GetData<number>(targetUrl, typeHint, true);
}

export function ResolveGetBudget(divisionId: number, functionId: number, siteId: number, year: number, resolveTo: KnockoutObservable<number>) : Q.Promise<boolean>
{
	  return GetBudget(divisionId, functionId, siteId, year).then	((e) => 
	  {
		resolveTo(e); 
		return true;
	}, (f) => {return false;});
}

export function GetPreviousAfeCosts(divisionId: number, functionId: number, siteId: number, year: number): Q.Promise<number>
{
	var baseUrl = $.url("portal");
	var typeHint = "number";
	var targetUrl = baseUrl + "api/commonafeapi/GetPreviousAfeCosts"+"?divisionId=" + divisionId+ "&functionId=" + functionId+ "&siteId=" + siteId+ "&year=" + year;

	return Aci.Flex.Portal.ServiceHelper.GetData<number>(targetUrl, typeHint, true);
}

export function ResolveGetPreviousAfeCosts(divisionId: number, functionId: number, siteId: number, year: number, resolveTo: KnockoutObservable<number>) : Q.Promise<boolean>
{
	  return GetPreviousAfeCosts(divisionId, functionId, siteId, year).then	((e) => 
	  {
		resolveTo(e); 
		return true;
	}, (f) => {return false;});
}

export function FindAfes(searchTerm: string): Q.Promise<Array<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Afe>>
{
	var baseUrl = $.url("portal");
	var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Afe";
	var targetUrl = baseUrl + "api/commonafeapi/FindAfes"+"?searchTerm=" + searchTerm;

	return Aci.Flex.Portal.ServiceHelper.GetArrayData<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Afe>(targetUrl, typeHint);
}

export function ResolveFindAfes(searchTerm: string, resolveTo: KnockoutObservableArray<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Afe>) : Q.Promise<boolean>
{
	  return FindAfes(searchTerm).then	((e) => 
	  {
		resolveTo(e); 
		return true;
	}, (f) => {return false;});
}

export function GetAfe(afeId: number): Q.Promise<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Afe>
{
	var baseUrl = $.url("portal");
	var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Afe";
	var targetUrl = baseUrl + "api/commonafeapi/GetAfe"+"?afeId=" + afeId;

	return Aci.Flex.Portal.ServiceHelper.GetData<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Afe>(targetUrl, typeHint, true);
}

export function ResolveGetAfe(afeId: number, resolveTo: KnockoutObservable<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Afe>) : Q.Promise<boolean>
{
	  return GetAfe(afeId).then	((e) => 
	  {
		resolveTo(e); 
		return true;
	}, (f) => {return false;});
}

export function FindUsers(ntId: string, firstname: string, lastname: string, email: string): Q.Promise<Array<Aci.Flex.Core.PersonInfo>>
{
	var baseUrl = $.url("portal");
	var typeHint = "Aci.Flex.Core.PersonInfo";
	var targetUrl = baseUrl + "api/commonafeapi/FindUsers"+"?ntId=" + ntId+ "&firstname=" + firstname+ "&lastname=" + lastname+ "&email=" + email;

	return Aci.Flex.Portal.ServiceHelper.GetArrayData<Aci.Flex.Core.PersonInfo>(targetUrl, typeHint);
}

export function ResolveFindUsers(ntId: string, firstname: string, lastname: string, email: string, resolveTo: KnockoutObservableArray<Aci.Flex.Core.PersonInfo>) : Q.Promise<boolean>
{
	  return FindUsers(ntId, firstname, lastname, email).then	((e) => 
	  {
		resolveTo(e); 
		return true;
	}, (f) => {return false;});
}

export function GetApprovers(natureId: number, divisionId: number, functionId: number, amount: number): Q.Promise<Array<Aci.Flex.Core.PersonInfo>>
{
	var baseUrl = $.url("portal");
	var typeHint = "Aci.Flex.Core.PersonInfo";
	var targetUrl = baseUrl + "api/commonafeapi/GetApprovers"+"?natureId=" + natureId+ "&divisionId=" + divisionId+ "&functionId=" + functionId+ "&amount=" + amount;

	return Aci.Flex.Portal.ServiceHelper.GetArrayData<Aci.Flex.Core.PersonInfo>(targetUrl, typeHint);
}

export function ResolveGetApprovers(natureId: number, divisionId: number, functionId: number, amount: number, resolveTo: KnockoutObservableArray<Aci.Flex.Core.PersonInfo>) : Q.Promise<boolean>
{
	  return GetApprovers(natureId, divisionId, functionId, amount).then	((e) => 
	  {
		resolveTo(e); 
		return true;
	}, (f) => {return false;});
}


}

