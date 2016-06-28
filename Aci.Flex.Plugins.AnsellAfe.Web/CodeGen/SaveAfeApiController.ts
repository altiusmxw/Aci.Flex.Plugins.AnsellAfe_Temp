module Flex.ApiClient.SaveAfeApi {

export function SaveAfe(afe: Aci.Flex.Plugins.AnsellAfe.Server.Objects.AfeSubmitData): Q.Promise<Aci.Flex.Plugins.AnsellAfe.Server.Objects.SaveAfeReturnDetails>
{
	var baseUrl = $.url("portal");
	var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.Objects.SaveAfeReturnDetails";
	var targetUrl = baseUrl + "api/saveafeapi/saveafe";
    var payload = ko.toJSON(afe);
	return Aci.Flex.Portal.ServiceHelper.PostData<Aci.Flex.Plugins.AnsellAfe.Server.Objects.SaveAfeReturnDetails>(targetUrl, payload);
}

export function ResolveSaveAfe(afe: Aci.Flex.Plugins.AnsellAfe.Server.Objects.AfeSubmitData, resolveTo: KnockoutObservable<Aci.Flex.Plugins.AnsellAfe.Server.Objects.SaveAfeReturnDetails>) : Q.Promise<boolean>
{
	  return SaveAfe(afe).then	((e) => 
	  {
		resolveTo(e); 
		return true;
	}, (f) => {return false;});
}

export function SaveDraftAfe(afe: Aci.Flex.Plugins.AnsellAfe.Server.Objects.AfeSubmitData): Q.Promise<Aci.Flex.Plugins.AnsellAfe.Server.Objects.SaveAfeReturnDetails>
{
	var baseUrl = $.url("portal");
	var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.Objects.SaveAfeReturnDetails";
	var targetUrl = baseUrl + "api/saveafeapi/savedraftafe";
    var payload = ko.toJSON(afe);
	return Aci.Flex.Portal.ServiceHelper.PostData<Aci.Flex.Plugins.AnsellAfe.Server.Objects.SaveAfeReturnDetails>(targetUrl, payload);
}

export function ResolveSaveDraftAfe(afe: Aci.Flex.Plugins.AnsellAfe.Server.Objects.AfeSubmitData, resolveTo: KnockoutObservable<Aci.Flex.Plugins.AnsellAfe.Server.Objects.SaveAfeReturnDetails>) : Q.Promise<boolean>
{
	  return SaveDraftAfe(afe).then	((e) => 
	  {
		resolveTo(e); 
		return true;
	}, (f) => {return false;});
}


}

