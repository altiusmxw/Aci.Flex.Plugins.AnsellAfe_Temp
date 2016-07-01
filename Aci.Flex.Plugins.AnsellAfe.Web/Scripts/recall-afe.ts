module RecallAfeHelper {
    var viewModel: CommentsViewModel;
    var workflowId: string;

    export function Initialize(_workflowId: string) {
        workflowId = _workflowId;

        viewModel = new CommentsViewModel();
        ko.applyBindings(viewModel, $("#recall-modal")[0]);
    }

    export function Recall() {
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

                Flex.ApiClient.CommonAfeApi.RecallAfe(workflowId, viewModel.Comments()).then((success) => {
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
}

class CommentsViewModel {
    Comments: KnockoutObservable<string>;

    constructor() {
        this.Comments = ko.observable<string>();
    }
}