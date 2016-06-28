var Aci;
(function (Aci) {
    var Flex;
    (function (Flex) {
        var Plugins;
        (function (Plugins) {
            var AnsellAfe;
            (function (AnsellAfe) {
                var Server;
                (function (Server) {
                    (function (AfeTypeType) {
                        AfeTypeType[AfeTypeType["Original"] = 0] = "Original";
                        AfeTypeType[AfeTypeType["Supplement"] = 1] = "Supplement";
                    })(Server.AfeTypeType || (Server.AfeTypeType = {}));
                    var AfeTypeType = Server.AfeTypeType;
                    (function (AfeStatus) {
                        AfeStatus[AfeStatus["Pending"] = 0] = "Pending";
                        AfeStatus[AfeStatus["Approved"] = 1] = "Approved";
                        AfeStatus[AfeStatus["Closed"] = 2] = "Closed";
                    })(Server.AfeStatus || (Server.AfeStatus = {}));
                    var AfeStatus = Server.AfeStatus;
                })(Server = AnsellAfe.Server || (AnsellAfe.Server = {}));
            })(AnsellAfe = Plugins.AnsellAfe || (Plugins.AnsellAfe = {}));
        })(Plugins = Flex.Plugins || (Flex.Plugins = {}));
    })(Flex = Aci.Flex || (Aci.Flex = {}));
})(Aci || (Aci = {}));
var Aci;
(function (Aci) {
    var Flex;
    (function (Flex) {
        var Plugins;
        (function (Plugins) {
            var AnsellAfe;
            (function (AnsellAfe) {
                var Web;
                (function (Web) {
                    var Models;
                    (function (Models) {
                        (function (AfeCreateType) {
                            AfeCreateType[AfeCreateType["Clone"] = 0] = "Clone";
                            AfeCreateType[AfeCreateType["Edit"] = 1] = "Edit";
                            AfeCreateType[AfeCreateType["New"] = 2] = "New";
                            AfeCreateType[AfeCreateType["Resubmit"] = 3] = "Resubmit";
                        })(Models.AfeCreateType || (Models.AfeCreateType = {}));
                        var AfeCreateType = Models.AfeCreateType;
                    })(Models = Web.Models || (Web.Models = {}));
                })(Web = AnsellAfe.Web || (AnsellAfe.Web = {}));
            })(AnsellAfe = Plugins.AnsellAfe || (Plugins.AnsellAfe = {}));
        })(Plugins = Flex.Plugins || (Flex.Plugins = {}));
    })(Flex = Aci.Flex || (Aci.Flex = {}));
})(Aci || (Aci = {}));
//# sourceMappingURL=Enum.js.map