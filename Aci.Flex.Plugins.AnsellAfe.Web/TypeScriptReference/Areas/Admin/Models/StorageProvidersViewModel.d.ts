declare class StorageProvidersViewModel {
    storageProviders: KnockoutObservableArray<Aci.Flex.DataModel.StorageProvider>;
    editingStorageProvider: KnockoutObservable<Aci.Flex.DataModel.StorageProvider>;
    storageProviderParameters: KnockoutObservableArray<Aci.Flex.Core.ParameterDescriptor>;
    initialize(): Q.Promise<any>;
    editStorageProvider: (storageProvider: Aci.Flex.DataModel.StorageProvider) => void;
    update: (storageProvider: Aci.Flex.DataModel.StorageProvider) => void;
    cancelUpdate: (storageProvider: Aci.Flex.DataModel.StorageProvider) => void;
    getParameterTemplate(x: Aci.Flex.Core.ParameterDescriptor, y: any): string;
}
declare function BindStorageProvidersViewModel(modelIdentifier: string, rootNode: any): void;
