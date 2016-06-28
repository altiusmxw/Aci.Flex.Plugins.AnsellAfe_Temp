var byPassWarning: boolean = false;
var showLoader;

$().ready(function () {
    window.onbeforeunload = () => {
        if (!byPassWarning) {
            return "Are you sure you want to leave this page? Any unsaved changes will be lost."
        }
    };
});

module AfeCaptureFormHelper {
    var viewModel: AfeCaptureViewModel;

    export function InitializeViewModel(isSupplement: boolean, afeCreateType: Aci.Flex.Plugins.AnsellAfe.Web.Models.AfeCreateType, origAfeId: number, creatorName: string) {
        showLoader = setTimeout(function () {
            if (!$.url('isdebug'))
                initializeFlexUpdateProgress($("#afe-capture-progress"));
            $("#afe-capture-progress").show();
        }, 300);

        var afeType: Aci.Flex.Plugins.AnsellAfe.Server.AfeTypeType = isSupplement ? Aci.Flex.Plugins.AnsellAfe.Server.AfeTypeType.Supplement : Aci.Flex.Plugins.AnsellAfe.Server.AfeTypeType.Original;
        viewModel = new AfeCaptureViewModel(afeType, origAfeId, creatorName);

        viewModel.InitializeFormDataOptions().then(() => {

            CommonAfeHelper.bindHandlers();
            ko.applyBindings(viewModel, $("#afe-capture-container")[0]);
            $("select.selectpicker").selectpicker();

            clearTimeout(showLoader);
            $("#afe-capture-progress").hide();
        });

        //UserSearcher.Initialize("Find AFE Owner", viewModel.AfeOwner);
    }

    export function SaveAfe() {
        var submitData: Aci.Flex.Plugins.AnsellAfe.Server.Objects.AfeSubmitData;

        submitData = new Aci.Flex.Plugins.AnsellAfe.Server.Objects.AfeSubmitData();
        submitData.Afe = ko.observable<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Afe>(viewModel);

        var fact1: Aci.Flex.Plugins.AnsellAfe.Server.Objects.FinancialData = {
            AccountId: ko.observable<number>(1),
            Value: ko.observable<number>(viewModel.Amount_LC().Value())
        };
        var fact2: Aci.Flex.Plugins.AnsellAfe.Server.Objects.FinancialData = {
            AccountId: ko.observable<number>(2),
            Value: ko.observable<number>(viewModel.Budget_LC().Value())
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
            AccountId: ko.observable<number>(8),
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
        
    }

    export function SaveDraftAfe() {
    }
}


class AfeCaptureViewModel extends Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Afe {

    CreatorName: string;
    ExchangeRate: KnockoutObservable<number>;
    Amount_LC: KnockoutObservable<MoneyView>;
    Amount_USD: KnockoutComputed<number> = ko.pureComputed<number>(() => {
        var self = this;
        var lc = self.Amount_LC().Value();
        return lc * self.ExchangeRate();
    }, this);
    Budget_LC: KnockoutObservable<MoneyView>;
    Budget_USD: KnockoutComputed<number> = ko.pureComputed<number>(() => {
        var self = this;
        var lc = self.Budget_LC().Value();
        return lc * self.ExchangeRate();
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

    ExpenditureTypeOptions: Array<SelectListOption> = [];
    DivisionOptions: Array<SelectListOption> = [];
    FunctionOptions: Array<SelectListOption> = [];
    SiteOptions: Array<SelectListOption> = [];
    NatureOptions: Array<SelectListOption> = [];
    PurposeOptions: Array<SelectListOption> = [];
    CurrencyOptions: Array<SelectListOption> = [];
    ExchangeRates: Array<System.Tuple<number, number>> = [];

    constructor(afeType: Aci.Flex.Plugins.AnsellAfe.Server.AfeTypeType, origAfeId: number, creatorName: string) {
        super();
        var self = this;

        this.CreatorName = creatorName;
        this.CreateDate(new Date());
        this.Amount_LC = ko.observable<MoneyView>(new MoneyView(0));
        this.Budget_LC = ko.observable<MoneyView>(new MoneyView(0));
        this.WriteOff_LC = ko.observable<MoneyView>(new MoneyView(0));
        this.NPV = ko.observable<MoneyView>(new MoneyView(0));
        this.CashPayback_Before = ko.observable<number>();
        this.CashPayback_After = ko.observable<number>();
        this.AvgReturn = ko.observable<number>();
        this.IRR = ko.observable<number>();
        this.ExchangeRate = ko.observable<number>();

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
        });

        this.FunctionId.subscribe((id) => {
            this.SetBudget(this.DivisionId(), id, this.SiteId());
        });

        this.SiteId.subscribe((id) => {
            this.SetBudget(this.DivisionId(), this.FunctionId(), id);
        });

        if (afeType == Aci.Flex.Plugins.AnsellAfe.Server.AfeTypeType.Supplement)
            this.OriginalAfeId(origAfeId);
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

    private SetBudget(divId: number, funcId: number, siteId: number) {
        var budget = this.Budget_LC();

        if (ko.unwrap(this.FunctionId) && ko.unwrap(this.DivisionId) && ko.unwrap(this.SiteId())) {
            Flex.ApiClient.CommonAfeApi.GetBudget(divId, funcId, siteId, 2016).then((b) => {
                budget.Text(ko.toJS(b).toString());
            });
        }
        else {
            budget.Text("");
        }
    }
}