declare class barchartWidget implements DashboardWidgetInstance {
    displayElement: JQuery;
    titleElement: JQuery;
    currentSettings: any;
    sparklineElement: JQuery;
    xChartElement: JQuery;
    currentDataSet: any;
    constructor(settings: any);
    render: (element: any) => void;
    onSizeChanged: () => void;
    getHeight: () => any;
    onCalculatedValueChanged: (settingName: string, newValue: any) => void;
    initBarChart(data: any, object: any): void;
    onSettingsChanged: (newSettings: any) => void;
    onDispose(): void;
}
