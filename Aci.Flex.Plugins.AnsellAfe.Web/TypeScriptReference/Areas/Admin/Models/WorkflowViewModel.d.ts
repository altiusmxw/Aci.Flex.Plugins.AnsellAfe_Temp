declare class ModelWorkflowsModel {
    modelIdentifier: string;
    modelWorkflows: KnockoutObservableArray<Aci.Flex.DataModel.ModelWorkflow>;
    workflows: KnockoutObservableArray<Aci.Flex.Core.Primitives.FlexObjectIdentifier>;
    selectedWorkflow: KnockoutObservable<Aci.Flex.Core.Primitives.FlexObjectIdentifier>;
    editingWorkflowModel: KnockoutObservable<EditModelWorkflowModel>;
    addingWorkflowModel: KnockoutObservable<boolean>;
    newWorkflowName: KnockoutObservable<string>;
    autoMapRoles: KnockoutObservable<boolean>;
    worflowGrid: {
        data: KnockoutObservableArray<Aci.Flex.DataModel.ModelWorkflow>;
        columnDefs: {
            field: string;
            displayName: string;
        }[];
        displaySelectionCheckbox: boolean;
        canSelectRows: boolean;
        enablePaging: boolean;
    };
    constructor();
    showAddWorkflow: () => void;
    load(modelIdentifier: string): Q.Promise<boolean>;
    loadWorkflows(): Q.Promise<boolean>;
    loadModelWorkflows(): Q.Promise<boolean>;
    createWorkflow: () => void;
    editWorkflowRoles: (modelWorkflow: Aci.Flex.DataModel.ModelWorkflow) => void;
    updateModelWorkflow: (modelWorkflow: Aci.Flex.DataModel.ModelWorkflow, roleMaps: Aci.Flex.DataModel.WorkflowRoleMap[]) => void;
}
declare class EditModelWorkflowModel {
    constructor(modelWorkflow: Aci.Flex.DataModel.ModelWorkflow);
    private onClosed;
    Closed: ILiteEvent<boolean>;
    Save: () => void;
    modelWorkflow: KnockoutObservable<Aci.Flex.DataModel.ModelWorkflow>;
    workflowRoles: KnockoutObservableArray<System.Collections.Generic.KeyValuePair>;
    modelRoles: KnockoutObservableArray<Aci.Flex.DataModel.ModelRole>;
    roleMaps: KnockoutObservableArray<Aci.Flex.DataModel.WorkflowRoleMap>;
    selectedWorkflowRoleId: KnockoutObservable<number>;
    selectWorkflowRole: (workflowRole: System.Collections.Generic.KeyValuePair) => boolean;
    isMapped: (modelRoleIdentifier: string) => KnockoutComputed<boolean>;
    loadWorkflowRoles: () => Q.Promise<boolean>;
    loadModelRoles: () => Q.Promise<boolean>;
    loadRoleMap: () => Q.Promise<boolean>;
}
declare function BindWorkflowViewModel(modelIdentifier: string, rootNode: any): void;
