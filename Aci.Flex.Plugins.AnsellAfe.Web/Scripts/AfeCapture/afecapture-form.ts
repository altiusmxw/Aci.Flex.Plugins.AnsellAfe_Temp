var byPassWarning: boolean = false;
var showLoader, showFindUserLoader;

$().ready(function () {
    window.onbeforeunload = () => {
        if (!byPassWarning) {
            return "Are you sure you want to leave this page? Any unsaved changes will be lost."
        }
    };
});

module AfeCaptureFormHelper {
    var viewModel: AfeCaptureViewModel;
    var findUserViewModel: FindUserViewModel;

    export function InitializeViewModel(isSupplement: boolean, afeCreateType: Aci.Flex.Plugins.AnsellAfe.Web.Models.AfeCreateType, origAfeId: number, creatorName: string) {
        showLoader = setTimeout(function () {
            if (!$.url('isdebug'))
                initializeFlexUpdateProgress($("#afe-capture-progress"));
            $("#afe-capture-progress").show();
        }, 300);

        setupButtonActions();

        var afeType: Aci.Flex.Plugins.AnsellAfe.Server.AfeTypeType = isSupplement ? Aci.Flex.Plugins.AnsellAfe.Server.AfeTypeType.Supplement : Aci.Flex.Plugins.AnsellAfe.Server.AfeTypeType.Original;
        viewModel = new AfeCaptureViewModel(afeType, creatorName);
        findUserViewModel = new FindUserViewModel();

        viewModel.InitializeFormDataOptions().then(() => {

            var _loadAfe = Q.fcall(() => {
                if (origAfeId != null && origAfeId > 0) {
                    return loadAfeData(afeType, origAfeId);
                }
                else {
                    return null;
                }
            });

            _loadAfe.then(() => {
                CommonAfeHelper.bindHandlers();

                ko.applyBindings(viewModel, $("#afe-capture-container")[0]);
                ko.applyBindings(findUserViewModel, $("#modal-find-user")[0]);
                $("select.selectpicker").selectpicker();

                clearTimeout(showLoader);
                $("#afe-capture-progress").hide();
            });          
        });
    }

    export function SaveAfe() {
        submitAfe(false);
    }

    export function SaveDraftAfe() {
        submitAfe(true);
    }

    function submitAfe(isDraft: boolean) {
        showLoader = setTimeout(function () {
            if (!$.url('isdebug'))
                initializeFlexUpdateProgress($("#afe-capture-progress"));
            $("#afe-capture-progress").show();
        }, 300);

        var data = buildAfeData();
        var saveAfeCall: Q.Promise<Aci.Flex.Plugins.AnsellAfe.Server.Objects.SaveAfeReturnDetails>;

        if (isDraft) {
            saveAfeCall = Flex.ApiClient.SaveAfeApi.SaveDraftAfe(data);
        }
        else {
            saveAfeCall = Flex.ApiClient.SaveAfeApi.SaveAfe(data);
        }

        saveAfeCall.then((returnDetails) => {
            saveComplete(returnDetails, isDraft);
        });
    }

    function saveComplete(returnDetails: Aci.Flex.Plugins.AnsellAfe.Server.Objects.SaveAfeReturnDetails, isDraft: boolean) {

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

    function buildAfeData() : Aci.Flex.Plugins.AnsellAfe.Server.Objects.AfeSubmitData {
        var submitData: Aci.Flex.Plugins.AnsellAfe.Server.Objects.AfeSubmitData;

        submitData = new Aci.Flex.Plugins.AnsellAfe.Server.Objects.AfeSubmitData();
        submitData.Afe = ko.observable<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Afe>(viewModel);

        submitData.AdditionalApprovers = viewModel.AdditionalApproverDetails;
        submitData.Approvers = viewModel.DelegationChain;

        var fact1: Aci.Flex.Plugins.AnsellAfe.Server.Objects.FinancialData = {
            AccountId: ko.observable<number>(1),
            Value: ko.observable<number>(viewModel.Amount_LC().Value())
        };
        var fact2: Aci.Flex.Plugins.AnsellAfe.Server.Objects.FinancialData = {
            AccountId: ko.observable<number>(2),
            Value: ko.observable<number>(viewModel.Budget_LC())
        };
        var fact3: Aci.Flex.Plugins.AnsellAfe.Server.Objects.FinancialData = {
            AccountId: ko.observable<number>(3),
            Value: ko.observable<number>(viewModel.CashPayback_Before())
        };
        var fact4: Aci.Flex.Plugins.AnsellAfe.Server.Objects.FinancialData = {
            AccountId: ko.observable<number>(4),
            Value: ko.observable<number>(viewModel.CashPayback_After())
        };
        var fact5: Aci.Flex.Plugins.AnsellAfe.Server.Objects.FinancialData = {
            AccountId: ko.observable<number>(5),
            Value: ko.observable<number>(viewModel.AvgReturn())
        };
        var fact6: Aci.Flex.Plugins.AnsellAfe.Server.Objects.FinancialData = {
            AccountId: ko.observable<number>(6),
            Value: ko.observable<number>(viewModel.NPV().Value())
        };
        var fact7: Aci.Flex.Plugins.AnsellAfe.Server.Objects.FinancialData = {
            AccountId: ko.observable<number>(7),
            Value: ko.observable<number>(viewModel.IRR())
        };
        var fact8: Aci.Flex.Plugins.AnsellAfe.Server.Objects.FinancialData = {
            AccountId: ko.observable<number>(9),
            Value: ko.observable<number>(viewModel.WriteOff_LC().Value())
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

    function loadAfeData(afeType: Aci.Flex.Plugins.AnsellAfe.Server.AfeTypeType, afeId: number): Q.Promise<{}> {
        return Flex.ApiClient.CommonAfeApi.GetAfe(afeId).then((afe) => {

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

            Flex.ApiClient.CommonAfeApi.ResolveFindUsers(
                ko.unwrap(findUserViewModel.Search.Id),
                ko.unwrap(findUserViewModel.Search.Firstname),
                ko.unwrap(findUserViewModel.Search.Lastname),
                ko.unwrap(findUserViewModel.Search.Email),
                findUserViewModel.SearchResults).then(() => {

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
}


class AfeCaptureViewModel extends Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Afe {

    CreatorName: string;
    AfeType: KnockoutObservable<string>;
    ExchangeRate: KnockoutObservable<number>;
    Amount_LC: KnockoutObservable<MoneyView>;
    Amount_USD: KnockoutComputed<number> = ko.pureComputed<number>(() => {
        var self = this;
        var lc = self.Amount_LC().Value();
        return lc * self.ExchangeRate();
    }, this);
    Budget_USD: KnockoutObservable<number>;
    Budget_LC: KnockoutComputed<number> = ko.pureComputed<number>(() => {
        var self = this;
        var lc = self.Budget_USD();
        return lc / self.ExchangeRate();
    }, this);
    WriteOff_LC: KnockoutObservable<MoneyView>;
    WriteOff_USD: KnockoutComputed<number> = ko.pureComputed<number>(() => {
        var self = this;
        var lc = self.WriteOff_LC().Value();
        return lc * self.ExchangeRate();
    }, this);
    CashPayback_Before: KnockoutObservable<number>;
    CashPayback_After: KnockoutObservable<number>;
    AvgReturn: KnockoutObservable<number>;
    NPV: KnockoutObservable<MoneyView>;
    IRR: KnockoutObservable<number>;
    PrevAfe_LC: KnockoutComputed<number> = ko.pureComputed<number>(() => {
        var self = this;
        var lc = self.PrevAfe_USD();
        return lc / self.ExchangeRate();
    }, this);
    PrevAfe_USD: KnockoutObservable<number>;
    RemainingBudget_LC: KnockoutComputed<number> = ko.pureComputed<number>(() => {
        var self = this;
        return self.Budget_LC() - (self.Amount_LC().Value() + self.PrevAfe_LC());
    }, this);
    RemainingBudget_USD: KnockoutComputed<number> = ko.pureComputed<number>(() => {
        var self = this;
        return self.Budget_USD() - (self.Amount_USD() + self.PrevAfe_USD());
    }, this);

    DelegationChain: KnockoutObservableArray<Aci.Flex.Core.PersonInfo>;
    AdditionalApproverDetails: KnockoutObservableArray<Aci.Flex.Core.PersonInfo>;

    ExpenditureTypeOptions: Array<SelectListOption> = [];
    DivisionOptions: Array<SelectListOption> = [];
    FunctionOptions: Array<SelectListOption> = [];
    SiteOptions: Array<SelectListOption> = [];
    NatureOptions: Array<SelectListOption> = [];
    PurposeOptions: Array<SelectListOption> = [];
    CurrencyOptions: Array<SelectListOption> = [];
    ExchangeRates: Array<System.Tuple<number, number>> = [];

    constructor(afeType: Aci.Flex.Plugins.AnsellAfe.Server.AfeTypeType, creatorName: string) {
        super();
        var self = this;

        this.CreatorName = creatorName;
        this.AfeType = ko.observable<string>(afeType == Aci.Flex.Plugins.AnsellAfe.Server.AfeTypeType.Supplement ? "Supplement" : "Original");
        this.CreateDate(new Date());
        this.Amount_LC = ko.observable<MoneyView>(new MoneyView(0));
        this.Budget_USD = ko.observable<number>(0);
        this.WriteOff_LC = ko.observable<MoneyView>(new MoneyView(0));
        this.NPV = ko.observable<MoneyView>(new MoneyView(0));
        this.CashPayback_Before = ko.observable<number>();
        this.CashPayback_After = ko.observable<number>();
        this.AvgReturn = ko.observable<number>();
        this.IRR = ko.observable<number>();
        this.ExchangeRate = ko.observable<number>();
        this.PrevAfe_USD = ko.observable<number>();

        this.DelegationChain = ko.observableArray<Aci.Flex.Core.PersonInfo>([]);
        this.AdditionalApproverDetails = ko.observableArray<Aci.Flex.Core.PersonInfo>([]);

        this.CurrencyId.subscribe((id) => {
            var ex = ko.utils.arrayFirst(self.ExchangeRates, (er) => {
                return er.Item1 == id;
            });

            if (!ex)
                self.ExchangeRate(1);
            else
                self.ExchangeRate(ex.Item2);
        });
        this.DivisionId.subscribe((id) => {
            this.SetBudget(id, this.FunctionId(), this.SiteId());
            this.GetPreviousAfeCosts();
            this.GetApprovers();
        });
        this.FunctionId.subscribe((id) => {
            this.SetBudget(this.DivisionId(), id, this.SiteId());
            this.GetPreviousAfeCosts();
            this.GetApprovers();
        });
        this.SiteId.subscribe((id) => {
            this.SetBudget(this.DivisionId(), this.FunctionId(), id);
            this.GetPreviousAfeCosts();
        });
        this.NatureId.subscribe((id) => {
            this.GetApprovers();
        });
        this.Amount_USD.subscribe((amount) => {
            this.GetApprovers();
        });
        this.RemainingBudget_USD.subscribe((rb) => {
            $("#tr-remaining-budget").removeClass("required");

            if (rb < 0) {
                $("#tr-remaining-budget").addClass("required");
            }
        });
    }

    public InitializeFormDataOptions(): Q.Promise<{}> {
        var self = this;

        var getDivisions = Flex.ApiClient.CommonAfeApi.GetDivisions().then((results) => {
            self.DivisionOptions = [];
            results.forEach((r) => {
                var option: SelectListOption = {
                    value: ko.unwrap(r.DivisionId),
                    text: ko.unwrap(r.DivisionCode) + ' - ' + ko.unwrap(r.DivisionName)
                };
                self.DivisionOptions.push(option);
            });
            return null;
        });
        var getFunctions = Flex.ApiClient.CommonAfeApi.GetFunctions().then((results) => {
            self.FunctionOptions = [];
            results.forEach((r) => {
                var option: SelectListOption = {
                    value: ko.unwrap(r.FunctionId),
                    text: ko.unwrap(r.FunctionName)
                };
                self.FunctionOptions.push(option);
            });
            return null;
        });
        var getSites = Flex.ApiClient.CommonAfeApi.GetSites().then((results) => {
            self.SiteOptions = [];
            results.forEach((r) => {
                var option: SelectListOption = {
                    value: ko.unwrap(r.SiteId),
                    text: ko.unwrap(r.SiteName)
                };
                self.SiteOptions.push(option);
            });
            return null;
        });
        var getNatures = Flex.ApiClient.CommonAfeApi.GetNatures().then((results) => {
            self.NatureOptions = [];
            results.forEach((r) => {
                var option: SelectListOption = {
                    value: ko.unwrap(r.NatureId),
                    text: ko.unwrap(r.NatureName)
                };
                self.NatureOptions.push(option);
            });
            return null;
        });
        var getPurposes = Flex.ApiClient.CommonAfeApi.GetPurposes().then((results) => {
            self.PurposeOptions = [];
            results.forEach((r) => {
                var option: SelectListOption = {
                    value: ko.unwrap(r.PurposeId),
                    text: ko.unwrap(r.PurposeName)
                };
                self.PurposeOptions.push(option);
            });
            return null;
        });
        var getCurrencies = Flex.ApiClient.CommonAfeApi.GetCurrencies().then((results) => {
            self.CurrencyOptions = [];
            results.forEach((r) => {
                var option: SelectListOption = {
                    value: ko.unwrap(r.CurrencyId),
                    text: ko.unwrap(r.CurrencyCode)
                };
                self.CurrencyOptions.push(option);
            });
            return null;
        });
        var getUsdExchangeRates = Flex.ApiClient.CommonAfeApi.GetUsdExchangeRates().then((results) => {
            results.forEach((r) => {
                self.ExchangeRates.push(new System.Tuple<number, number>(ko.unwrap(r.m_Item1), ko.unwrap(r.m_Item2)));
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

        return Q.allSettled([getDivisions, getFunctions, getSites, getNatures, getPurposes, getCurrencies, getUsdExchangeRates]).then((results) => {
            return null;
        });
    }

    removeApprover(approver: Aci.Flex.Core.PersonInfo) {
        var user = ko.utils.arrayFirst(this.AdditionalApproverDetails(), (aa) => {
            return aa.FlexIdentifier == approver.FlexIdentifier;
        });

        if (user) {
            this.AdditionalApproverDetails.remove(user);
        }
    }

    private SetBudget(divId: number, funcId: number, siteId: number) {
        if (ko.unwrap(this.FunctionId) && ko.unwrap(this.DivisionId) && ko.unwrap(this.SiteId())) {
            Flex.ApiClient.CommonAfeApi.GetBudget(divId, funcId, siteId, 2016).then((b) => {
                this.Budget_USD(ko.toJS(b));
            });
        }
        else {
            this.Budget_USD(0);
        }
    }

    private GetApprovers() {
        this.DelegationChain.removeAll();

        if (ko.unwrap(this.NatureId) && ko.unwrap(this.DivisionId) && ko.unwrap(this.FunctionId) && ko.unwrap(this.Amount_USD)) {
            Flex.ApiClient.CommonAfeApi.ResolveGetApprovers(ko.unwrap(this.NatureId), ko.unwrap(this.DivisionId), ko.unwrap(this.FunctionId), ko.unwrap(this.Amount_USD), this.DelegationChain);
        }
    }

    private GetPreviousAfeCosts() {
        if (ko.unwrap(this.FunctionId) && ko.unwrap(this.DivisionId) && ko.unwrap(this.SiteId())) {
            Flex.ApiClient.CommonAfeApi.GetPreviousAfeCosts(ko.unwrap(this.DivisionId), ko.unwrap(this.FunctionId), ko.unwrap(this.SiteId()), 2016).then((b) => {
                this.PrevAfe_USD(ko.toJS(b));
            });
        }
        else {
            this.PrevAfe_USD(0);
        }
    }
}

class FindUserViewModel {
    Search: Aci.Flex.Core.PersonInfo;
    SearchResults: KnockoutObservableArray<Aci.Flex.Core.PersonInfo>;

    constructor() {
        this.Search = {
            Email: ko.observable<string>(""),
            Firstname: ko.observable<string>(""),
            FlexIdentifier: ko.observable<string>(""),
            Id: ko.observable<string>(""),
            Lastname: ko.observable<string>(""),
            Name: ko.observable<string>(""),
            Title: ko.observable<string>("")
        };
        this.SearchResults = ko.observableArray<Aci.Flex.Core.PersonInfo>([]);
    }

    public ResetSearch() {
        this.Search.Email("");
        this.Search.Firstname("");
        this.Search.FlexIdentifier("");
        this.Search.Id("");
        this.Search.Name("");
        this.Search.Lastname("");
        this.Search.Title("");
        this.SearchResults([]);
    }

    public GetUser(selectedId: string): Aci.Flex.Core.PersonInfo {
        return ko.utils.arrayFirst(this.SearchResults(), (u) => {
            return ko.unwrap(u.FlexIdentifier) == selectedId;
        });
    }
}