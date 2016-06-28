interface TreeNodeState {
    opened: boolean;
    disabled: boolean;
    selected: boolean;
}
interface TreeNode {
    id: string;
    parent: string;
    text: string;
    state: TreeNodeState;
    li_attr: any;
}
interface OnMembersSelected {
    (hierarchyIdentifier: string, members: Array<string>): void;
}
declare enum memberSelectionMethod {
    All = 0,
    Leaf = 1,
    VirtualLeaf = 2,
}
declare class HierarchyMemberSelectorViewModel {
    dimensionIdentifier: string;
    hierarchyIdentifier: string;
    members: {
        [hierarchyIdentifier: string]: Array<Aci.Flex.DataModel.EntityHierarchyStatic>;
    };
    membersSelected: OnMembersSelected;
    selectionMode: memberSelectionMethod;
    selectedMembers: {
        [hierarchyIdentifier: string]: Array<string>;
    };
    treeData: KnockoutObservable<string>;
    constructor();
    private bindSubscribers();
    static getNodes(members: Array<Aci.Flex.DataModel.EntityHierarchyStatic>, selectedMembers: Array<string>): Array<TreeNode>;
    onMembersSelected(hierarchyIdentifier: string, members: Array<string>): void;
    bindTree(hierarchyIdentifier: string, elementId: string, mode?: memberSelectionMethod, selectedMembers?: Array<string>): void;
    getLeafMemberIds(selectedMembers: any[]): string[];
    getVirtualLeafMemberIds(selectedMembers: any[]): string[];
    getAllMemberIds(selectedMembers: any[]): string[];
    selectMembers: (hierarchyIdentifier: string, elementId: string) => any[];
}
