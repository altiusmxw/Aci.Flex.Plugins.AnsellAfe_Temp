interface Gritter {
    add: any;
}


interface JQueryStatic {
    url: any;
    loc: any;
    gritter: Gritter;
}

interface KnockoutStatic {
    simpleGrid: any;
}

interface JsTimeZone {
    name(): string
}

interface JsTz {
    determine(): JsTimeZone;
}

declare var jstz: JsTz;

// jquery.cookie.js
interface JQueryStatic {
    cookie(key: string): any;
    cookie(key: string, value: any): any;
    cookie(key: string, value: any, options: any): any;
}

interface JQuery {
    datetimepicker: any;
    enable(): void;
    disable(): void;
    setCssActive(): void;
}

declare function initializeFlexUpdateProgress(updateProgress: JQuery): void;

interface KnockoutBindingHandlers {
    showModal: KnockoutBindingHandler;
    highlight: KnockoutBindingHandler;
    bootstrapSwitchOn: KnockoutBindingHandler;
    dataTable: KnockoutBindingHandler;
}

interface JQueryUploadData {
    context: any;
    files: any[];
    loaded: number;
    total: number;
    index: number;
    error?: boolean;
}

interface JQueryFileUpload {
    on: any;
}


interface JQuery {
    bootstrapSwitch(): any;
    bootstrapSwitch(state: string): any;
    bootstrapSwitch(state: string, cb: any): any;
    typeahead(p1: any, config: any);

}


declare function swal(swalConfig: any);
declare function swal(swalConfig: any, f1: any);

declare class Bloodhound {
    constructor(bhConfig: any);
    static tokenizers: any;
    initialize();
    ttAdapter(): any;
}

//declare module Aci.Flex.Server.ObjectModel {
//    interface IWorkflowStatus {
//        test(): any;
//    }
//}
