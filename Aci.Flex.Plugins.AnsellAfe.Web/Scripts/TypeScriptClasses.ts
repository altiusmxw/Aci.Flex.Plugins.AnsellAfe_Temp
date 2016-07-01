module Aci.Flex.Plugins.AnsellAfe.Server.DataModel {
    export class Afe {
        constructor() {
            this.AfeId = ko.observable<number>();
            this.ProjectName = ko.observable<string>();
            this.CreateDate = ko.observable<Date>();
            this.OriginalAfeId = ko.observable<number>();
            this.DivisionId = ko.observable<number>();
            this.FunctionId = ko.observable<number>();
            this.SiteId = ko.observable<number>();
            this.NatureId = ko.observable<number>();
            this.PurposeId = ko.observable<number>();
            this.CurrencyId = ko.observable<number>();
            this.ExpenditureType = ko.observable<string>();
            this.StageGateProjectId = ko.observable<string>();
            this.ReferenceNo = ko.observable<string>();
            this.Description = ko.observable<string>();
            this.Proposal = ko.observable<string>();
            this.ProjectBenefits = ko.observable<string>();
            this.ProjectRisks = ko.observable<string>();
            this.ControlMeasures = ko.observable<string>();
        }
        AfeId: KnockoutObservable<number>;
        ProjectName: KnockoutObservable<string>;
        CreateDate: KnockoutObservable<Date>;
        OriginalAfeId: KnockoutObservable<number>;
        DivisionId: KnockoutObservable<number>;
        FunctionId: KnockoutObservable<number>;
        SiteId: KnockoutObservable<number>;
        NatureId: KnockoutObservable<number>;
        PurposeId: KnockoutObservable<number>;
        CurrencyId: KnockoutObservable<number>;
        ExpenditureType: KnockoutObservable<string>;
        StageGateProjectId: KnockoutObservable<string>;
        ReferenceNo: KnockoutObservable<string>;
        Description: KnockoutObservable<string>;
        Proposal: KnockoutObservable<string>;
        ProjectBenefits: KnockoutObservable<string>;
        ProjectRisks: KnockoutObservable<string>;
        ControlMeasures: KnockoutObservable<string>;
    }

    export class Division {
        constructor() {
            this.DivisionId = ko.observable<number>();
            this.DivisionName = ko.observable<string>();
            this.DivisionCode = ko.observable<string>();
        }
        DivisionId: KnockoutObservable<number>;
        DivisionName: KnockoutObservable<string>;
        DivisionCode: KnockoutObservable<string>;
    }

    export class Function {
        constructor() {
            this.FunctionId = ko.observable<number>();
            this.FunctionName = ko.observable<string>();
        }
        FunctionId: KnockoutObservable<number>;
        FunctionName: KnockoutObservable<string>;
    }

    export class Site {
        constructor() {
            this.SiteId = ko.observable<number>();
            this.SiteName = ko.observable<string>();
            this.SiteCode = ko.observable<string>();
            this.Region = ko.observable<string>();
        }
        SiteId: KnockoutObservable<number>;
        SiteName: KnockoutObservable<string>;
        SiteCode: KnockoutObservable<string>;
        Region: KnockoutObservable<string>;
    }

    export class Nature {
        constructor() {
            this.NatureId = ko.observable<number>();
            this.NatureName = ko.observable<string>();
        }
        NatureId: KnockoutObservable<number>;
        NatureName: KnockoutObservable<string>;
    }

    export class Purpose {
        constructor() {
            this.PurposeId = ko.observable<number>();
            this.PurposeName = ko.observable<string>();
        }
        PurposeId: KnockoutObservable<number>;
        PurposeName: KnockoutObservable<string>;
    }

    export class Currency {
        constructor() {
            this.CurrencyId = ko.observable<number>();
            this.CurrencyName = ko.observable<string>();
            this.CurrencyCode = ko.observable<string>();
        }
        CurrencyId: KnockoutObservable<number>;
        CurrencyName: KnockoutObservable<string>;
        CurrencyCode: KnockoutObservable<string>;
    }

    export class Authorization {
        constructor() {
            this.AuthorizationId = ko.observable<number>();
            this.AuthorizationCategoryId = ko.observable<number>();
            this.UserIdentifier = ko.observable<string>();
            this.ManagerIdentifer = ko.observable<string>();
            this.Authority = ko.observable<number>();
            this.UserTitle = ko.observable<string>();
        }
        AuthorizationId: KnockoutObservable<number>;
        AuthorizationCategoryId: KnockoutObservable<number>;
        UserIdentifier: KnockoutObservable<string>;
        ManagerIdentifer: KnockoutObservable<string>;
        Authority: KnockoutObservable<number>;
        UserTitle: KnockoutObservable<string>;
    }
}

module Aci.Flex.Plugins.AnsellAfe.Server.Objects {
    export class FinancialData {
        constructor() {
            this.AccountId = ko.observable<number>();
            this.Value = ko.observable<number>();
        }
        AccountId: KnockoutObservable<number>;
        Value: KnockoutObservable<number>;
    }

    export class AfeSubmitData {
        constructor() {
            this.Afe = ko.observable(new Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Afe());
            this.Financials = ko.observableArray<FinancialData>([]);
            this.Approvers = ko.observableArray<Aci.Flex.Core.PersonInfo>([]);
            this.AdditionalApprovers = ko.observableArray<Aci.Flex.Core.PersonInfo>([]);
        }
        Afe: KnockoutObservable<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Afe>;
        Financials: KnockoutObservableArray<FinancialData>;
        Approvers: KnockoutObservableArray<Aci.Flex.Core.PersonInfo>;
        AdditionalApprovers: KnockoutObservableArray<Aci.Flex.Core.PersonInfo>;
    }

    export class SaveAfeReturnDetails {
        constructor() {
            this.AfeId = ko.observable<number>();
            this.Success = ko.observable<boolean>();
        }
        AfeId: KnockoutObservable<number>;
        Success: KnockoutObservable<boolean>;
    }

    export class ApprovalAfeDetails {
        constructor() {
        }

        AfeId: KnockoutObservable<number>;
        CreateDate: KnockoutObservable<Date>;
        ProjectName: KnockoutObservable<string>;
        DivisionName: KnockoutObservable<string>;
        FunctionName: KnockoutObservable<string>;
        SiteName: KnockoutObservable<string>;
        AfeType: KnockoutObservable<string>;
        StageGateProjectId: KnockoutObservable<string>;
        ReferenceNo: KnockoutObservable<string>;
        ExpenditureType: KnockoutObservable<string>;
        ExchangeRate: KnockoutObservable<number>;
        CurrencyCode: KnockoutObservable<string>;

        Amount: KnockoutObservable<number>;
        Budget: KnockoutObservable<number>;
        PreviousAfes: KnockoutObservable<number>;
        RemainingBudget: KnockoutObservable<number>;
        CashBackBefore: KnockoutObservable<number>;
        CashBackAfter: KnockoutObservable<number>;
        ReturnOnAssets: KnockoutObservable<number>;
        NPV: KnockoutObservable<number>;
        IRR: KnockoutObservable<number>;
        NetWriteOff: KnockoutObservable<number>;
    }
}