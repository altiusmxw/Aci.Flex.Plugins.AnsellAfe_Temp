declare class PaneModel implements PluginModel {
    pluginType: KnockoutObservable<string>;
    settings: KnockoutObservableArray<SettingDefinition>;
    constructor(theFreeboardModel: any, widgetPlugins: any);
    title: KnockoutObservable<{}>;
    width: KnockoutObservable<number>;
    row: {};
    col: {};
    freeboardModel: any;
    widgetPlugins: any;
    col_width: KnockoutObservable<number>;
    widgets: KnockoutObservableArray<WidgetModel>;
    addWidget(widget: any): void;
    widgetCanMoveUp: (widget: any) => boolean;
    widgetCanMoveDown: (widget: any) => boolean;
    moveWidgetUp: (widget: any) => void;
    moveWidgetDown: (widget: any) => void;
    processSizeChange(): void;
    getCalculatedHeight(): number;
    serialize(): {
        title: {};
        width: number;
        row: {};
        col: {};
        col_width: number;
        widgets: any[];
    };
    deserialize(object: any): void;
    dispose: () => void;
}
