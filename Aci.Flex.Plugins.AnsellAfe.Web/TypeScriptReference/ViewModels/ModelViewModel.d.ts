declare class ModelViewModel {
    modelIdentifier: string;
    constructor();
    load(modelIdentifier: string): Q.Promise<boolean>;
    modelWorkflowsModel: KnockoutObservable<ModelWorkflowsModel>;
}
declare class ModelDimensionsModel {
    modelIdentifier: string;
    constructor(modelIdentifier: string);
    dimensions: KnockoutObservableArray<Aci.Flex.DataModel.Dimension>;
    editingDimensionId: KnockoutObservable<string>;
    editingDimension: KnockoutComputed<Aci.Flex.DataModel.Dimension>;
    initialize(): Q.Promise<boolean>;
    fetchDimensions(): Q.Promise<boolean>;
    editDimension: (dimension: Aci.Flex.DataModel.Dimension) => void;
    cancelUpdate: () => void;
    updateDimension: (dimension: Aci.Flex.DataModel.Dimension) => void;
}
declare function BindModelViewModel(modelIdentifier: string, rootNode: any): void;
