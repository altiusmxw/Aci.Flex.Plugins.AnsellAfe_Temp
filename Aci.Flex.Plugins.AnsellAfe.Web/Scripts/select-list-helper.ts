class SelectListOption {
    value: any;
    text: string;
}

module SelectListHelper {
    export function getSelectedText(options: Array<SelectListOption>, id: number): string {
        var selected = ko.utils.arrayFirst(options, function (opt: SelectListOption) {
            return opt.value == id;
        });
        if (selected)
            return selected.text;

        return "";
    }
}