declare class ProfileViewModel {
    user: KnockoutObservable<Aci.Flex.DataModel.User>;
    userIdentifier: KnockoutObservable<string>;
    messages: KnockoutObservableArray<Aci.Flex.DataModel.InboxNotification>;
    fullName: KnockoutComputed<string>;
    avatarUrl: KnockoutComputed<string>;
    composeMessageModel: KnockoutObservable<ComposeMessageViewModel>;
    viewMessageModel: KnockoutObservable<Aci.Flex.DataModel.InboxNotification>;
    selectedMessages: KnockoutObservableArray<string>;
    allChecked: KnockoutComputed<boolean>;
    constructor(userIdentifier: string);
    initialize(): Q.Promise<boolean>;
    loadMessages(): Q.Promise<boolean>;
    deleteMessage: (p1: Aci.Flex.DataModel.InboxNotification) => void;
    composeMessage: () => void;
    markSelectedAsRead: () => void;
    deleteSelected: () => void;
    viewMessage: (p1: Aci.Flex.DataModel.InboxNotification) => void;
    replyMessage: (p1: Aci.Flex.DataModel.InboxNotification) => void;
    messageHubProxy: MyHubConnection;
    registerSignalR(): void;
}
declare class ComposeMessageViewModel {
    successCallback: any;
    recipients: KnockoutObservableArray<string>;
    subject: KnockoutObservable<string>;
    content: KnockoutObservable<string>;
    constructor(successCallback: any);
    sendMessage: () => void;
    populateRecipient: (userId: string, userName: string) => void;
}
declare function BindProfileViewModel(userIdentifier: string, rootNode: any): void;
