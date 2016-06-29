var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var byPassWarning = false;
var showLoader, showFindUserLoader;
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
    var findUserViewModel;
    function InitializeViewModel(isSupplement, afeCreateType, origAfeId, creatorName) {
        showLoader = setTimeout(function () {
            if (!$.url('isdebug'))
                initializeFlexUpdateProgress($("#afe-capture-progress"));
            $("#afe-capture-progress").show();
        }, 300);
        setupButtonActions();
        var afeType = isSupplement ? Aci.Flex.Plugins.AnsellAfe.Server.AfeTypeType.Supplement : Aci.Flex.Plugins.AnsellAfe.Server.AfeTypeType.Original;
        viewModel = new AfeCaptureViewModel(afeType, creatorName);
        findUserViewModel = new FindUserViewModel();
        viewModel.InitializeFormDataOptions().then(function () {
            var _loadAfe = Q.fcall(function () {
                if (origAfeId != null && origAfeId > 0) {
                    return loadAfeData(afeType, origAfeId);
                }
                else {
                    return null;
                }
            });
            _loadAfe.then(function () {
                CommonAfeHelper.bindHandlers();
                ko.applyBindings(viewModel, $("#afe-capture-container")[0]);
                ko.applyBindings(findUserViewModel, $("#modal-find-user")[0]);
                $("select.selectpicker").selectpicker();
                clearTimeout(showLoader);
                $("#afe-capture-progress").hide();
            });
        });
    }
    AfeCaptureFormHelper.InitializeViewModel = InitializeViewModel;
    function SaveAfe() {
        submitAfe(false);
    }
    AfeCaptureFormHelper.SaveAfe = SaveAfe;
    function SaveDraftAfe() {
        submitAfe(true);
    }
    AfeCaptureFormHelper.SaveDraftAfe = SaveDraftAfe;
    function submitAfe(isDraft) {
        showLoader = setTimeout(function () {
            if (!$.url('isdebug'))
                initializeFlexUpdateProgress($("#afe-capture-progress"));
            $("#afe-capture-progress").show();
        }, 300);
        var data = buildAfeData();
        var saveAfeCall;
        if (isDraft) {
            saveAfeCall = Flex.ApiClient.SaveAfeApi.SaveDraftAfe(data);
        }
        else {
            saveAfeCall = Flex.ApiClient.SaveAfeApi.SaveAfe(data);
        }
        saveAfeCall.then(function (returnDetails) {
            saveComplete(returnDetails, isDraft);
        });
    }
    function saveComplete(returnDetails, isDraft) {
        if (ko.unwrap(returnDetails.Success)) {
            if (isDraft) {
                swal({ title: "Success!", text: "AFE draft saved successfully.", type: "success", allowOutsideClick: false });
            }
            else {
                swal({ title: "Success!", text: "AFE submitted successfully.", type: "success", allowOutsideClick: false, confirmButtonText: "Go to Workflow" }, function () {
                    byPassWarning = true;
                    window.location.href = $.url("portal") + "workflow";
                });
            }
        }
        else {
            swal({ title: "AFE Save Failed", text: "Could not save AFE.  Please contact an administrator for assistance.", type: "error", allowOutsideClick: false });
        }
        viewModel.AfeId(ko.unwrap(returnDetails.AfeId));
        clearTimeout(showLoader);
        $("#afe-capture-progress").hide();
    }
    function buildAfeData() {
        var submitData;
        submitData = new Aci.Flex.Plugins.AnsellAfe.Server.Objects.AfeSubmitData();
        submitData.Afe = ko.observable(viewModel);
        submitData.AdditionalApprovers = viewModel.AdditionalApproverDetails;
        submitData.Approvers = viewModel.DelegationChain;
        var fact1 = {
            AccountId: ko.observable(1),
            Value: ko.observable(viewModel.Amount_LC().Value())
        };
        var fact2 = {
            AccountId: ko.observable(2),
            Value: ko.observable(viewModel.Budget_LC())
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
            AccountId: ko.observable(9),
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
        return submitData;
    }
    function loadAfeData(afeType, afeId) {
        return Flex.ApiClient.CommonAfeApi.GetAfe(afeId).then(function (afe) {
            var _afe = ko.toJS(afe);
            if (afeType == Aci.Flex.Plugins.AnsellAfe.Server.AfeTypeType.Supplement) {
                viewModel.OriginalAfeId(afeId);
                viewModel.Description(_afe.Description);
                viewModel.Proposal(_afe.Proposal);
                viewModel.ProjectBenefits(_afe.ProjectBenefits);
            }
            viewModel.DivisionId(_afe.DivisionId);
            viewModel.FunctionId(_afe.FunctionId);
            viewModel.SiteId(_afe.SiteId);
            viewModel.NatureId(_afe.NatureId);
            viewModel.PurposeId(_afe.PurposeId);
            viewModel.CurrencyId(_afe.CurrencyId);
            return null;
        });
    }
    function setupButtonActions() {
        $("#btnRequestAdditionalApproval").click(function () {
            $("#btnSaveUser").disable();
            $("#divFindUserResults").hide();
            $("#divNoResults").hide();
            findUserViewModel.ResetSearch();
            $("#modal-find-user").modal('show');
        });
        $("#btnSaveUser").click(function () {
            var selectedId = $("input[name='find-user-results']:radio:checked").val();
            var user = findUserViewModel.GetUser(selectedId);
            viewModel.AdditionalApproverDetails.push(user);
            $("#modal-find-user").modal('hide');
        });
        $("#btnFindUser").click(function () {
            showFindUserLoader = setTimeout(function () {
                if (!$.url('isdebug'))
                    initializeFlexUpdateProgress($("#find-user-progress"));
                $("#find-user-progress").show();
            }, 300);
            $("#divFindUserResults").hide();
            $("#divNoResults").hide();
            Flex.ApiClient.CommonAfeApi.ResolveFindUsers(ko.unwrap(findUserViewModel.Search.Id), ko.unwrap(findUserViewModel.Search.Firstname), ko.unwrap(findUserViewModel.Search.Lastname), ko.unwrap(findUserViewModel.Search.Email), findUserViewModel.SearchResults).then(function () {
                if (findUserViewModel.SearchResults().length == 0) {
                    $("#divNoResults").show();
                }
                else {
                    $("input[name='find-user-results']:radio").click(function () {
                        $("#btnSaveUser").enable();
                    });
                    $("#divFindUserResults").show();
                }
                clearTimeout(showFindUserLoader);
                $("#find-user-progress").hide();
            });
        });
    }
})(AfeCaptureFormHelper || (AfeCaptureFormHelper = {}));
var AfeCaptureViewModel = (function (_super) {
    __extends(AfeCaptureViewModel, _super);
    function AfeCaptureViewModel(afeType, creatorName) {
        var _this = this;
        _super.call(this);
        this.Amount_USD = ko.pureComputed(function () {
            var self = _this;
            var lc = self.Amount_LC().Value();
            return lc * self.ExchangeRate();
        }, this);
        this.Budget_LC = ko.pureComputed(function () {
            var self = _this;
            var lc = self.Budget_USD();
            return lc / self.ExchangeRate();
        }, this);
        this.WriteOff_USD = ko.pureComputed(function () {
            var self = _this;
            var lc = self.WriteOff_LC().Value();
            return lc * self.ExchangeRate();
        }, this);
        this.PrevAfe_LC = ko.pureComputed(function () {
            var self = _this;
            var lc = self.PrevAfe_USD();
            return lc / self.ExchangeRate();
        }, this);
        this.RemainingBudget_LC = ko.pureComputed(function () {
            var self = _this;
            return self.Budget_LC() - (self.Amount_LC().Value() + self.PrevAfe_LC());
        }, this);
        this.RemainingBudget_USD = ko.pureComputed(function () {
            var self = _this;
            return self.Budget_USD() - (self.Amount_USD() + self.PrevAfe_USD());
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
        this.AfeType = ko.observable(afeType == Aci.Flex.Plugins.AnsellAfe.Server.AfeTypeType.Supplement ? "Supplement" : "Original");
        this.CreateDate(new Date());
        this.Amount_LC = ko.observable(new MoneyView(0));
        this.Budget_USD = ko.observable(0);
        this.WriteOff_LC = ko.observable(new MoneyView(0));
        this.NPV = ko.observable(new MoneyView(0));
        this.CashPayback_Before = ko.observable();
        this.CashPayback_After = ko.observable();
        this.AvgReturn = ko.observable();
        this.IRR = ko.observable();
        this.ExchangeRate = ko.observable();
        this.PrevAfe_USD = ko.observable();
        this.DelegationChain = ko.observableArray([]);
        this.AdditionalApproverDetails = ko.observableArray([]);
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
            _this.GetPreviousAfeCosts();
            _this.GetApprovers();
        });
        this.FunctionId.subscribe(function (id) {
            _this.SetBudget(_this.DivisionId(), id, _this.SiteId());
            _this.GetPreviousAfeCosts();
            _this.GetApprovers();
        });
        this.SiteId.subscribe(function (id) {
            _this.SetBudget(_this.DivisionId(), _this.FunctionId(), id);
            _this.GetPreviousAfeCosts();
        });
        this.NatureId.subscribe(function (id) {
            _this.GetApprovers();
        });
        this.Amount_USD.subscribe(function (amount) {
            _this.GetApprovers();
        });
        this.RemainingBudget_USD.subscribe(function (rb) {
            $("#tr-remaining-budget").removeClass("required");
            if (rb < 0) {
                $("#tr-remaining-budget").addClass("required");
            }
        });
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
    AfeCaptureViewModel.prototype.removeApprover = function (approver) {
        var user = ko.utils.arrayFirst(this.AdditionalApproverDetails(), function (aa) {
            return aa.FlexIdentifier == approver.FlexIdentifier;
        });
        if (user) {
            this.AdditionalApproverDetails.remove(user);
        }
    };
    AfeCaptureViewModel.prototype.SetBudget = function (divId, funcId, siteId) {
        var _this = this;
        if (ko.unwrap(this.FunctionId) && ko.unwrap(this.DivisionId) && ko.unwrap(this.SiteId())) {
            Flex.ApiClient.CommonAfeApi.GetBudget(divId, funcId, siteId, 2016).then(function (b) {
                _this.Budget_USD(ko.toJS(b));
            });
        }
        else {
            this.Budget_USD(0);
        }
    };
    AfeCaptureViewModel.prototype.GetApprovers = function () {
        this.DelegationChain.removeAll();
        if (ko.unwrap(this.NatureId) && ko.unwrap(this.DivisionId) && ko.unwrap(this.FunctionId) && ko.unwrap(this.Amount_USD)) {
            Flex.ApiClient.CommonAfeApi.ResolveGetApprovers(ko.unwrap(this.NatureId), ko.unwrap(this.DivisionId), ko.unwrap(this.FunctionId), ko.unwrap(this.Amount_USD), this.DelegationChain);
        }
    };
    AfeCaptureViewModel.prototype.GetPreviousAfeCosts = function () {
        var _this = this;
        if (ko.unwrap(this.FunctionId) && ko.unwrap(this.DivisionId) && ko.unwrap(this.SiteId())) {
            Flex.ApiClient.CommonAfeApi.GetPreviousAfeCosts(ko.unwrap(this.DivisionId), ko.unwrap(this.FunctionId), ko.unwrap(this.SiteId()), 2016).then(function (b) {
                _this.PrevAfe_USD(ko.toJS(b));
            });
        }
        else {
            this.PrevAfe_USD(0);
        }
    };
    return AfeCaptureViewModel;
}(Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Afe));
var FindUserViewModel = (function () {
    function FindUserViewModel() {
        this.Search = {
            Email: ko.observable(""),
            Firstname: ko.observable(""),
            FlexIdentifier: ko.observable(""),
            Id: ko.observable(""),
            Lastname: ko.observable(""),
            Name: ko.observable(""),
            Title: ko.observable("")
        };
        this.SearchResults = ko.observableArray([]);
    }
    FindUserViewModel.prototype.ResetSearch = function () {
        this.Search.Email("");
        this.Search.Firstname("");
        this.Search.FlexIdentifier("");
        this.Search.Id("");
        this.Search.Name("");
        this.Search.Lastname("");
        this.Search.Title("");
        this.SearchResults([]);
    };
    FindUserViewModel.prototype.GetUser = function (selectedId) {
        return ko.utils.arrayFirst(this.SearchResults(), function (u) {
            return ko.unwrap(u.FlexIdentifier) == selectedId;
        });
    };
    return FindUserViewModel;
}());
//# sourceMappingURL=afecapture-form.js.map