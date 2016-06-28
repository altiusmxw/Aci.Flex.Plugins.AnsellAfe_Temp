declare class ReportsViewModel {
    reports: KnockoutObservableArray<Aci.Flex.DataModel.ReportDefinition>;
    selectedReport: KnockoutObservable<Aci.Flex.DataModel.ReportDefinition>;
    iframeUri: KnockoutObservable<string>;
    initialize(): Q.Promise<boolean>;
    renderReport: (reportDefinition: Aci.Flex.DataModel.ReportDefinition) => void;
}
declare function BindReportsViewModel(modelIdentifier: string, rootNode: any): void;
