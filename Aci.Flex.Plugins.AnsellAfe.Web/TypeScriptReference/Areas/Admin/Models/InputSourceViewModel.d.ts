declare class InputSourceViewModel {
    inputSources: KnockoutObservableArray<Aci.Flex.DataModel.InputSource>;
    workflows: KnockoutObservableArray<Aci.Flex.DataModel.ModelWorkflow>;
    dimensions: KnockoutObservableArray<Aci.Flex.DataModel.Dimension>;
    hierarchies: KnockoutObservableArray<Aci.Flex.DataModel.Hierarchy>;
    attributes: KnockoutObservableArray<Aci.Flex.DataModel.HierarchyAttribute>;
    newInputSource: KnockoutObservable<Aci.Flex.DataModel.InputSource>;
    editInputSource: KnockoutObservable<EditInputSourceViewModel>;
    load(modelIdentifier: string): Q.Promise<boolean>;
    loadInputSources(): Q.Promise<boolean>;
    loadWorkflows(): Q.Promise<boolean>;
    loadAttributes(dimensionIdentifier: string): Q.Promise<boolean>;
    loadDimensions: () => Q.Promise<boolean>;
    loadHierarchies: (dimensionIdentifier: string) => Q.Promise<boolean>;
    showAddInputSource(): void;
    showEditInputSource: (inputSource: Aci.Flex.DataModel.InputSource) => void;
    createInputSource: (inputSource: Aci.Flex.DataModel.InputSource) => void;
    saveInputSource: (inputSourceVm: EditInputSourceViewModel) => void;
}
declare class NumberStringTuple extends System.Tuple<number, String> {
    constructor(item1: number, item2: string);
}
declare class EditInputSourceViewModel {
    inputSource: KnockoutComputed<Aci.Flex.DataModel.InputSource>;
    workflowKeyDimensions: KnockoutComputed<Aci.Flex.DataModel.Dimension[]>;
    selectedDimensionHierarchies: KnockoutComputed<Aci.Flex.DataModel.Hierarchy[]>;
    constructor();
    updateStorageItem: (storageItem: Aci.Flex.DataModel.StorageItem) => void;
    inputSourceWorkflowKeys: KnockoutObservableArray<Aci.Flex.DataModel.InputSourceWorkflowKey>;
    inputSourceWorkflowAttributes: KnockoutObservableArray<Aci.Flex.DataModel.InputSourceWorkflowAttribute>;
    inputSourceWorkflowFilters: KnockoutObservableArray<Aci.Flex.DataModel.InputSourceWorkflowFilter>;
    inputSourceViewModel: InputSourceViewModel;
    inputs: KnockoutObservableArray<Aci.Flex.DataModel.Input>;
    editingInput: KnockoutObservable<Aci.Flex.DataModel.Input>;
    editingAttribute: KnockoutObservable<Aci.Flex.DataModel.InputSourceWorkflowAttribute>;
    editingFilter: KnockoutObservable<Aci.Flex.DataModel.InputSourceWorkflowFilter>;
    selectedDimensionId: KnockoutObservable<string>;
    inputSourceStorageItem: KnockoutObservable<Aci.Flex.DataModel.StorageItem>;
    inputEditMode: KnockoutComputed<boolean>;
    load(inputSourceViewModel: InputSourceViewModel, inputSourceIdentifier: string): Q.Promise<boolean>;
    keyBehaviors: KnockoutComputed<NumberStringTuple[]>;
    attributeTypes: KnockoutComputed<NumberStringTuple[]>;
    dimensionAttributes: (dimensionIdentifier: KnockoutObservable<string>) => KnockoutComputed<Aci.Flex.DataModel.HierarchyAttribute[]>;
    dimensionHierarchies: (dimensionIdentifier: KnockoutObservable<string>) => KnockoutComputed<Aci.Flex.DataModel.Hierarchy[]>;
    getHierarchyName: (workflowFilter: Aci.Flex.DataModel.InputSourceWorkflowFilter) => KnockoutObservable<string>;
    getAttributeType: (workflowAttribute: Aci.Flex.DataModel.InputSourceWorkflowAttribute) => string;
    getWorkflowKey: (dimensionIdentifier: string) => Aci.Flex.DataModel.InputSourceWorkflowKey;
    workflowKeyHierarchy: (dimensionIdentifier: KnockoutObservable<string>) => KnockoutComputed<string>;
    workflowKeyBehavior: (dimensionIdentifier: KnockoutObservable<string>) => KnockoutComputed<number>;
    loadStorageItem: (storageItemId: string) => Q.Promise<boolean>;
    loadInputs: () => Q.Promise<boolean>;
    loadWorkflowKeys: () => Q.Promise<boolean>;
    loadWorkflowAttributes: () => Q.Promise<boolean>;
    loadWorkflowFilters: () => Q.Promise<boolean>;
    editInput: (input: Aci.Flex.DataModel.Input) => void;
    deleteInput: (input: Aci.Flex.DataModel.Input) => void;
    deleteWorkflowAttribute: (sender: Aci.Flex.DataModel.InputSourceWorkflowAttribute) => void;
    deleteWorkflowFilter: (sender: Aci.Flex.DataModel.InputSourceWorkflowFilter) => void;
    showCreateInput: () => void;
    showAddAttribute: () => void;
    showAddFilter: () => void;
    addParameter: (attribute: Aci.Flex.DataModel.InputSourceWorkflowAttribute) => void;
    addFilter: (filter: Aci.Flex.DataModel.InputSourceWorkflowFilter) => void;
    saveInput: (input: Aci.Flex.DataModel.Input) => void;
}
declare function BindInputSourceViewModel(modelIdentifier: string): void;
