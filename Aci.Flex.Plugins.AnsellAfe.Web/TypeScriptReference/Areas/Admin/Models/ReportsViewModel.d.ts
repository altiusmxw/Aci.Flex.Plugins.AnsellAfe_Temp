declare class ReportsViewModel {
    reports: KnockoutObservableArray<Aci.Flex.DataModel.ReportDefinition>;
    servers: KnockoutObservableArray<Aci.Flex.DataModel.ReportServer>;
    createReportModel: KnockoutObservable<Aci.Flex.Portal.Model.ReportDefinitionModel>;
    initialize(): Q.Promise<boolean>;
    deleteReport: (report: Aci.Flex.DataModel.ReportDefinition) => void;
    showCreateReport: () => void;
    createReport: () => void;
}
declare function BindReportsViewModel(modelIdentifier: string, rootNode: any): void;
