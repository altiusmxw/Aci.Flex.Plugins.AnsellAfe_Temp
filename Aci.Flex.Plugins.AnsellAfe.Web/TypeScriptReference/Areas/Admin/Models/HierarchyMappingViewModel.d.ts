declare class HierarchyMappingViewModel {
    hierarchyRelations: KnockoutObservableArray<Aci.Flex.DataModel.HierarchyRelation>;
    selectedHierarchyRelation: KnockoutObservable<Aci.Flex.DataModel.HierarchyRelation>;
    firstHierarchyMembers: KnockoutObservableArray<Aci.Flex.DataModel.EntityHierarchyStatic>;
    secondHierarchyMembers: KnockoutObservableArray<Aci.Flex.DataModel.EntityHierarchyStatic>;
    entityHierarchyMappings: KnockoutObservableArray<Aci.Flex.DataModel.EntityHierarchyMapping>;
    dimensions: KnockoutObservableArray<Aci.Flex.DataModel.Dimension>;
    hierarchies: KnockoutObservableArray<Aci.Flex.DataModel.Hierarchy>;
    load(modelIdentifier: string): Q.Promise<boolean>;
    loadDimensions: () => Q.Promise<boolean>;
    getHierarchyDescription: (hierarchyIdentifier: string) => string;
    firstHierarchyName: KnockoutComputed<string>;
    secondHierarchyName: KnockoutComputed<string>;
    loadHierarchies: (dimensionIdentifier: string) => Q.Promise<boolean>;
    bindHierarchies: (shr: Aci.Flex.DataModel.HierarchyRelation) => void;
    bindFirstHierarchy(firstHierarchyIdentifier: string, secondHierarchyIdentifier: string): void;
    static deleteme<U>(u1: Array<U>, predicate: (item1: U) => boolean): void;
    getMappedMembers: (firstMemberStringSet: string) => string[];
    setMappedMembers: (firstMemberStringSet: string, selectedMembers: string[]) => void;
    isBinding: boolean;
    bindSecondHierarchy(firstHierarchyIdentifier: string, secondHierarchyIdentifier: string, selectedFirstMember: string): void;
    saveMappings: () => void;
    static getNodes(members: Array<Aci.Flex.DataModel.EntityHierarchyStatic>, selectedMembers: Array<string>): Array<TreeNode>;
}
declare function BindHierarchyMappingViewModel(modelIdentifier: string): void;
