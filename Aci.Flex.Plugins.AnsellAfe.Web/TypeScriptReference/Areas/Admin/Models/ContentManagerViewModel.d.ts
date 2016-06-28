declare class ContentManagerViewModel {
    content: KnockoutObservable<Aci.Flex.DataModel.Content>;
    contentTypes: KnockoutObservableArray<System.Collections.Generic.KeyValuePair>;
    contentLocations: KnockoutObservableArray<Aci.Flex.DataModel.ContentLocation>;
    selectedContentType: KnockoutObservable<number>;
    selectedContentLocation: KnockoutObservable<number>;
    initialize(): Q.Promise<any>;
    updateContent: () => void;
}
declare function BindContentManagerViewModel(modelIdentifier: string, rootNode: any): void;
