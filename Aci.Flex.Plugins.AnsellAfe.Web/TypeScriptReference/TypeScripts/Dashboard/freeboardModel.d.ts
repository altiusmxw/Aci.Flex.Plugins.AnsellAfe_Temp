declare class FreeboardModel {
    constructor(datasourcePlugins: {
        [id: string]: DataSourcePlugin;
    }, widgetPlugins: {
        [id: string]: WidgetPlugin;
    }, freeboardUI: FreeboardUI);
    freeboardUI: FreeboardUI;
    SERIALIZATION_VERSION: number;
    version: number;
    isEditing: KnockoutObservable<boolean>;
    allow_edit: KnockoutObservable<boolean>;
    datasourcePlugins: {
        [id: string]: DataSourcePlugin;
    };
    widgetPlugins: {
        [id: string]: WidgetPlugin;
    };
    header_image: KnockoutObservable<{}>;
    plugins: KnockoutObservableArray<{}>;
    datasources: KnockoutObservableArray<DataSourceModel>;
    panes: KnockoutObservableArray<PaneModel>;
    datasourceData: {};
    addHandlers(): void;
    processDatasourceUpdate(datasourceModel: any, newData: any): void;
    _datasourceTypes: KnockoutObservable<{}>;
    datasourceTypes: KnockoutComputed<FreeboardPlugin[]>;
    _widgetTypes: KnockoutObservable<{}>;
    widgetTypes: KnockoutComputed<FreeboardPlugin[]>;
    addPluginSource(pluginSource: any): void;
    serialize(): {
        version: number;
        header_image: {};
        allow_edit: boolean;
        plugins: {}[];
        panes: any[];
        datasources: any[];
        columns: number;
    };
    deserialize(object: any, finishedCallback: any): void;
    clearDashboard(): void;
    loadDashboard(dashboardData: any, callback?: any): void;
    loadUserDashboard(): void;
    saveDashboard(): void;
    addDatasource(datasource: any): void;
    deleteDatasource(datasource: any): void;
    createPane: () => void;
    addGridColumnLeft(): void;
    addGridColumnRight(): void;
    subGridColumnLeft(): void;
    subGridColumnRight(): void;
    addPane(pane: any): void;
    deletePane(pane: any): void;
    deleteWidget(widget: any): void;
    private setEditing(editing, animate);
}
