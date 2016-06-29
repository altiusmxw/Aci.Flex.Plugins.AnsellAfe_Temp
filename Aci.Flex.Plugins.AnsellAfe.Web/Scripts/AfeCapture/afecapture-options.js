var AfeCaptureOptions;
(function (AfeCaptureOptions) {
    var searchValidator;
    var searchViewModel = {
        query: ko.observable(), foundAfes: ko.observableArray([])
    };
    function InitializeOptions() {
        searchValidator = new AfeSearchValidator(searchViewModel.query);
        searchValidator.IsValid.subscribe(function (valid) {
            $("#btnSearch").disable();
            if (valid)
                $("#btnSearch").enable();
        });
        ko.applyBindings(searchViewModel, $("#search-afe")[0]);
    }
    AfeCaptureOptions.InitializeOptions = InitializeOptions;
    function ShowOptions(optionType) {
        var btn = $("#btn-option-submit");
        //reset modal
        resetViewModels();
        $("#search-afe").hide();
        $("#afe-results").hide();
        btn.disable();
        var headerText = "Create New AFE";
        var btnText = "Create";
        var afeType = "New";
        if (optionType == "new") {
        }
        else {
            if (optionType == "clone") {
                headerText = "Clone Existing AFE";
                btnText = "Clone";
                afeType = "Clone";
            }
            else {
                headerText = "Choose AFE to Supplement";
                btnText = "Select";
                afeType = "Supplement";
            }
            $("#search-afe").show();
        }
        $("#options-header").text(headerText);
        btn.text(btnText);
        btn.data("afe-type", afeType);
        $("#modal-options").modal('show');
    }
    AfeCaptureOptions.ShowOptions = ShowOptions;
    function SearchAfe() {
        var showLoader = setTimeout(function () {
            $("#btnSearch").disable();
            $('#search-indicator').show();
        }, 300);
        var term = $("#txtSearch").val();
        var type = $("#btn-option-submit").data("afe-type");
        // Search WebAPI
        Flex.ApiClient.CommonAfeApi.ResolveFindAfes(term, searchViewModel.foundAfes).then(function () {
            clearTimeout(showLoader);
            $("#search-indicator").hide();
            $("#btnSearch").enable();
            $("#afe-results").show();
            $("input[name='SelectedAfeId']:radio").click(function () {
                if (type == "Clone") {
                    $("#btn-option-submit").enable();
                }
                else {
                    $("#btn-option-submit").enable();
                }
            });
        });
    }
    AfeCaptureOptions.SearchAfe = SearchAfe;
    function SubmitAfeOptions(afeType) {
        if (!afeType)
            afeType = $("#btn-option-submit").data("afe-type");
        var form = $("form");
        form.attr("action", $.url("portal") + "AfeCapture/" + afeType);
    }
    AfeCaptureOptions.SubmitAfeOptions = SubmitAfeOptions;
    function resetViewModels() {
        searchViewModel.query("");
        searchViewModel.foundAfes([]);
    }
})(AfeCaptureOptions || (AfeCaptureOptions = {}));
//# sourceMappingURL=afecapture-options.js.map