var Flex;
(function (Flex) {
    var ApiClient;
    (function (ApiClient) {
        var SaveAfeApi;
        (function (SaveAfeApi) {
            function SaveAfe(afe) {
                var baseUrl = $.url("portal");
                var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.Objects.SaveAfeReturnDetails";
                var targetUrl = baseUrl + "api/saveafeapi/saveafe";
                var payload = ko.toJSON(afe);
                return Aci.Flex.Portal.ServiceHelper.PostData(targetUrl, payload);
            }
            SaveAfeApi.SaveAfe = SaveAfe;
            function ResolveSaveAfe(afe, resolveTo) {
                return SaveAfe(afe).then(function (e) {
                    resolveTo(e);
                    return true;
                }, function (f) { return false; });
            }
            SaveAfeApi.ResolveSaveAfe = ResolveSaveAfe;
            function SaveDraftAfe(afe) {
                var baseUrl = $.url("portal");
                var typeHint = "Aci.Flex.Plugins.AnsellAfe.Server.Objects.SaveAfeReturnDetails";
                var targetUrl = baseUrl + "api/saveafeapi/savedraftafe";
                var payload = ko.toJSON(afe);
                return Aci.Flex.Portal.ServiceHelper.PostData(targetUrl, payload);
            }
            SaveAfeApi.SaveDraftAfe = SaveDraftAfe;
            function ResolveSaveDraftAfe(afe, resolveTo) {
                return SaveDraftAfe(afe).then(function (e) {
                    resolveTo(e);
                    return true;
                }, function (f) { return false; });
            }
            SaveAfeApi.ResolveSaveDraftAfe = ResolveSaveDraftAfe;
        })(SaveAfeApi = ApiClient.SaveAfeApi || (ApiClient.SaveAfeApi = {}));
    })(ApiClient = Flex.ApiClient || (Flex.ApiClient = {}));
})(Flex || (Flex = {}));
//# sourceMappingURL=SaveAfeApiController.js.map