declare class ReportDefinitionsViewModel {
    reports: KnockoutObservableArray<Aci.Flex.DataModel.ReportDefinition>;
    servers: KnockoutObservableArray<Aci.Flex.DataModel.ReportServer>;
    createReportModel: KnockoutObservable<Aci.Flex.Portal.Model.ReportDefinitionModel>;
    addParameterModel: KnockoutObservable<Aci.Flex.DataModel.ReportParameter>;
    editReportModel: KnockoutObservable<Aci.Flex.Portal.Model.ReportDefinitionModel>;
    parameterTypes: KnockoutObservableArray<System.Collections.Generic.IKeyValuePair>;
    initialize(): Q.Promise<boolean>;
    loadTypes: () => void;
    deleteReport: (report: Aci.Flex.DataModel.ReportDefinition) => void;
    deleteParameter: (param: Aci.Flex.DataModel.ReportParameter) => void;
    showCreateReport: () => void;
    showEditReport: (reportDefinition: Aci.Flex.DataModel.ReportDefinition) => void;
    updateReport: (editReportModel: Aci.Flex.Portal.Model.ReportDefinitionModel) => void;
    showAddParameter: () => void;
    addParameter: (param: Aci.Flex.DataModel.ReportParameter) => void;
    createReport: () => void;
}
declare function BindReportDefinitionsViewModel(modelIdentifier: string, rootNode: any): void;
