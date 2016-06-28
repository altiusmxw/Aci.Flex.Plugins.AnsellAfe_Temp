declare class DimensionsViewModel {
    dimensions: KnockoutObservableArray<Aci.Flex.DataModel.Dimension>;
    editingDimension: KnockoutObservable<EditDimensionViewModel>;
    initialize(): Q.Promise<boolean>;
    editDimension: (ev: Aci.Flex.DataModel.Dimension) => void;
    update: () => void;
    cancelUpdate: () => void;
}
declare class EditDimensionViewModel {
    hierarchies: KnockoutObservableArray<Aci.Flex.DataModel.Hierarchy>;
    dimension: KnockoutObservable<Aci.Flex.DataModel.Dimension>;
    editingHierarchy: KnockoutObservable<Aci.Flex.DataModel.Hierarchy>;
    editHierarchy: (ev: Aci.Flex.DataModel.Hierarchy) => void;
    update: () => void;
    cancelUpdate: () => void;
}
declare function BindDimensionsViewModel(modelIdentifier: string, rootNode: any): void;
