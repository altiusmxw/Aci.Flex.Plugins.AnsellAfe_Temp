module AfeCaptureOptions {
    
    var searchValidator: AfeSearchValidator;
    var searchViewModel = {
        query: ko.observable<string>(), foundAfes: ko.observableArray<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Afe>([])
    };

    export function InitializeOptions() {
        searchValidator = new AfeSearchValidator(searchViewModel.query);
        searchValidator.IsValid.subscribe((valid) => {
            $("#btnSearch").disable();
            if (valid)
                $("#btnSearch").enable();
        });

        ko.applyBindings(searchViewModel, $("#search-afe")[0]);
    }

    export function ShowOptions(optionType: string) {
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

    export function SearchAfe() {
        var showLoader = setTimeout(function () {
            $("#btnSearch").disable();
            $('#search-indicator').show();
        }, 300);

        var term = $("#txtSearch").val();
        var type = $("#btn-option-submit").data("afe-type");

        // Search WebAPI
        Flex.ApiClient.CommonAfeApi.ResolveFindAfes(term, searchViewModel.foundAfes).then(() => {
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

    export function SubmitAfeOptions(afeType: string) {
        if (!afeType)
            afeType = $("#btn-option-submit").data("afe-type");

        var form = $("form");
        form.attr("action", $.url("portal") + "AfeCapture/" + afeType);
    }

    function resetViewModels() {
        searchViewModel.query("");
        searchViewModel.foundAfes([]);
    }
}