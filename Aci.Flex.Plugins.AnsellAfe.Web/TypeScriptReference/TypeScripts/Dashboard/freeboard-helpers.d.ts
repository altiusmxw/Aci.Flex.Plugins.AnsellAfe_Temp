interface HeadStatic {
    js(blah1: any, blah2?: any);
}

interface SettingDefinition {
    type: string;
    name: string;
    value: string;

}

interface FreeboardPlugin {
    type_name: string;
    display_name: string;
    name: string;
}

interface WidgetPlugin extends FreeboardPlugin {

    fill_size: boolean;
    settings: Array<SettingDefinition>;
    newInstance(settings: Array<SettingDefinition>, fn: any): WidgetPlugin;
    dispose();
    external_scripts: any;
}

interface DataSourcePlugin extends FreeboardPlugin {

    newInstance(settings: Array<SettingDefinition>, fn: any, cb: any): DataSourcePlugin;
    dispose();
    external_scripts: any;
}

interface Gridster {
    cols: number;
    $el: any;
    generate_grid_and_stylesheet();
    init();
    add_widget(element, width: number, height: number, col: number, row: number);
    resize_widget(p1: any, p2: any, p3: any, p4: any);
    disable();
    enable();
    remove_widget(element: any);
    remove_all_widgets();
    set_dom_grid_height();

}

interface JQuery {
    gridster(fn: any);
    attrchange(fn: any);
    sparkline(values: any, options: any);
    eventEmitter: any;
}
interface JQueryStatic {
    eventEmitter: any;
}

//interface FreeboardUI {
//    constructor(p1: any, p2: any);
//    removeAllPanes();
//    processResize(p1: boolean);
//    showLoadingIndicator(p1: boolean);
//    addGridColumnLeft();
//    addGridColumnRight();
//    subGridColumnLeft();
//    subGridColumnRight();
//    disableGrid();
//    enableGrid();
//    attachWidgetEditIcons(element: any);
//    showPaneEditIcons(editing: any, animate: any);
//    getUserColumns();
//    setUserColumns(columns: any);
//    getPositionForScreenSize(pane: any);
//}

interface FreeboardStatic {
    loadDatasourcePlugin(datasource: any);
    loadWidgetPlugin(widget: any);
    getStyleString(styleName: string);
    addStyle(styleName: string, style: string);
}

interface KnockoutBindingHandlers {
    grid: KnockoutBindingHandler;
    widget: KnockoutBindingHandler;
    pane: KnockoutBindingHandler;
    datasourceTypeSettings: KnockoutBindingHandler;
    pluginEditor: KnockoutBindingHandler;
}


interface GoogleMap {
    LatLng: GoogleLocation;
    panTo(location: GoogleLocation);
    hover: boolean;
    setOptions(options: any);
}

interface Google {
    maps: any;

}

interface GoogleLocation {
    lon: number;
    lat: number;
}

interface Window {
    google: Google;
    gmap_initialize: any;
    MutationObserver: any;
    WebKitMutationObserver: any;
}



interface NVD3 {
    models: any;
}

declare class JustGage {
    constructor(options: any);
}

declare class JSEditor {
    setAssetRoot(p1: any);
}

declare class PluginEditor {
    constructor(jsEditor: JSEditor, valueEditor: any);
    createPluginEditor(p1: any, p2: any, p3: any, p4: any, p5: any);
}

declare class DeveloperConsole {
    constructor(freeboardModel: FreeboardModel);
    showDeveloperConsole();
}

declare class DialogBox {
    constructor(elem: any, title: string, y: string, n: string, fn: any);
}

declare function processPluginSettings(element, valueAccessor, allBindingsAccessor, viewModel, bindingContext);


declare function Raphael(element: any, width: number, height: number);
declare var google: Google;
declare var window: Window;
declare var freeboard: FreeboardStatic;
declare var head: HeadStatic;

declare var nv: NVD3;