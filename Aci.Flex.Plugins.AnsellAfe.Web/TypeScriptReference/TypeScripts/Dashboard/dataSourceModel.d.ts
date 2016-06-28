declare class DataSourceModel implements PluginModel {
    freeboardModel: any;
    pluginType: KnockoutObservable<string>;
    name: KnockoutObservable<string>;
    latestData: KnockoutObservable<{}>;
    settings: KnockoutObservableArray<SettingDefinition>;
    datasourcePlugins: {
        [id: string]: DataSourcePlugin;
    };
    datasourceInstance: DashboardDataSourceInstance;
    updateCallback(newData: any): void;
    constructor(theFreeboardModel: FreeboardModel, datasourcePlugins: {
        [id: string]: DataSourcePlugin;
    });
    disposeDatasourceInstance(): void;
    private updateCallbackInternal(newData);
    onTypeChanged(newValue: any): void;
    last_updated: KnockoutObservable<string>;
    last_error: KnockoutObservable<{}>;
    serialize(): {
        name: string;
        type: string;
        settings: SettingDefinition[];
    };
    deserialize(object: any): void;
    getDataRepresentation(dataPath: any): any;
    updateNow(): void;
    edit(): void;
    dispose(): void;
}
