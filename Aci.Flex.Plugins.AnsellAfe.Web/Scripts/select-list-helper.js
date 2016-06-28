var SelectListOption = (function () {
    function SelectListOption() {
    }
    return SelectListOption;
}());
var SelectListHelper;
(function (SelectListHelper) {
    function getSelectedText(options, id) {
        var selected = ko.utils.arrayFirst(options, function (opt) {
            return opt.value == id;
        });
        if (selected)
            return selected.text;
        return "";
    }
    SelectListHelper.getSelectedText = getSelectedText;
})(SelectListHelper || (SelectListHelper = {}));
//# sourceMappingURL=select-list-helper.js.map