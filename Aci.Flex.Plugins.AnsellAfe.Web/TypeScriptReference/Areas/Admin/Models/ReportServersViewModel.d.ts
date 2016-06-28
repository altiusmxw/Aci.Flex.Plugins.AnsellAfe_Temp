declare class ReportServersViewModel {
    reportServers: KnockoutObservableArray<Aci.Flex.DataModel.ReportServer>;
    plugins: KnockoutObservableArray<System.Collections.Generic.KeyValuePair>;
    newReportServer: KnockoutObservable<Aci.Flex.DataModel.ReportServer>;
    initialize(): Q.Promise<boolean>;
    deleteReportServer: (reportServer: Aci.Flex.DataModel.ReportServer) => void;
    showCreateReportServer: () => void;
    createReportServer: () => void;
}
declare function BindReportServersViewModel(modelIdentifier: string, rootNode: any): void;
