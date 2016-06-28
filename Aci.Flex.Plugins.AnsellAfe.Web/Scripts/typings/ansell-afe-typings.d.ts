interface KnockoutBindingHandlers {
    totalWi: KnockoutBindingHandler;
    cost: KnockoutBindingHandler;
    totalCost: KnockoutBindingHandler;
    requiredDate: KnockoutBindingHandler;
    wi: KnockoutBindingHandler;
    allowBindings: KnockoutBindingHandler;
    enable_bs: KnockoutBindingHandler;
    wysiwyg: KnockoutBindingHandler;
}

//interface KnockoutBindingHandler {
//    defaults: any;
//}

declare class WorkflowStatusViewModel {
    static getInstance(): WorkflowStatusViewModel;
    loadWorkflowStatus(workflowId?: string): void;
}