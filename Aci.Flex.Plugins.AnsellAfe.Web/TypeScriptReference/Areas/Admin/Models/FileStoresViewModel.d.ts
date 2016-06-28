declare class FileStoresViewModel {
    content: KnockoutObservable<Aci.Flex.DataModel.Content>;
    contentTypes: KnockoutObservableArray<System.Collections.Generic.KeyValuePair>;
    contentLocations: KnockoutObservableArray<Aci.Flex.DataModel.ContentLocation>;
    selectedContentType: KnockoutObservable<number>;
    selectedContentLocation: KnockoutObservable<number>;
    initialize(): Q.Promise<any>;
    updateContent: () => void;
}
declare function BindFileStoresViewModel(modelIdentifier: string, rootNode: any): void;
