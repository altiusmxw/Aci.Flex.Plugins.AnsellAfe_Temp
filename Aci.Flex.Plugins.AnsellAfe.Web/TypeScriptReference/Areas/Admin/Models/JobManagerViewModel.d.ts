declare class JobManagerViewModel {
    jobInstances: KnockoutObservableArray<Aci.Flex.DataModel.JobInstance>;
    sortFunction: (a: any, b: any) => number;
    jobProcessors: KnockoutObservableArray<Aci.Flex.Core.Primitives.FlexObjectIdentifier>;
    jobHistory: KnockoutObservableArray<Aci.Flex.DataModel.JobHistory>;
    jobSchedules: KnockoutObservableArray<Aci.Flex.DataModel.JobSchedule>;
    editingJobSchedule: KnockoutObservable<JobScheduleModel>;
    jobInstanceFilter: KnockoutObservable<string>;
    jobScheduleFilter: KnockoutObservable<string>;
    messageHubProxy: MyHubConnection;
    getEnabledClass(enabled: boolean): string;
    getStatusClass(status: number): string;
    selectedJob: KnockoutObservable<Aci.Flex.DataModel.JobInstance>;
    initialize(): Q.Promise<boolean>;
    registerSignalR(jobProcessorId: string): void;
    loadJobInstance: (jobInstanceId: string) => Q.Promise<boolean>;
    bindJobInstances: () => void;
    fetchJobQueue(): Q.Promise<boolean>;
    selectJob: (job: Aci.Flex.DataModel.JobInstance) => void;
    scheduleJob: () => void;
    editSchedule: (selectedSchedule: Aci.Flex.DataModel.JobSchedule) => void;
    cancelUpdate: () => void;
    createSchedule: (model: JobScheduleModel) => void;
}
declare class EnumEx {
    static getNames(e: any): string[];
    static getValues(e: any): number[];
    static getNamesAndValues(e: any): System.Tuple<number, string>[];
}
declare class JobScheduleModel {
    jobProcessorId: KnockoutObservable<string>;
    jobScheduleTypes: KnockoutObservableArray<System.Tuple<string, boolean>>;
    jobFrequencyTypes: KnockoutComputed<System.Tuple<number, string>[]>;
    daysOfWeek: KnockoutComputed<System.Tuple<number, string>[]>;
    jobSchedule: KnockoutObservable<Aci.Flex.DataModel.JobSchedule>;
    jobParameters: KnockoutObservableArray<Aci.Flex.Core.ParameterDescriptor>;
    getParameterTemplate(x: Aci.Flex.Core.ParameterDescriptor, y: any): string;
    parameterValue: (p: Aci.Flex.Core.ParameterDescriptor) => KnockoutComputed<any>;
    isOneTime: KnockoutComputed<boolean>;
    isDaily: KnockoutComputed<boolean>;
    isWeekly: KnockoutComputed<boolean>;
    isMonthly: KnockoutComputed<boolean>;
    constructor(schedule: Aci.Flex.DataModel.JobSchedule, parameters: Aci.Flex.Core.ParameterDescriptor[]);
    dayOfWeekSelection: (enumValue: number) => KnockoutComputed<boolean>;
}
declare function BindJobManagerViewModel(modelIdentifier: string, rootNode: any): void;
