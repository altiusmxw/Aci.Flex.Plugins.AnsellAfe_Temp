var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var byPassWarning = false;
var showLoader;
$().ready(function () {
    window.onbeforeunload = function () {
        if (!byPassWarning) {
            return "Are you sure you want to leave this page? Any unsaved changes will be lost.";
        }
    };
});
var AfeCaptureFormHelper;
(function (AfeCaptureFormHelper) {
    var viewModel;
    function InitializeViewModel(isSupplement, afeCreateType, origAfeId, creatorName) {
        showLoader = setTimeout(function () {
            if (!$.url('isdebug'))
                initializeFlexUpdateProgress($("#afe-capture-progress"));
            $("#afe-capture-progress").show();
        }, 300);
        var afeType = isSupplement ? Aci.Flex.Plugins.AnsellAfe.Server.AfeTypeType.Supplement : Aci.Flex.Plugins.AnsellAfe.Server.AfeTypeType.Original;
        viewModel = new AfeCaptureViewModel(afeType, origAfeId, creatorName);
        viewModel.InitializeFormDataOptions().then(function () {
            CommonAfeHelper.bindHandlers();
            ko.applyBindings(viewModel, $("#afe-capture-container")[0]);
            $("select.selectpicker").selectpicker();
            clearTimeout(showLoader);
            $("#afe-capture-progress").hide();
        });
        //UserSearcher.Initialize("Find AFE Owner", viewModel.AfeOwner);
    }
    AfeCaptureFormHelper.InitializeViewModel = InitializeViewModel;
    function SaveAfe() {
        var submitData;
        submitData = new Aci.Flex.Plugins.AnsellAfe.Server.Objects.AfeSubmitData();
        submitData.Afe = ko.observable(viewModel);
        var fact1 = {
            AccountId: ko.observable(1),
            Value: ko.observable(viewModel.Amount_LC().Value())
        };
        var fact2 = {
            AccountId: ko.observable(2),
            Value: ko.observable(viewModel.Budget_LC().Value())
        };
        var fact3 = {
            AccountId: ko.observable(3),
            Value: ko.observable(viewModel.CashPayback_Before())
        };
        var fact4 = {
            AccountId: ko.observable(4),
            Value: ko.observable(viewModel.CashPayback_After())
        };
        var fact5 = {
            AccountId: ko.observable(5),
            Value: ko.observable(viewModel.AvgReturn())
        };
        var fact6 = {
            AccountId: ko.observable(6),
            Value: ko.observable(viewModel.NPV().Value())
        };
        var fact7 = {
            AccountId: ko.observable(7),
            Value: ko.observable(viewModel.IRR())
        };
        var fact8 = {
            AccountId: ko.observable(8),
            Value: ko.observable(viewModel.WriteOff_LC().Value())
        };
        submitData.Financials.push(fact1);
        submitData.Financials.push(fact2);
        submitData.Financials.push(fact3);
        submitData.Financials.push(fact4);
        submitData.Financials.push(fact5);
        submitData.Financials.push(fact6);
        submitData.Financials.push(fact7);
        submitData.Financials.push(fact8);
    }
    AfeCaptureFormHelper.SaveAfe = SaveAfe;
    function SaveDraftAfe() {
    }
    AfeCaptureFormHelper.SaveDraftAfe = SaveDraftAfe;
})(AfeCaptureFormHelper || (AfeCaptureFormHelper = {}));
var AfeCaptureViewModel = (function (_super) {
    __extends(AfeCaptureViewModel, _super);
    function AfeCaptureViewModel(afeType, origAfeId, creatorName) {
        var _this = this;
        _super.call(this);
        this.Amount_USD = ko.pureComputed(function () {
            var self = _this;
            var lc = self.Amount_LC().Value();
            return lc * self.ExchangeRate();
        }, this);
        this.Budget_USD = ko.pureComputed(function () {
            var self = _this;
            var lc = self.Budget_LC().Value();
            return lc * self.ExchangeRate();
        }, this);
        this.WriteOff_USD = ko.pureComputed(function () {
            var self = _this;
            var lc = self.WriteOff_LC().Value();
            return lc * self.ExchangeRate();
        }, this);
        this.ExpenditureTypeOptions = [];
        this.DivisionOptions = [];
        this.FunctionOptions = [];
        this.SiteOptions = [];
        this.NatureOptions = [];
        this.PurposeOptions = [];
        this.CurrencyOptions = [];
        this.ExchangeRates = [];
        var self = this;
        this.CreatorName = creatorName;
        this.CreateDate(new Date());
        this.Amount_LC = ko.observable(new MoneyView(0));
        this.Budget_LC = ko.observable(new MoneyView(0));
        this.WriteOff_LC = ko.observable(new MoneyView(0));
        this.NPV = ko.observable(new MoneyView(0));
        this.CashPayback_Before = ko.observable();
        this.CashPayback_After = ko.observable();
        this.AvgReturn = ko.observable();
        this.IRR = ko.observable();
        this.ExchangeRate = ko.observable();
        this.CurrencyId.subscribe(function (id) {
            var ex = ko.utils.arrayFirst(self.ExchangeRates, function (er) {
                return er.Item1 == id;
            });
            if (!ex)
                self.ExchangeRate(1);
            else
                self.ExchangeRate(ex.Item2);
        });
        this.DivisionId.subscribe(function (id) {
            _this.SetBudget(id, _this.FunctionId(), _this.SiteId());
        });
        this.FunctionId.subscribe(function (id) {
            _this.SetBudget(_this.DivisionId(), id, _this.SiteId());
        });
        this.SiteId.subscribe(function (id) {
            _this.SetBudget(_this.DivisionId(), _this.FunctionId(), id);
        });
        if (afeType == Aci.Flex.Plugins.AnsellAfe.Server.AfeTypeType.Supplement)
            this.OriginalAfeId(origAfeId);
    }
    AfeCaptureViewModel.prototype.InitializeFormDataOptions = function () {
        var self = this;
        var getDivisions = Flex.ApiClient.CommonAfeApi.GetDivisions().then(function (results) {
            self.DivisionOptions = [];
            results.forEach(function (r) {
                var option = {
                    value: ko.unwrap(r.DivisionId),
                    text: ko.unwrap(r.DivisionCode) + ' - ' + ko.unwrap(r.DivisionName)
                };
                self.DivisionOptions.push(option);
            });
            return null;
        });
        var getFunctions = Flex.ApiClient.CommonAfeApi.GetFunctions().then(function (results) {
            self.FunctionOptions = [];
            results.forEach(function (r) {
                var option = {
                    value: ko.unwrap(r.FunctionId),
                    text: ko.unwrap(r.FunctionName)
                };
                self.FunctionOptions.push(option);
            });
            return null;
        });
        var getSites = Flex.ApiClient.CommonAfeApi.GetSites().then(function (results) {
            self.SiteOptions = [];
            results.forEach(function (r) {
                var option = {
                    value: ko.unwrap(r.SiteId),
                    text: ko.unwrap(r.SiteName)
                };
                self.SiteOptions.push(option);
            });
            return null;
        });
        var getNatures = Flex.ApiClient.CommonAfeApi.GetNatures().then(function (results) {
            self.NatureOptions = [];
            results.forEach(function (r) {
                var option = {
                    value: ko.unwrap(r.NatureId),
                    text: ko.unwrap(r.NatureName)
                };
                self.NatureOptions.push(option);
            });
            return null;
        });
        var getPurposes = Flex.ApiClient.CommonAfeApi.GetPurposes().then(function (results) {
            self.PurposeOptions = [];
            results.forEach(function (r) {
                var option = {
                    value: ko.unwrap(r.PurposeId),
                    text: ko.unwrap(r.PurposeName)
                };
                self.PurposeOptions.push(option);
            });
            return null;
        });
        var getCurrencies = Flex.ApiClient.CommonAfeApi.GetCurrencies().then(function (results) {
            self.CurrencyOptions = [];
            results.forEach(function (r) {
                var option = {
                    value: ko.unwrap(r.CurrencyId),
                    text: ko.unwrap(r.CurrencyCode)
                };
                self.CurrencyOptions.push(option);
            });
            return null;
        });
        var getUsdExchangeRates = Flex.ApiClient.CommonAfeApi.GetUsdExchangeRates().then(function (results) {
            results.forEach(function (r) {
                self.ExchangeRates.push(new System.Tuple(ko.unwrap(r.m_Item1), ko.unwrap(r.m_Item2)));
            });
            return null;
        });
        var capital = new SelectListOption();
        capital.text = 'Capital';
        capital.value = 'Capital';
        var revenue = new SelectListOption();
        revenue.text = 'Revenue';
        revenue.value = 'Revenue';
        this.ExpenditureTypeOptions.push(capital);
        this.ExpenditureTypeOptions.push(revenue);
        return Q.allSettled([getDivisions, getFunctions, getSites, getNatures, getPurposes, getCurrencies, getUsdExchangeRates]).then(function (results) {
            return null;
        });
    };
    AfeCaptureViewModel.prototype.SetBudget = function (divId, funcId, siteId) {
        var budget = this.Budget_LC();
        if (ko.unwrap(this.FunctionId) && ko.unwrap(this.DivisionId) && ko.unwrap(this.SiteId())) {
            Flex.ApiClient.CommonAfeApi.GetBudget(divId, funcId, siteId, 2016).then(function (b) {
                budget.Text(ko.toJS(b).toString());
            });
        }
        else {
            budget.Text("");
        }
    };
    return AfeCaptureViewModel;
}(Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Afe));
//# sourceMappingURL=afecapture-form.js.map