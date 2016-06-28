declare class Attachments {
    workflowAttachments: KnockoutObservableArray<Aci.Flex.DataModel.StorageItem>;
    workflowInstanceId: KnockoutObservable<string>;
    isReadonly: KnockoutObservable<boolean>;
    constructor(containerId: string, isReadonly: boolean);
    loadWorkflowAttachments(workflowId: string): Q.Promise<boolean>;
    getDownloadLink(storageItem: Aci.Flex.DataModel.StorageItem): string;
    bindFileUpload(workflowIdentifier: string): void;
    deleteAttachment(storageItem: Aci.Flex.DataModel.StorageItem): void;
    rebind(): Q.Promise<boolean>;
}
