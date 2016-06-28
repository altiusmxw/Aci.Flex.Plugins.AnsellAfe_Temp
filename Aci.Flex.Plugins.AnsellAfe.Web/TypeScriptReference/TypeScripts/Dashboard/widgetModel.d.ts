declare class WidgetModel implements PluginModel {
    datasourceRefreshNotifications: {};
    calculatedSettingScripts: {};
    widgetInstance: DashboardWidgetInstance;
    title: KnockoutObservable<{}>;
    fillSize: KnockoutObservable<boolean>;
    height: KnockoutComputed<number>;
    pluginType: KnockoutObservable<string>;
    settings: KnockoutObservableArray<SettingDefinition>;
    freeboardModel: any;
    widgetPlugins: {
        [id: string]: WidgetPlugin;
    };
    _heightUpdate: KnockoutObservable<{}>;
    shouldRender: KnockoutObservable<boolean>;
    constructor(theFreeboardModel: FreeboardModel, widgetPlugins: {
        [id: string]: WidgetPlugin;
    });
    onTypeChanged(newValue: any): void;
    onSettingsChanged(newValue: any): void;
    processDatasourceUpdate(datasourceName: any): void;
    callValueFunction(theFunction: any): any;
    processSizeChange(): void;
    processCalculatedSetting(settingName: any): void;
    updateCalculatedSettings(): void;
    render(element: any): void;
    dispose(): void;
    serialize(): {
        title: {};
        type: string;
        settings: SettingDefinition[];
    };
    deserialize(object: any): void;
    disposeWidgetInstance(): void;
}
