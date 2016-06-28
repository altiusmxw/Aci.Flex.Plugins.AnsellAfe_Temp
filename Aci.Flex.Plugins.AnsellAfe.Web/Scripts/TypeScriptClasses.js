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
                    var DataModel;
                    (function (DataModel) {
                        var Afe = (function () {
                            function Afe() {
                                this.AfeId = ko.observable();
                                this.CreateDate = ko.observable();
                                this.OriginalAfeId = ko.observable();
                                this.DivisionId = ko.observable();
                                this.FunctionId = ko.observable();
                                this.SiteId = ko.observable();
                                this.NatureId = ko.observable();
                                this.PurposeId = ko.observable();
                                this.CurrencyId = ko.observable();
                                this.ExpenditureType = ko.observable();
                            }
                            return Afe;
                        }());
                        DataModel.Afe = Afe;
                        var Division = (function () {
                            function Division() {
                                this.DivisionId = ko.observable();
                                this.DivisionName = ko.observable();
                                this.DivisionCode = ko.observable();
                            }
                            return Division;
                        }());
                        DataModel.Division = Division;
                        var Function = (function () {
                            function Function() {
                                this.FunctionId = ko.observable();
                                this.FunctionName = ko.observable();
                            }
                            return Function;
                        }());
                        DataModel.Function = Function;
                        var Site = (function () {
                            function Site() {
                                this.SiteId = ko.observable();
                                this.SiteName = ko.observable();
                                this.SiteCode = ko.observable();
                                this.Region = ko.observable();
                            }
                            return Site;
                        }());
                        DataModel.Site = Site;
                        var Nature = (function () {
                            function Nature() {
                                this.NatureId = ko.observable();
                                this.NatureName = ko.observable();
                            }
                            return Nature;
                        }());
                        DataModel.Nature = Nature;
                        var Purpose = (function () {
                            function Purpose() {
                                this.PurposeId = ko.observable();
                                this.PurposeName = ko.observable();
                            }
                            return Purpose;
                        }());
                        DataModel.Purpose = Purpose;
                        var Currency = (function () {
                            function Currency() {
                                this.CurrencyId = ko.observable();
                                this.CurrencyName = ko.observable();
                                this.CurrencyCode = ko.observable();
                            }
                            return Currency;
                        }());
                        DataModel.Currency = Currency;
                    })(DataModel = Server.DataModel || (Server.DataModel = {}));
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
                var Server;
                (function (Server) {
                    var Objects;
                    (function (Objects) {
                        var FinancialData = (function () {
                            function FinancialData() {
                                this.AccountId = ko.observable();
                                this.Value = ko.observable();
                            }
                            return FinancialData;
                        }());
                        Objects.FinancialData = FinancialData;
                        var AfeSubmitData = (function () {
                            function AfeSubmitData() {
                                this.Afe = ko.observable(new Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Afe());
                                this.Financials = ko.observableArray([]);
                            }
                            return AfeSubmitData;
                        }());
                        Objects.AfeSubmitData = AfeSubmitData;
                        var SaveAfeReturnDetails = (function () {
                            function SaveAfeReturnDetails() {
                                this.AfeId = ko.observable();
                                this.Success = ko.observable();
                            }
                            return SaveAfeReturnDetails;
                        }());
                        Objects.SaveAfeReturnDetails = SaveAfeReturnDetails;
                    })(Objects = Server.Objects || (Server.Objects = {}));
                })(Server = AnsellAfe.Server || (AnsellAfe.Server = {}));
            })(AnsellAfe = Plugins.AnsellAfe || (Plugins.AnsellAfe = {}));
        })(Plugins = Flex.Plugins || (Flex.Plugins = {}));
    })(Flex = Aci.Flex || (Aci.Flex = {}));
})(Aci || (Aci = {}));
//# sourceMappingURL=TypeScriptClasses.js.map