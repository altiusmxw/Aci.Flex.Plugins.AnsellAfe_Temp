var RecallAfeHelper;
(function (RecallAfeHelper) {
    var viewModel;
    var workflowId;
    function Initialize(_workflowId) {
        workflowId = _workflowId;
        viewModel = new CommentsViewModel();
        ko.applyBindings(viewModel, $("#recall-modal")[0]);
    }
    RecallAfeHelper.Initialize = Initialize;
    function Recall() {
        swal({
            title: "Confirm Recall",
            type: "warning",
            showCancelButton: true,
            text: "Are you sure you want to recall this AFE?",
            closeOnConfirm: true,
            closeOnCancel: true
        }, function (confirmed) {
            if (confirmed) {
                showLoader = setTimeout(function () {
                    if (!$.url('isdebug'))
                        initializeFlexUpdateProgress($("#recall-progress"));
                    $("#recall-progress").show();
                }, 300);
                Flex.ApiClient.CommonAfeApi.RecallAfe(workflowId, viewModel.Comments()).then(function (success) {
                    clearTimeout(showLoader);
                    $("#recall-progress").hide();
                    if (success)
                        swal({ title: "Success", text: "AFE Recalled.", type: "success" }, function () {
                            $("#modal-actionWorkflow").modal('hide');
                        });
                    else
                        swal({ title: "Error", text: "Failed to recall AFE.", type: "error" });
                });
            }
        });
    }
    RecallAfeHelper.Recall = Recall;
})(RecallAfeHelper || (RecallAfeHelper = {}));
var CommentsViewModel = (function () {
    function CommentsViewModel() {
        this.Comments = ko.observable();
    }
    return CommentsViewModel;
}());
//# sourceMappingURL=recall-afe.js.map