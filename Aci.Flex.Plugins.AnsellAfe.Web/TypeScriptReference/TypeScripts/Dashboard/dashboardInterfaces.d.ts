interface DashboardWidgetInstance {
    render(settings: any);
    onCalculatedValueChanged(settingName: string, newValue: any)
    onSettingsChanged(settings: any);
    onSizeChanged();
    getHeight(): number;
    onDispose();
}

interface DashboardDataSourceInstance {
    onSettingsChanged(newValue);
    onDispose();
    updateNow(force: boolean);

}

interface PluginModel {
    pluginType: KnockoutObservable<string>;
    settings: KnockoutObservableArray<SettingDefinition>;
}

interface PluginEditorOptions {
    operation: string;
    type: string;
}