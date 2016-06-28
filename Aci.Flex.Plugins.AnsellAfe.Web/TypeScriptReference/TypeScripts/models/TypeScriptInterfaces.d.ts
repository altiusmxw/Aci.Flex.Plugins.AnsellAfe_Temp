
 
declare module Aci.Flex.Core.Primitives {
interface IFlexObjectIdentifier {
  Id: string;
  Name: string;
  FlexIdentifier: string;
}
}
declare module Aci.Flex.Server.Workflow {
interface IFlexActivityMetadata {
  Name: string;
  ReadableName: string;
  CommentRequirement: Aci.Flex.Server.Workflow.ActivityCommentRequirementType;
  ChallengeResponseRequirement: Aci.Flex.Server.Workflow.ChallengeResponseRequirementType;
  WorkflowViewName: string;
  RoleRestriction: string;
  UserRestriction: string;
  WorkflowInstanceId: string;
}
}
declare module Aci.Flex.Server.ObjectModel {
interface IWorkflowStatus {
  WorkflowIdentifier: string;
  Entities: Aci.Flex.Server.ObjectModel.IDimensionMemberInfo[];
  State: string;
  AvailableActions: System.Collections.Generic.IKeyValuePair[];
  BlockingBookmarkMetadata: Aci.Flex.Server.Workflow.IFlexActivityMetadata[];
  Attributes: System.Collections.Generic.IKeyValuePair[];
  Description: string;
  ImageUri: string;
  Input: string;
}
interface IDimensionInfo {
  DimensionIdentifier: string;
  HierarchyIdentifier: string;
  DimensionName: string;
  HierarchyName: string;
  ParameterType: number;
}
interface IDimensionMemberInfo extends Aci.Flex.Server.ObjectModel.IDimensionInfo {
  Key: string;
  Name: string;
  IsLeaf: boolean;
  StringSet: string;
  HierarchyLevel: number;
}
interface IWorkflowHistory {
  WorkflowId: string;
  EntryDate: Date;
  User: string;
  BookmarkName: string;
  ReadableBookmarkName: string;
  Comment: string;
  ImageUri: string;
  ParsedBookmarkName: string;
  EntryId: number;
}
interface IInputParameter {
  Members: Aci.Flex.Server.ObjectModel.IDimensionMemberInfo[];
  DimensionInfo: Aci.Flex.Server.ObjectModel.IDimensionInfo;
  ParameterType: Aci.Flex.DataModel.InputSourceParameterType;
  MemberCount: number;
  LeafMemberCount: number;
  Key: string;
  Value: string;
  Name: string;
}
interface IDashboardDataQuery {
  QueryText: string;
  QueryType: string;
}
}
declare module System.Collections.Generic {
interface IKeyValuePair {
  Key: any;
  Value: any;
}
}
declare module Aci.Flex.DataModel {
interface IEntityHierarchyStatic extends Aci.Flex.Core.Primitives.IFlexObjectIdentifier {
  HierarchyIdentifier: string;
  HierarchyLevel: number;
  ParentKey: string;
  MemberUniqueName: string;
  Sequence: number;
  StringSet: string;
  Depth: number;
  ChildCount: number;
  IsLeaf: boolean;
  ParentStringSet: string;
}
interface IHierarchy extends Aci.Flex.Core.Primitives.IFlexObjectIdentifier {
  DimensionIdentifier: string;
  Type: Aci.Flex.DataModel.Enum.HierarchyType;
  IsDefault: boolean;
  IsSecurable: boolean;
  LevelCount: number;
  IsEnabled: boolean;
}
interface IHierarchyAttribute extends Aci.Flex.Core.Primitives.IFlexObjectIdentifier {
  HierarchyIdentifier: string;
  IsKeyAttribute: boolean;
}
interface IUserHierarchyRole {
  UserHierarchyRoleId: number;
  UserIdentifier: string;
  MemberId: string;
  RoleIdentifier: string;
  HierarchyIdentifier: string;
  HierarchyLevel: number;
}
interface IUser extends Aci.Flex.Core.IPersonInfo {
  Password: number[];
  AvatarIdentifier: string;
  LastLogin: Date;
  PrincipalSID: string;
  IsGroup: boolean;
  TimeSinceLastLogin: string;
}
}
declare module Aci.Flex.Portal.Model {
interface IComposeMessageModel {
  Subject: string;
  Body: string;
  Recipients: string[];
}
interface IWorkflowStatusRequest {
  EventIdentifier: string;
  InputSourceIdentifier: string;
  WorkflowIdentifier: string;
  MemberFilter: Aci.Flex.Server.ObjectModel.IDimensionMemberInfo[];
  RestrictedOnly: boolean;
  InteractiveOnly: boolean;
}
}
declare module Aci.Flex.Core {
interface IPersonInfo extends Aci.Flex.Core.Primitives.IFlexObjectIdentifier {
  Firstname: string;
  Lastname: string;
  Email: string;
  Title: string;
}
}

 