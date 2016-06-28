declare class jsonDatasource implements DashboardDataSourceInstance {
    constructor(settings: any, callback: any);
    updateCallback: any;
    updateTimer: any;
    currentSettings: any;
    errorStage: number;
    lockErrorStage: boolean;
    updateRefresh: (refreshTime: any) => void;
    updateNow: (force: any) => void;
    onDispose(): void;
    onSettingsChanged: (newSettings: any) => void;
}
