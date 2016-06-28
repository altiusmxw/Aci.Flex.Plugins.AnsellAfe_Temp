declare class Freeboard implements FreeboardStatic {
    theFreeboardModel: FreeboardModel;
    freeboardUI: FreeboardUI;
    datasourcePlugins: {
        [id: string]: DataSourcePlugin;
    };
    widgetPlugins: {
        [id: string]: WidgetPlugin;
    };
    jsEditor: JSEditor;
    valueEditor: ValueEditor;
    pluginEditor: PluginEditor;
    developerConsole: DeveloperConsole;
    currentStyle: {
        values: {};
    };
    constructor();
    addHandlers(): void;
    getParameterByName(name: any): string;
    initialize: (allowEdit: any, finishedCallback: any) => void;
    newDashboard: () => void;
    loadUserDashboard: () => void;
    loadDashboard: (configuration: any, callback: any) => void;
    serialize: () => {
        version: number;
        header_image: {};
        allow_edit: boolean;
        plugins: {}[];
        panes: any[];
        datasources: any[];
        columns: number;
    };
    setEditing: (editing: any, animate: any) => void;
    isEditing: () => KnockoutObservable<boolean>;
    loadDatasourcePlugin: (plugin: any) => void;
    resize: () => void;
    loadWidgetPlugin: (plugin: any) => void;
    setAssetRoot: (assetRoot: any) => void;
    addStyle: (selector: any, rules: any) => void;
    showLoadingIndicator: (show: any) => void;
    showDialog: (contentElement: any, title: any, okTitle: any, cancelTitle: any, okCallback: any) => void;
    getDatasourceSettings: (datasourceName: any) => SettingDefinition[];
    setDatasourceSettings: (datasourceName: any, settings: any) => void;
    getStyleString: (name: any) => string;
    getStyleObject: (name: any) => any;
    showDeveloperConsole: () => void;
}
declare var freeboard: FreeboardStatic;
