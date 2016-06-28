declare class ImportModelViewModel {
    modelImported: KnockoutObservable<boolean>;
    baseUrl: string;
    selectedStepIndex: KnockoutObservable<number>;
    previousStepIndex: KnockoutObservable<number>;
    serverName: KnockoutObservable<string>;
    databases: KnockoutObservableArray<any>;
    dimensions: KnockoutObservableArray<any>;
    cubes: KnockoutObservableArray<any>;
    databaseId: KnockoutObservable<string>;
    cubeId: KnockoutObservable<string>;
    modelIdentifier: string;
    wizardNextSelector: string;
    constructor(baseUrl: string);
    onTabShow: (activeTab: any, navigation: any, currentIndex: number) => boolean;
    ToggleDatabasesAvailable: (b: boolean) => void;
    ToggleCubesAvailable(b: boolean): void;
    ToggleDimensionsAvailable(b: boolean): void;
    GetOlapDatabases(): void;
    GetOlapCubes(): void;
    GetOlapDimensions(): void;
    ImportModel(): void;
}
declare function BindViewModel(modelIdentifier: string): void;
