declare class FreeboardUI {
    PANE_MARGIN: number;
    PANE_WIDTH: number;
    MIN_COLUMNS: number;
    COLUMN_WIDTH: number;
    userColumns: number;
    leftPreviewColumn: boolean;
    rightPreviewColumn: boolean;
    loadingIndicator: JQuery;
    grid: Gridster;
    constructor();
    processResize(layoutWidgets: any): void;
    private addGridColumn(shift);
    private subtractGridColumn(shift);
    private updateGridColumnControls();
    private getMaxDisplayableColumnCount();
    private updateGridWidth(newCols);
    private repositionGrid(repositionFunction);
    getUserColumns(): number;
    setUserColumns(numCols: any): void;
    private addHandlers();
    addPane(element: any, viewModel: any, isEditing: any): void;
    updatePane(element: any, viewModel: any): void;
    private updatePositionForScreenSize(paneModel, row, col);
    showLoadingIndicator(show: any): void;
    showPaneEditIcons(show: any, animate: any): void;
    attachWidgetEditIcons(element: any): void;
    showWidgetEditIcons(element: any, show: any): void;
    getPositionForScreenSize(paneModel: any): {
        row: any;
        col: any;
    };
    disableGrid(): void;
    enableGrid(): void;
    removePane(element: any): void;
    removeAllPanes(): void;
    addGridColumnLeft(): void;
    addGridColumnRight(): void;
    subGridColumnLeft(): void;
    subGridColumnRight(): void;
}
