declare module Aci.Flex.Core.Primitives {
    class FlexObjectIdentifier {
        constructor();
        Id: KnockoutObservable<string>;
        Name: KnockoutObservable<string>;
        FlexIdentifier: KnockoutObservable<string>;
    }
}
declare module Aci.Flex.Core {
    class PersonInfo extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
        constructor();
        Firstname: KnockoutObservable<string>;
        Lastname: KnockoutObservable<string>;
        Email: KnockoutObservable<string>;
        Title: KnockoutObservable<string>;
    }
    class ParameterDescriptor {
        constructor();
        Name: KnockoutObservable<string>;
        Label: KnockoutObservable<string>;
        Value: KnockoutObservable<string>;
        Description: KnockoutObservable<string>;
        ParameterType: KnockoutObservable<string>;
        Options: KnockoutObservableArray<string>;
    }
    class Schedule {
        constructor();
        FreqType: KnockoutObservable<Aci.Flex.Core.FrequencyType>;
        FreqInterval: KnockoutObservable<number>;
        FreqSubdayType: KnockoutObservable<Aci.Flex.Core.FrequencySubdayType>;
        FreqSubdayInterval: KnockoutObservable<number>;
        FreqSubdayTime: KnockoutObservable<Date>;
        FreqRelativeInterval: KnockoutObservable<Aci.Flex.Core.FrequencyRelativeInterval>;
        FreqRecurrenceFactor: KnockoutObservable<number>;
        ActiveStartDate: KnockoutObservable<Date>;
        ActiveStartTime: KnockoutObservable<Date>;
        ActiveEndDate: KnockoutObservable<Date>;
        ActiveEndTime: KnockoutObservable<Date>;
        TimeZone: KnockoutObservable<string>;
    }
}
declare module Aci.Flex.Server.Workflow {
    class FlexActivityMetadata {
        constructor();
        Name: KnockoutObservable<string>;
        ReadableName: KnockoutObservable<string>;
        CommentRequirement: KnockoutObservable<Aci.Flex.Server.Workflow.ActivityCommentRequirementType>;
        ChallengeResponseRequirement: KnockoutObservable<Aci.Flex.Server.Workflow.ChallengeResponseRequirementType>;
        WorkflowViewName: KnockoutObservable<string>;
        RoleRestriction: KnockoutObservable<string>;
        UserRestriction: KnockoutObservable<string>;
        WorkflowInstanceId: KnockoutObservable<string>;
    }
}
declare module Aci.Flex.Server.ObjectModel {
    class WorkflowStatus {
        constructor();
        WorkflowIdentifier: KnockoutObservable<string>;
        Entities: KnockoutObservableArray<Aci.Flex.Server.ObjectModel.DimensionMemberInfo>;
        State: KnockoutObservable<string>;
        AvailableActions: KnockoutObservableArray<System.Collections.Generic.KeyValuePair>;
        BlockingBookmarkMetadata: KnockoutObservableArray<Aci.Flex.Server.Workflow.FlexActivityMetadata>;
        Attributes: KnockoutObservableArray<System.Collections.Generic.KeyValuePair>;
        Description: KnockoutObservable<string>;
        ImageUri: KnockoutObservable<string>;
        Input: KnockoutObservable<string>;
    }
    class DimensionInfo {
        constructor();
        DimensionIdentifier: KnockoutObservable<string>;
        HierarchyIdentifier: KnockoutObservable<string>;
        DimensionName: KnockoutObservable<string>;
        HierarchyName: KnockoutObservable<string>;
        ParameterType: KnockoutObservable<number>;
    }
    class DimensionMemberInfo extends Aci.Flex.Server.ObjectModel.DimensionInfo {
        constructor();
        Key: KnockoutObservable<string>;
        Name: KnockoutObservable<string>;
        IsLeaf: KnockoutObservable<boolean>;
        StringSet: KnockoutObservable<string>;
        HierarchyLevel: KnockoutObservable<number>;
    }
    class WorkflowHistory {
        constructor();
        WorkflowId: KnockoutObservable<string>;
        EntryDate: KnockoutObservable<Date>;
        User: KnockoutObservable<string>;
        BookmarkName: KnockoutObservable<string>;
        ReadableBookmarkName: KnockoutObservable<string>;
        Comment: KnockoutObservable<string>;
        ImageUri: KnockoutObservable<string>;
        ParsedBookmarkName: KnockoutObservable<string>;
        EntryId: KnockoutObservable<number>;
    }
    class InputParameter {
        constructor();
        Members: KnockoutObservableArray<Aci.Flex.Server.ObjectModel.DimensionMemberInfo>;
        DimensionInfo: KnockoutObservable<Aci.Flex.Server.ObjectModel.DimensionInfo>;
        ParameterType: KnockoutObservable<Aci.Flex.DataModel.InputSourceParameterType>;
        MemberCount: KnockoutObservable<number>;
        LeafMemberCount: KnockoutObservable<number>;
        Key: KnockoutObservable<string>;
        Value: KnockoutObservable<string>;
        Name: KnockoutObservable<string>;
    }
    class UserHierarchyRoleInfo {
        constructor();
        HierarchyRole: KnockoutObservable<Aci.Flex.DataModel.UserHierarchyRole>;
        Role: KnockoutObservable<Aci.Flex.DataModel.ModelRole>;
        Entity: KnockoutObservable<Aci.Flex.DataModel.EntityHierarchyStatic>;
    }
    class SearchResult {
        constructor();
        DisplayText: KnockoutObservable<string>;
        RelativeUrl: KnockoutObservable<string>;
    }
    class DashboardDataQuery {
        constructor();
        QueryText: KnockoutObservable<string>;
        QueryType: KnockoutObservable<string>;
    }
}
declare module System.Collections.Generic {
    class KeyValuePair {
        constructor();
        Key: KnockoutObservable<any>;
        Value: KnockoutObservable<any>;
    }
}
declare module Aci.Flex.DataModel {
    class ContentLocation {
        constructor();
        ModelIdentifier: KnockoutObservable<string>;
        ContentLocationId: KnockoutObservable<number>;
        Name: KnockoutObservable<string>;
        FriendlyName: KnockoutObservable<string>;
        IsActive: KnockoutObservable<boolean>;
        CreatedBy: KnockoutObservable<number>;
        CreateDate: KnockoutObservable<Date>;
        UpdatedBy: KnockoutObservable<number>;
        UpdateDate: KnockoutObservable<Date>;
        Contents: KnockoutObservableArray<Aci.Flex.DataModel.Content>;
    }
    class Content {
        constructor();
        ContentTypeId: KnockoutObservable<number>;
        ContentLocationId: KnockoutObservable<number>;
        ContentText: KnockoutObservable<string>;
        Subject: KnockoutObservable<string>;
        UpdatedBy: KnockoutObservable<string>;
        UpdateDate: KnockoutObservable<Date>;
        ContentLocation: KnockoutObservable<Aci.Flex.DataModel.ContentLocation>;
        ContentType: KnockoutObservable<Aci.Flex.DataModel.ContentType>;
    }
    class ContentType {
        constructor();
        ContentTypeId: KnockoutObservable<number>;
        Name: KnockoutObservable<string>;
        IsActive: KnockoutObservable<boolean>;
        CreatedBy: KnockoutObservable<number>;
        CreateDate: KnockoutObservable<Date>;
        UpdatedBy: KnockoutObservable<number>;
        UpdateDate: KnockoutObservable<Date>;
        Contents: KnockoutObservableArray<Aci.Flex.DataModel.Content>;
    }
    class Model extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
        constructor();
        ServerName: KnockoutObservable<string>;
        OlapString: KnockoutObservable<string>;
        SqlString: KnockoutObservable<string>;
        ModelType: KnockoutObservable<string>;
        PersistentStorageProviderKey: KnockoutObservable<number>;
        TemporaryStorageProviderKey: KnockoutObservable<number>;
    }
    class Event extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
        constructor();
        Status: KnockoutObservable<number>;
        CreateDate: KnockoutObservable<Date>;
        CreatedBy: KnockoutObservable<string>;
        OpenDate: KnockoutObservable<Date>;
        OpenedBy: KnockoutObservable<number>;
        CloseDate: KnockoutObservable<Date>;
        ClosedBy: KnockoutObservable<number>;
        ModelIdentifier: KnockoutObservable<string>;
        Visible: KnockoutObservable<boolean>;
    }
    class EntityHierarchyStatic extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
        constructor();
        HierarchyIdentifier: KnockoutObservable<string>;
        HierarchyLevel: KnockoutObservable<number>;
        ParentKey: KnockoutObservable<string>;
        MemberUniqueName: KnockoutObservable<string>;
        Sequence: KnockoutObservable<number>;
        StringSet: KnockoutObservable<string>;
        Depth: KnockoutObservable<number>;
        ChildCount: KnockoutObservable<number>;
        IsLeaf: KnockoutObservable<boolean>;
        ParentStringSet: KnockoutObservable<string>;
    }
    class InputSource extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
        constructor();
        ModelIdentifier: KnockoutObservable<string>;
        Description: KnockoutObservable<string>;
        ModelWorkflowIdentifier: KnockoutObservable<string>;
        TemplateStorageId: KnockoutObservable<string>;
        InputSourceGroupKey: KnockoutObservable<number>;
    }
    class Input extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
        constructor();
        Description: KnockoutObservable<string>;
        DeleteIDFormat: KnockoutObservable<string>;
        TemplateName: KnockoutObservable<string>;
        InputSourceIdentifier: KnockoutObservable<string>;
        RequireWorkflow: KnockoutObservable<boolean>;
        RequireCico: KnockoutObservable<boolean>;
        DownloadBookmarkOverride: KnockoutObservable<string>;
        SubmitBookmarkOverride: KnockoutObservable<string>;
    }
    class EntityHierarchyMapping {
        constructor();
        MappingKey: KnockoutObservable<number>;
        FirstHierarchyIdentifier: KnockoutObservable<string>;
        FirstMemberKey: KnockoutObservable<string>;
        SecondHierarchyIdentifier: KnockoutObservable<string>;
        SecondMemberKey: KnockoutObservable<string>;
    }
    class Dimension extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
        constructor();
        ModelIdentifier: KnockoutObservable<string>;
    }
    class Hierarchy extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
        constructor();
        DimensionIdentifier: KnockoutObservable<string>;
        Type: KnockoutObservable<Aci.Flex.DataModel.Enum.HierarchyType>;
        IsDefault: KnockoutObservable<boolean>;
        IsSecurable: KnockoutObservable<boolean>;
        LevelCount: KnockoutObservable<number>;
        IsEnabled: KnockoutObservable<boolean>;
    }
    class HierarchyRelation extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
        constructor();
        FirstHierarchyIdentifier: KnockoutObservable<string>;
        SecondHierarchyIdentifier: KnockoutObservable<string>;
    }
    class HierarchyAttribute extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
        constructor();
        HierarchyIdentifier: KnockoutObservable<string>;
        IsKeyAttribute: KnockoutObservable<boolean>;
    }
    class LicenseAssignment {
        constructor();
        ModelIdentifier: KnockoutObservable<string>;
        UserIdentifier: KnockoutObservable<string>;
        LicenseIdentifier: KnockoutObservable<string>;
        AssignedDate: KnockoutObservable<Date>;
        RevokedDate: KnockoutObservable<Date>;
        IsActive: KnockoutObservable<boolean>;
    }
    class User extends Aci.Flex.Core.PersonInfo {
        constructor();
        Password: KnockoutObservableArray<number>;
        AvatarIdentifier: KnockoutObservable<string>;
        LastLogin: KnockoutObservable<Date>;
        PrincipalSID: KnockoutObservable<string>;
        IsGroup: KnockoutObservable<boolean>;
        TimeSinceLastLogin: KnockoutObservable<string>;
    }
    class FlexRole extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
        constructor();
        RequiresLicense: KnockoutObservable<boolean>;
    }
    class ModelRole extends Aci.Flex.DataModel.FlexRole {
        constructor();
        ModelIdentifier: KnockoutObservable<string>;
        RoleHierarchy: KnockoutObservable<number>;
        IsHierarchyRole: KnockoutObservable<boolean>;
        IsInputSourceRole: KnockoutObservable<boolean>;
        IsInputSourceGroupRole: KnockoutObservable<boolean>;
        IsAdministrator: KnockoutObservable<boolean>;
        IsSubmitter: KnockoutObservable<boolean>;
        IsReader: KnockoutObservable<boolean>;
        UserHierarchyRoles: KnockoutObservableArray<Aci.Flex.DataModel.UserHierarchyRole>;
    }
    class UserHierarchyRole {
        constructor();
        UserHierarchyRoleId: KnockoutObservable<number>;
        UserIdentifier: KnockoutObservable<string>;
        MemberId: KnockoutObservable<string>;
        RoleIdentifier: KnockoutObservable<string>;
        HierarchyIdentifier: KnockoutObservable<string>;
        HierarchyLevel: KnockoutObservable<number>;
    }
    class ModelWorkflow extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
        constructor();
        ModelIdentifier: KnockoutObservable<string>;
    }
    class ModelLicense {
        constructor();
        ModelIdentifier: KnockoutObservable<string>;
        LicenseIdentifier: KnockoutObservable<string>;
        ValidFrom: KnockoutObservable<Date>;
        ValidTo: KnockoutObservable<Date>;
        SeatCount: KnockoutObservable<number>;
        ModelType: KnockoutObservable<string>;
        Name: KnockoutObservable<string>;
        AssignedCount: KnockoutObservable<number>;
        LicenseData: KnockoutObservable<string>;
        Signature: KnockoutObservable<string>;
        IsValid: KnockoutObservable<boolean>;
        IsActive: KnockoutObservable<boolean>;
    }
    class WorkflowRoleMap {
        constructor();
        ModelWorkflowIdentifier: KnockoutObservable<string>;
        RoleIdentifier: KnockoutObservable<string>;
        WorkflowRoleId: KnockoutObservable<number>;
    }
    class ReportServer extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
        constructor();
        Configuration: KnockoutObservable<string>;
        PluginType: KnockoutObservable<string>;
        ModelIdentifier: KnockoutObservable<string>;
        Username: KnockoutObservable<string>;
        Password: KnockoutObservable<string>;
        Impersonate: KnockoutObservable<boolean>;
    }
    class ReportDefinition extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
        constructor();
        ModelIdentifier: KnockoutObservable<string>;
        ReportServerIdentifier: KnockoutObservable<string>;
        Description: KnockoutObservable<string>;
        IsVisible: KnockoutObservable<boolean>;
    }
    class ReportParameter {
        constructor();
        ReportIdentifier: KnockoutObservable<string>;
        Name: KnockoutObservable<string>;
        Value: KnockoutObservable<string>;
        ParameterType: KnockoutObservable<string>;
    }
    class InputSourceWorkflowKey {
        constructor();
        InputSourceIdentifier: KnockoutObservable<string>;
        HierarchyIdentifier: KnockoutObservable<string>;
        KeyBehavior: KnockoutObservable<Aci.Flex.DataModel.Enum.WorkflowKeyBehavior>;
    }
    class InputSourceWorkflowAttribute {
        constructor();
        InputSourceIdentifier: KnockoutObservable<string>;
        HierarchyAttribute: KnockoutObservable<string>;
        AttributeType: KnockoutObservable<Aci.Flex.DataModel.Enum.AttributeType>;
        Order: KnockoutObservable<number>;
        DisplayName: KnockoutObservable<string>;
    }
    class InputSourceWorkflowFilter {
        constructor();
        InputSourceIdentifier: KnockoutObservable<string>;
        HierarchyIdentifier: KnockoutObservable<string>;
    }
    class InboxNotification extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
        constructor();
        RecipientUserIdentifier: KnockoutObservable<string>;
        SenderUserIdentifier: KnockoutObservable<string>;
        NotificationSourceIdentifier: KnockoutObservable<string>;
        Acknowledged: KnockoutObservable<boolean>;
        Title: KnockoutObservable<string>;
        Content: KnockoutObservable<string>;
        ModelName: KnockoutObservable<string>;
        ReceivedDate: KnockoutObservable<Date>;
        SenderName: KnockoutObservable<string>;
    }
    class StorageItem extends Aci.Flex.Core.Primitives.FlexObjectIdentifier {
        constructor();
        MimeType: KnockoutObservable<string>;
        ProviderKey: KnockoutObservable<number>;
        Length: KnockoutObservable<number>;
        ExpiryDate: KnockoutObservable<Date>;
        CreateDate: KnockoutObservable<Date>;
        ItemType: KnockoutObservable<Aci.Flex.DataModel.StorageItemType>;
    }
    class StorageProvider {
        constructor();
        Key: KnockoutObservable<number>;
        Name: KnockoutObservable<string>;
        TypeName: KnockoutObservable<string>;
        Configuration: KnockoutObservable<string>;
        IsDefault: KnockoutObservable<boolean>;
        IsTemporary: KnockoutObservable<boolean>;
    }
    class JobInstance {
        constructor();
        JobInstanceId: KnockoutObservable<string>;
        JobProcessorId: KnockoutObservable<string>;
        UserIdentifier: KnockoutObservable<string>;
        JobDisplayName: KnockoutObservable<string>;
        ScheduleDate: KnockoutObservable<Date>;
        StartDate: KnockoutObservable<Date>;
        EndDate: KnockoutObservable<Date>;
        Parameters: KnockoutObservable<string>;
        Status: KnockoutObservable<number>;
        ScheduleIdentifier: KnockoutObservable<string>;
        Priority: KnockoutObservable<number>;
    }
    class JobSchedule extends Aci.Flex.Core.Schedule {
        constructor();
        JobProcessorId: KnockoutObservable<string>;
        OwnerIdentifier: KnockoutObservable<string>;
        Parameters: KnockoutObservable<string>;
        IsEnabled: KnockoutObservable<boolean>;
        RetentionPeriod: KnockoutObservable<number>;
        Id: KnockoutObservable<string>;
        Name: KnockoutObservable<string>;
        Description: KnockoutObservable<string>;
        FlexIdentifier: KnockoutObservable<string>;
    }
    class JobHistory {
        constructor();
        Id: KnockoutObservable<number>;
        JobInstanceId: KnockoutObservable<string>;
        EntryDate: KnockoutObservable<Date>;
        Message: KnockoutObservable<string>;
    }
}
declare module Aci.Flex.Portal.Model {
    class EntityHierarchyMappingInfo {
        constructor();
        HierarchyRelationIdentifier: KnockoutObservable<string>;
        Mappings: KnockoutObservableArray<Aci.Flex.DataModel.EntityHierarchyMapping>;
    }
    class UserInfo {
        constructor();
        UserDetails: KnockoutObservable<Aci.Flex.DataModel.User>;
        HierarchyRoles: KnockoutObservableArray<Aci.Flex.DataModel.UserHierarchyRole>;
        StaticRoles: KnockoutObservableArray<Aci.Flex.DataModel.ModelRole>;
        IsActive: KnockoutObservable<boolean>;
        AssignedLicenseIdentifier: KnockoutObservable<string>;
    }
    class ModelWorkflowInfo {
        constructor();
        ModelWorkflow: KnockoutObservable<Aci.Flex.DataModel.ModelWorkflow>;
        WorkflowRoleMaps: KnockoutObservableArray<Aci.Flex.DataModel.WorkflowRoleMap>;
    }
    class InputSourceInfo {
        constructor();
        InputSource: KnockoutObservable<Aci.Flex.DataModel.InputSource>;
        WorkflowKeys: KnockoutObservableArray<Aci.Flex.DataModel.InputSourceWorkflowKey>;
        WorkflowDisplays: KnockoutObservableArray<Aci.Flex.DataModel.InputSourceWorkflowAttribute>;
        WorkflowFilters: KnockoutObservableArray<Aci.Flex.DataModel.InputSourceWorkflowFilter>;
    }
    class SearchUserModel {
        constructor();
        FirstName: KnockoutObservable<string>;
        LastName: KnockoutObservable<string>;
        PrincipalName: KnockoutObservable<string>;
        Email: KnockoutObservable<string>;
    }
    class ReportDefinitionModel {
        constructor();
        Report: KnockoutObservable<Aci.Flex.DataModel.ReportDefinition>;
        Parameters: KnockoutObservableArray<Aci.Flex.DataModel.ReportParameter>;
    }
    class WorkflowStatusRequest {
        constructor();
        EventIdentifier: KnockoutObservable<string>;
        InputSourceIdentifier: KnockoutObservable<string>;
        WorkflowIdentifier: KnockoutObservable<string>;
        MemberFilter: KnockoutObservableArray<Aci.Flex.Server.ObjectModel.DimensionMemberInfo>;
        RestrictedOnly: KnockoutObservable<boolean>;
        InteractiveOnly: KnockoutObservable<boolean>;
    }
    class ProcessBookmarkRequest {
        constructor();
        WorkflowInstanceId: KnockoutObservable<string>;
        BookmarkName: KnockoutObservable<string>;
        Comment: KnockoutObservable<string>;
    }
    class ComposeMessageModel {
        constructor();
        Subject: KnockoutObservable<string>;
        Body: KnockoutObservable<string>;
        Recipients: KnockoutObservableArray<string>;
    }
    class ScheduleJobRequest {
        constructor();
        Schedule: KnockoutObservable<Aci.Flex.DataModel.JobSchedule>;
        Parameters: KnockoutObservableArray<Aci.Flex.Core.ParameterDescriptor>;
    }
    class UpdateStorageProviderRequest {
        constructor();
        StorageProvider: KnockoutObservable<Aci.Flex.DataModel.StorageProvider>;
        Parameters: KnockoutObservableArray<Aci.Flex.Core.ParameterDescriptor>;
    }
}
