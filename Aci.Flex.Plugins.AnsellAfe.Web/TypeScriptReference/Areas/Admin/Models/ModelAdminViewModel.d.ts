declare class ModelAdminViewModel {
    models: KnockoutObservableArray<Aci.Flex.DataModel.Model>;
    modelTypes: KnockoutObservableArray<Aci.Flex.Core.Primitives.FlexObjectIdentifier>;
    newModelName: KnockoutObservable<string>;
    newModelType: KnockoutObservable<Aci.Flex.Core.Primitives.FlexObjectIdentifier>;
    importViewModel: KnockoutObservable<ImportModelViewModel>;
    displayCreateModel: KnockoutObservable<boolean>;
    initialize(): Q.Promise<any>;
    showAddModel: () => void;
    deleteModel: () => void;
    importModel: (model: Aci.Flex.DataModel.Model) => void;
    rebuildModel: (model: Aci.Flex.DataModel.Model) => void;
    createModel: () => void;
}
declare function BindModelAdminViewModel(modelIdentifier: string, rootNode: any): void;
