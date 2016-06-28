module Aci.Flex.Core {
	export enum ActiveFlags {
		Active = 1,
		Inactive = 2,
		All = 4
	}
	export enum DaysOfWeek {
		Sunday = 1,
		Monday = 2,
		Tuesday = 4,
		Wednesday = 8,
		Thursday = 16,
		Friday = 32,
		Saturday = 64
	}
	export enum FrequencyRelativeInterval {
		None = 0,
		First = 1,
		Second = 2,
		Third = 4,
		Fourth = 8,
		Last = 16
	}
	export enum FrequencySubdayType {
		Time = 1,
		Seconds = 2,
		Minutes = 4,
		Hours = 8
	}
	export enum FrequencyType {
		Once = 1,
		Daily = 4,
		Weekly = 8,
		Monthly = 16,
		MonthlyRelative = 32,
		Startup = 64
	}
}
module Aci.Flex.DataModel {
	export enum HubDeviceType {
		Apple = 0,
		Android = 1,
		Windows = 2
	}
	export enum InputSourceParameterType {
		None = 0,
		SingleValue = 1,
		MultipleValue = 2,
		TemplatedMultipleValue = 3
	}
	export enum StorageItemType {
		Default = 0,
		License = 1,
		Report = 2,
		External = 999
	}
}
module Aci.Flex.DataModel.Enum {
	export enum AttributeType {
		None = 0,
		Key = 1,
		Name = 2,
		Value = 3
	}
	export enum HierarchyType {
		Unknown = 0,
		Regular = 1,
		ParentChild = 2
	}
}
module Aci.Flex.Server.Workflow {
	export enum ActivityCommentRequirementType {
		None = 0,
		Allowed = 1,
		Required = 2
	}
	export enum ChallengeResponseRequirementType {
		None = 0,
		Captcha = 1
	}
}



 