declare class EventsViewModel {
    events: KnockoutObservableArray<Aci.Flex.DataModel.Event>;
    initialize(): Q.Promise<boolean>;
    editEvent: (ev: Aci.Flex.DataModel.Event) => void;
}
declare function BindEventsViewModel(modelIdentifier: string, rootNode: any): void;
