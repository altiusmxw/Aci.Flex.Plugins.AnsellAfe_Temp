interface ValueEditorOption {
    value: string;
    follow_char: string;
}
declare class ValueEditor {
    _veDatasourceRegex: RegExp;
    _autocompleteOptions: any[];
    _autocompleteReplacementString: any;
    freeboardModel: FreeboardModel;
    constructor(theFreeboardModel: FreeboardModel);
    _resizeValueEditor: (element: any) => void;
    _autocompleteFromDatasource: (inputString: any, datasources: DataSourceModel[]) => void;
    createValueEditor: (element: any) => void;
}
