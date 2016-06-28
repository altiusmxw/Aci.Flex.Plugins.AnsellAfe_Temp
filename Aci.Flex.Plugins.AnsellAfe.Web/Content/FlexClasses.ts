
  /// <reference path="FlexEnums.ts" />

declare module Aci.Flex.Core {
	export interface ParameterDescriptor {
		Description: KnockoutObservable<string>;
		Label: KnockoutObservable<string>;
		Name: KnockoutObservable<string>;
		Options: KnockoutObservableArray<string>;
		ParameterType: KnockoutObservable<string>;
		Value: KnockoutObservable<string>;
	}
	export interface PersonInfo extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
		Email: KnockoutObservable<string>;
		Firstname: KnockoutObservable<string>;
		Lastname: KnockoutObservable<string>;
		Title: KnockoutObservable<string>;
	}
	export interface Schedule {
		ActiveEndDate: KnockoutObservable<Date>;
		ActiveEndTime: KnockoutObservable<Date>;
		ActiveStartDate: KnockoutObservable<Date>;
		ActiveStartTime: KnockoutObservable<Date>;
		FreqInterval: KnockoutObservable<number>;
		FreqRecurrenceFactor: KnockoutObservable<number>;
		FreqRelativeInterval: KnockoutObservable<Aci.Flex.Core.FrequencyRelativeInterval>;
		FreqSubdayInterval: KnockoutObservable<number>;
		FreqSubdayTime: KnockoutObservable<Date>;
		FreqSubdayType: KnockoutObservable<Aci.Flex.Core.FrequencySubdayType>;
		FreqType: KnockoutObservable<Aci.Flex.Core.FrequencyType>;
		HasEndDate: KnockoutObservable<boolean>;
		TimeZone: KnockoutObservable<string>;
	}
}
declare module Aci.Flex.Core.ObjectModel {
	export interface Member {
		HierarchyIdentifier: KnockoutObservable<string>;
		HierarchyLevel: KnockoutObservable<number>;
		Id: KnockoutObservable<string>;
	}
	export interface MemberInfo extends Aci.Flex.Core.ObjectModel.Member {
		IsLeaf: KnockoutObservable<boolean>;
		Name: KnockoutObservable<string>;
		StringSet: KnockoutObservable<string>;
	}
}
declare module Aci.Flex.Core.Primitives {
	export interface FlexObjectIdentifier {
		FlexIdentifier: KnockoutObservable<string>;
		Id: KnockoutObservable<string>;
		Name: KnockoutObservable<string>;
	}
}
declare module Aci.Flex.DataModel {
	export interface Content {
		ContentLocation: KnockoutObservable<Aci.Flex.DataModel.ContentLocation>;
		ContentLocationId: KnockoutObservable<number>;
		ContentText: KnockoutObservable<string>;
		ContentType: KnockoutObservable<Aci.Flex.DataModel.ContentType>;
		ContentTypeId: KnockoutObservable<number>;
		Subject: KnockoutObservable<string>;
		UpdateDate: KnockoutObservable<Date>;
		UpdatedBy: KnockoutObservable<string>;
	}
	export interface ContentLocation {
		ContentLocationId: KnockoutObservable<number>;
		Contents: KnockoutObservableArray<Aci.Flex.DataModel.Content>;
		CreateDate: KnockoutObservable<Date>;
		CreatedBy: KnockoutObservable<number>;
		FriendlyName: KnockoutObservable<string>;
		IsActive: KnockoutObservable<boolean>;
		ModelIdentifier: KnockoutObservable<string>;
		Name: KnockoutObservable<string>;
		UpdateDate: KnockoutObservable<Date>;
		UpdatedBy: KnockoutObservable<number>;
	}
	export interface ContentType {
		Contents: KnockoutObservableArray<Aci.Flex.DataModel.Content>;
		ContentTypeId: KnockoutObservable<number>;
		CreateDate: KnockoutObservable<Date>;
		CreatedBy: KnockoutObservable<number>;
		IsActive: KnockoutObservable<boolean>;
		Name: KnockoutObservable<string>;
		UpdateDate: KnockoutObservable<Date>;
		UpdatedBy: KnockoutObservable<number>;
	}
	export interface Cube extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
		ModelIdentifier: KnockoutObservable<string>;
	}
	export interface CubeDimension extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
		CubeIdentifier: KnockoutObservable<string>;
		DimensionIdentifier: KnockoutObservable<string>;
	}
	export interface DeviceRegistration extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
		Accessed: KnockoutObservable<Date>;
		Created: KnockoutObservable<Date>;
		DeviceType: KnockoutObservable<Aci.Flex.DataModel.HubDeviceType>;
		ModelIdentifier: KnockoutObservable<string>;
		Password: KnockoutObservable<string>;
		UserIdentifier: KnockoutObservable<string>;
	}
	export interface Dimension extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
		ModelIdentifier: KnockoutObservable<string>;
	}
	export interface EntityHierarchyMapping {
		FirstHierarchyIdentifier: KnockoutObservable<string>;
		FirstMemberKey: KnockoutObservable<string>;
		MappingKey: KnockoutObservable<number>;
		SecondHierarchyIdentifier: KnockoutObservable<string>;
		SecondMemberKey: KnockoutObservable<string>;
	}
	export interface EntityHierarchyStatic extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
		ChildCount: KnockoutObservable<number>;
		Depth: KnockoutObservable<number>;
		HierarchyIdentifier: KnockoutObservable<string>;
		HierarchyLevel: KnockoutObservable<number>;
		IsLeaf: KnockoutObservable<boolean>;
		MemberUniqueName: KnockoutObservable<string>;
		ParentKey: KnockoutObservable<string>;
		ParentStringSet: KnockoutObservable<string>;
		Sequence: KnockoutObservable<number>;
		StringSet: KnockoutObservable<string>;
	}
	export interface Event extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
		CloseDate: KnockoutObservable<Date>;
		ClosedBy: KnockoutObservable<number>;
		CreateDate: KnockoutObservable<Date>;
		CreatedBy: KnockoutObservable<string>;
		ModelIdentifier: KnockoutObservable<string>;
		OpenDate: KnockoutObservable<Date>;
		OpenedBy: KnockoutObservable<number>;
		Status: KnockoutObservable<number>;
		Visible: KnockoutObservable<boolean>;
	}
	export interface FlexRole extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
		RequiresLicense: KnockoutObservable<boolean>;
	}
	export interface Hierarchy extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
		DimensionIdentifier: KnockoutObservable<string>;
		IsDefault: KnockoutObservable<boolean>;
		IsEnabled: KnockoutObservable<boolean>;
		IsSecurable: KnockoutObservable<boolean>;
		LevelCount: KnockoutObservable<number>;
		Type: KnockoutObservable<Aci.Flex.DataModel.Enum.HierarchyType>;
	}
	export interface HierarchyAttribute extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
		HierarchyIdentifier: KnockoutObservable<string>;
		IsKeyAttribute: KnockoutObservable<boolean>;
	}
	export interface HierarchyRelation extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
		FirstHierarchyIdentifier: KnockoutObservable<string>;
		SecondHierarchyIdentifier: KnockoutObservable<string>;
	}
	export interface InboxNotification extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
		Acknowledged: KnockoutObservable<boolean>;
		Content: KnockoutObservable<string>;
		ModelName: KnockoutObservable<string>;
		NotificationSourceIdentifier: KnockoutObservable<string>;
		ReceivedDate: KnockoutObservable<Date>;
		RecipientUserIdentifier: KnockoutObservable<string>;
		SenderName: KnockoutObservable<string>;
		SenderUserIdentifier: KnockoutObservable<string>;
		Title: KnockoutObservable<string>;
	}
	export interface Input extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
		DeleteIDFormat: KnockoutObservable<string>;
		Description: KnockoutObservable<string>;
		DownloadBookmarkOverride: KnockoutObservable<string>;
		InputSourceIdentifier: KnockoutObservable<string>;
		RequireCico: KnockoutObservable<boolean>;
		RequireWorkflow: KnockoutObservable<boolean>;
		SubmitBookmarkOverride: KnockoutObservable<string>;
		TemplateName: KnockoutObservable<string>;
	}
	export interface InputSource extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
		Description: KnockoutObservable<string>;
		InputSourceGroupKey: KnockoutObservable<number>;
		ModelIdentifier: KnockoutObservable<string>;
		ModelWorkflowIdentifier: KnockoutObservable<string>;
		TemplateStorageId: KnockoutObservable<string>;
	}
	export interface InputSourceWorkflowAttribute {
		AttributeType: KnockoutObservable<Aci.Flex.DataModel.Enum.AttributeType>;
		DisplayName: KnockoutObservable<string>;
		HierarchyAttribute: KnockoutObservable<string>;
		InputSourceIdentifier: KnockoutObservable<string>;
		Order: KnockoutObservable<number>;
	}
	export interface InputSourceWorkflowFilter {
		HierarchyIdentifier: KnockoutObservable<string>;
		InputSourceIdentifier: KnockoutObservable<string>;
	}
	export interface InputSourceWorkflowKey {
		HierarchyIdentifier: KnockoutObservable<string>;
		InputSourceIdentifier: KnockoutObservable<string>;
		KeyBehavior: KnockoutObservable<Aci.Flex.DataModel.InputSourceParameterType>;
	}
	export interface JobHistory {
		EntryDate: KnockoutObservable<Date>;
		Id: KnockoutObservable<number>;
		JobInstanceId: KnockoutObservable<string>;
		Message: KnockoutObservable<string>;
	}
	export interface JobInstance {
		EndDate: KnockoutObservable<Date>;
		JobDisplayName: KnockoutObservable<string>;
		JobInstanceId: KnockoutObservable<string>;
		JobProcessorId: KnockoutObservable<string>;
		Parameters: KnockoutObservable<string>;
		Priority: KnockoutObservable<number>;
		ScheduleDate: KnockoutObservable<Date>;
		ScheduleIdentifier: KnockoutObservable<string>;
		StartDate: KnockoutObservable<Date>;
		Status: KnockoutObservable<number>;
		UserIdentifier: KnockoutObservable<string>;
	}
	export interface JobSchedule extends Aci.Flex.Core.Schedule {
		Description: KnockoutObservable<string>;
		FlexIdentifier: KnockoutObservable<string>;
		Id: KnockoutObservable<string>;
		IsEnabled: KnockoutObservable<boolean>;
		JobProcessorId: KnockoutObservable<string>;
		Name: KnockoutObservable<string>;
		OwnerIdentifier: KnockoutObservable<string>;
		Parameters: KnockoutObservable<string>;
		RetentionPeriod: KnockoutObservable<number>;
	}
	export interface LicenseAssignment {
		AssignedDate: KnockoutObservable<Date>;
		IsActive: KnockoutObservable<boolean>;
		LicenseIdentifier: KnockoutObservable<string>;
		ModelIdentifier: KnockoutObservable<string>;
		RevokedDate: KnockoutObservable<Date>;
		UserIdentifier: KnockoutObservable<string>;
	}
	export interface Model extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
		ModelType: KnockoutObservable<string>;
		OlapString: KnockoutObservable<string>;
		PersistentStorageProviderKey: KnockoutObservable<number>;
		ServerName: KnockoutObservable<string>;
		SqlString: KnockoutObservable<string>;
		TemporaryStorageProviderKey: KnockoutObservable<number>;
	}
	export interface ModelLicense {
		AssignedCount: KnockoutObservable<number>;
		IsActive: KnockoutObservable<boolean>;
		IsValid: KnockoutObservable<boolean>;
		LicenseData: KnockoutObservable<string>;
		LicenseIdentifier: KnockoutObservable<string>;
		ModelIdentifier: KnockoutObservable<string>;
		ModelType: KnockoutObservable<string>;
		Name: KnockoutObservable<string>;
		SeatCount: KnockoutObservable<number>;
		Signature: KnockoutObservable<string>;
		ValidFrom: KnockoutObservable<Date>;
		ValidTo: KnockoutObservable<Date>;
	}
	export interface ModelRole extends Aci.Flex.DataModel.FlexRole {
		IsAdministrator: KnockoutObservable<boolean>;
		IsHierarchyRole: KnockoutObservable<boolean>;
		IsInputSourceGroupRole: KnockoutObservable<boolean>;
		IsInputSourceRole: KnockoutObservable<boolean>;
		IsReader: KnockoutObservable<boolean>;
		IsSubmitter: KnockoutObservable<boolean>;
		ModelIdentifier: KnockoutObservable<string>;
		RoleHierarchy: KnockoutObservable<number>;
	}
	export interface ModelWorkflow extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
		ModelIdentifier: KnockoutObservable<string>;
	}
	export interface ReportDefinition extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
		Description: KnockoutObservable<string>;
		IsVisible: KnockoutObservable<boolean>;
		ModelIdentifier: KnockoutObservable<string>;
		ReportServerIdentifier: KnockoutObservable<string>;
	}
	export interface ReportParameter {
		Name: KnockoutObservable<string>;
		ParameterType: KnockoutObservable<string>;
		ReportIdentifier: KnockoutObservable<string>;
		Value: KnockoutObservable<string>;
	}
	export interface ReportServer extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
		Configuration: KnockoutObservable<string>;
		Impersonate: KnockoutObservable<boolean>;
		ModelIdentifier: KnockoutObservable<string>;
		Password: KnockoutObservable<string>;
		PluginType: KnockoutObservable<string>;
		Username: KnockoutObservable<string>;
	}
	export interface StorageItem extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
		CreateDate: KnockoutObservable<Date>;
		ExpiryDate: KnockoutObservable<Date>;
		ItemType: KnockoutObservable<Aci.Flex.DataModel.StorageItemType>;
		Length: KnockoutObservable<number>;
		MimeType: KnockoutObservable<string>;
		ProviderKey: KnockoutObservable<number>;
	}
	export interface StorageProvider {
		Configuration: KnockoutObservable<string>;
		IsDefault: KnockoutObservable<boolean>;
		IsTemporary: KnockoutObservable<boolean>;
		Key: KnockoutObservable<number>;
		Name: KnockoutObservable<string>;
		TypeName: KnockoutObservable<string>;
	}
	export interface Submission extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
		CreatedBy: KnockoutObservable<string>;
		CreatedDate: KnockoutObservable<Date>;
		CubeIdentifier: KnockoutObservable<string>;
		Status: KnockoutObservable<number>;
	}
	export interface SubmissionRestriction extends Aci.Flex.Core.ObjectModel.Member {
		SubmissionIdentifier: KnockoutObservable<string>;
	}
	export interface User extends Aci.Flex.Core.PersonInfo {
		AvatarIdentifier: KnockoutObservable<string>;
		IsGroup: KnockoutObservable<boolean>;
		LastLogin: KnockoutObservable<Date>;
		Password: KnockoutObservableArray<number>;
		PrincipalSID: KnockoutObservable<string>;
		TimeSinceLastLogin: KnockoutObservable<string>;
	}
	export interface UserHierarchyRole {
		HierarchyIdentifier: KnockoutObservable<string>;
		HierarchyLevel: KnockoutObservable<number>;
		MemberId: KnockoutObservable<string>;
		RoleIdentifier: KnockoutObservable<string>;
		UserHierarchyRoleId: KnockoutObservable<number>;
		UserIdentifier: KnockoutObservable<string>;
	}
	export interface WorkflowRoleMap {
		ModelWorkflowIdentifier: KnockoutObservable<string>;
		RoleIdentifier: KnockoutObservable<string>;
		WorkflowRoleId: KnockoutObservable<number>;
	}
}
declare module Aci.Flex.Portal.Model {
	export interface ComposeMessageModel {
		Body: KnockoutObservable<string>;
		Recipients: KnockoutObservableArray<string>;
		Subject: KnockoutObservable<string>;
	}
	export interface InputSourceInfo {
		InputSource: KnockoutObservable<Aci.Flex.DataModel.InputSource>;
		WorkflowDisplays: KnockoutObservableArray<Aci.Flex.DataModel.InputSourceWorkflowAttribute>;
		WorkflowFilters: KnockoutObservableArray<Aci.Flex.DataModel.InputSourceWorkflowFilter>;
		WorkflowKeys: KnockoutObservableArray<Aci.Flex.DataModel.InputSourceWorkflowKey>;
	}
	export interface ModelWorkflowInfo {
		ModelWorkflow: KnockoutObservable<Aci.Flex.DataModel.ModelWorkflow>;
		WorkflowRoleMaps: KnockoutObservableArray<Aci.Flex.DataModel.WorkflowRoleMap>;
	}
	export interface ProcessBookmarkRequest {
		BookmarkName: KnockoutObservable<string>;
		Comment: KnockoutObservable<string>;
		WorkflowInstanceId: KnockoutObservable<string>;
	}
	export interface ReportDefinitionModel {
		Parameters: KnockoutObservableArray<Aci.Flex.DataModel.ReportParameter>;
		Report: KnockoutObservable<Aci.Flex.DataModel.ReportDefinition>;
	}
	export interface ScheduleJobRequest {
		Parameters: KnockoutObservableArray<Aci.Flex.Core.ParameterDescriptor>;
		Schedule: KnockoutObservable<Aci.Flex.DataModel.JobSchedule>;
	}
	export interface SearchUserModel {
		Email: KnockoutObservable<string>;
		FirstName: KnockoutObservable<string>;
		LastName: KnockoutObservable<string>;
		PrincipalName: KnockoutObservable<string>;
	}
	export interface UpdateStorageProviderRequest {
		Parameters: KnockoutObservableArray<Aci.Flex.Core.ParameterDescriptor>;
		StorageProvider: KnockoutObservable<Aci.Flex.DataModel.StorageProvider>;
	}
	export interface UserInfo {
		AssignedLicenseIdentifier: KnockoutObservable<string>;
		HierarchyRoles: KnockoutObservableArray<Aci.Flex.DataModel.UserHierarchyRole>;
		IsActive: KnockoutObservable<boolean>;
		StaticRoles: KnockoutObservableArray<Aci.Flex.DataModel.ModelRole>;
		UserDetails: KnockoutObservable<Aci.Flex.DataModel.User>;
	}
	export interface WorkflowStatusRequest {
		EventIdentifier: KnockoutObservable<string>;
		InputSourceIdentifier: KnockoutObservable<string>;
		InteractiveOnly: KnockoutObservable<boolean>;
		MemberFilter: KnockoutObservableArray<Aci.Flex.Core.ObjectModel.MemberInfo>;
		RestrictedOnly: KnockoutObservable<boolean>;
		WorkflowIdentifier: KnockoutObservable<string>;
	}
}
declare module Aci.Flex.Server.ObjectModel {
	export interface DashboardDataQuery {
		QueryText: KnockoutObservable<string>;
		QueryType: KnockoutObservable<string>;
	}
	export interface DimensionInfo {
		DimensionIdentifier: KnockoutObservable<string>;
		DimensionName: KnockoutObservable<string>;
	}
	export interface HierarchyInfo extends Aci.Flex.Server.ObjectModel.DimensionInfo {
		HierarchyIdentifier: KnockoutObservable<string>;
		HierarchyName: KnockoutObservable<string>;
	}
	export interface HierarchyMemberInfo extends Aci.Flex.Server.ObjectModel.HierarchyInfo {
		HierarchyLevel: KnockoutObservable<number>;
		Id: KnockoutObservable<string>;
		IsLeaf: KnockoutObservable<boolean>;
		Name: KnockoutObservable<string>;
		StringSet: KnockoutObservable<string>;
	}
	export interface InputParameter extends Aci.Flex.Server.ObjectModel.WorkflowParameter {
		Key: KnockoutObservable<string>;
		LeafMemberCount: KnockoutObservable<number>;
		MemberCount: KnockoutObservable<number>;
		Members: KnockoutObservableArray<Aci.Flex.Core.ObjectModel.MemberInfo>;
		Name: KnockoutObservable<string>;
		Value: KnockoutObservable<string>;
	}
	export interface SearchResult {
		DisplayText: KnockoutObservable<string>;
		RelativeUrl: KnockoutObservable<string>;
	}
	export interface SubmissionRestrictionInfo {
		CriteriaCount: KnockoutObservable<number>;
		DimensionName: KnockoutObservable<string>;
		HierarchyIdentifier: KnockoutObservable<string>;
		HierarchyName: KnockoutObservable<string>;
	}
	export interface UserHierarchyRoleInfo {
		Entity: KnockoutObservable<Aci.Flex.DataModel.EntityHierarchyStatic>;
		HierarchyRole: KnockoutObservable<Aci.Flex.DataModel.UserHierarchyRole>;
		Role: KnockoutObservable<Aci.Flex.DataModel.ModelRole>;
	}
	export interface WorkflowHistory {
		BookmarkName: KnockoutObservable<string>;
		Comment: KnockoutObservable<string>;
		EntryDate: KnockoutObservable<Date>;
		EntryId: KnockoutObservable<number>;
		ImageUri: KnockoutObservable<string>;
		ParsedBookmarkName: KnockoutObservable<string>;
		PendingTimeSpan: KnockoutObservable<string>;
		ReadableBookmarkName: KnockoutObservable<string>;
		User: KnockoutObservable<string>;
		WorkflowId: KnockoutObservable<string>;
	}
	export interface WorkflowParameter extends Aci.Flex.Server.ObjectModel.HierarchyInfo {
		ParameterType: KnockoutObservable<Aci.Flex.DataModel.InputSourceParameterType>;
	}
	export interface WorkflowPendingAction {
		BookmarkName: KnockoutObservable<string>;
		PendingTimeSpan: KnockoutObservable<string>;
		PendingUsers: KnockoutObservableArray<string>;
		ReadableBookmarkName: KnockoutObservable<string>;
		WorkflowId: KnockoutObservable<string>;
	}
	export interface WorkflowStatus {
		Attributes: KnockoutObservableArray<System.Collections.Generic.KeyValuePair<string, string>>;
		AvailableActions: KnockoutObservableArray<System.Collections.Generic.KeyValuePair<string, Aci.Flex.Server.Workflow.FlexActivityMetadata>>;
		BlockingBookmarkMetadata: KnockoutObservableArray<Aci.Flex.Server.Workflow.FlexActivityMetadata>;
		Description: KnockoutObservable<string>;
		Entities: KnockoutObservableArray<Aci.Flex.Server.ObjectModel.HierarchyMemberInfo>;
		ImageUri: KnockoutObservable<string>;
		Input: KnockoutObservable<string>;
		State: KnockoutObservable<string>;
		WorkflowIdentifier: KnockoutObservable<string>;
	}
}
declare module Aci.Flex.Server.Workflow {
	export interface FlexActivityMetadata {
		ChallengeResponseRequirement: KnockoutObservable<Aci.Flex.Server.Workflow.ChallengeResponseRequirementType>;
		CommentRequirement: KnockoutObservable<Aci.Flex.Server.Workflow.ActivityCommentRequirementType>;
		Name: KnockoutObservable<string>;
		ReadableName: KnockoutObservable<string>;
		RoleRestriction: KnockoutObservable<string>;
		UserRestriction: KnockoutObservable<string>;
		WorkflowInstanceId: KnockoutObservable<string>;
		WorkflowViewName: KnockoutObservable<string>;
	}
}
declare module System.Collections.Generic {
	export interface KeyValuePair<TKey, TValue> {
		Key: KnockoutObservable<TKey>;
		Value: KnockoutObservable<TValue>;
	}
}

