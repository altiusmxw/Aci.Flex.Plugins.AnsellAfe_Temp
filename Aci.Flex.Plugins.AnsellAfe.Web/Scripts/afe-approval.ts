
module ApprovalHelper {
    var viewModel: ApprovalViewModel;
    var workflowId: string;

    export function Initialize(_workflowId: string) {
        showLoader = setTimeout(function () {
            if (!$.url('isdebug'))
                initializeFlexUpdateProgress($("#approval-progress"));
            $("#approval-progress").show();
        }, 300);

        workflowId = _workflowId;

        Flex.ApiClient.CommonAfeApi.GetApprovalAfeDetails(workflowId).then((vm) => {
            viewModel = new ApprovalViewModel(vm);
            CommonAfeHelper.bindHandlers();
            ko.applyBindings(viewModel, $("#binding-container")[0]);

            clearTimeout(showLoader);
            $("#approval-progress").hide();
        });
    }

    export function Approve() {
        SubmitApproval(true);
    }

    export function Reject() {
        SubmitApproval(false);
    }

    function SubmitApproval(isApproved: boolean) {
        showLoader = setTimeout(function () {
            if (!$.url('isdebug'))
                initializeFlexUpdateProgress($("#approval-progress"));
            $("#approval-progress").show();
        }, 300);

        Flex.ApiClient.CommonAfeApi.SubmitApproval(workflowId, isApproved, viewModel.Comments()).then((success) => {
            clearTimeout(showLoader);
            $("#approval-progress").hide();

            if (success)
            {
                var text = "AFE ";
                if (isApproved)
                    text += "Approved";
                else
                    text += "Rejected";

                swal({ title: "Success", text: text, type: "success" }, function () {
                    $("#modal-actionWorkflow").modal('hide');
                });
            }
            else
                swal({ title: "Error", text: "Failed to submit AFE approval decision.", type: "error" });
        });
    }
}

class ApprovalViewModel extends Aci.Flex.Plugins.AnsellAfe.Server.Objects.ApprovalAfeDetails {

    Comments: KnockoutObservable<string>;

    WriteOff_USD: KnockoutComputed<number> = ko.pureComputed<number>(() => {
        var self = this;
        var lc = self.NetWriteOff();
        return lc * self.ExchangeRate();
    }, this);
    RemainingBudget_USD: KnockoutComputed<number> = ko.pureComputed<number>(() => {
        var self = this;
        var lc = self.RemainingBudget();
        return lc * self.ExchangeRate();
    }, this);
    PrevAfe_LC: KnockoutComputed<number> = ko.pureComputed<number>(() => {
        var self = this;
        var lc = self.PreviousAfes();
        return lc / self.ExchangeRate();
    }, this);
    Budget_LC: KnockoutComputed<number> = ko.pureComputed<number>(() => {
        var self = this;
        var lc = self.Budget();
        return lc / self.ExchangeRate();
    }, this);
    Amount_USD: KnockoutComputed<number> = ko.pureComputed<number>(() => {
        var self = this;
        var lc = self.Amount();
        return lc * self.ExchangeRate();
    }, this);

    constructor(approvalDetails: Aci.Flex.Plugins.AnsellAfe.Server.Objects.ApprovalAfeDetails) {
        super();

        this.Comments = ko.observable<string>("");

        this.AfeId = approvalDetails.AfeId;
        this.AfeType = approvalDetails.AfeType;
        this.Amount = approvalDetails.Amount;
        this.Budget = approvalDetails.Budget;
        this.CashBackAfter = approvalDetails.CashBackAfter;
        this.CashBackBefore = approvalDetails.CashBackBefore;
        this.CreateDate = approvalDetails.CreateDate;
        this.CurrencyCode = approvalDetails.CurrencyCode;
        this.DivisionName = approvalDetails.DivisionName;
        this.ExchangeRate = approvalDetails.ExchangeRate;
        this.ExpenditureType = approvalDetails.ExpenditureType;
        this.FunctionName = approvalDetails.FunctionName;
        this.IRR = approvalDetails.IRR;
        this.NetWriteOff = approvalDetails.NetWriteOff;
        this.NPV = approvalDetails.NPV;
        this.PreviousAfes = approvalDetails.PreviousAfes;
        this.ProjectName = approvalDetails.ProjectName;
        this.ReferenceNo = approvalDetails.ReferenceNo;
        this.RemainingBudget = approvalDetails.RemainingBudget;
        this.ReturnOnAssets = approvalDetails.ReturnOnAssets;
        this.SiteName = approvalDetails.SiteName;
        this.StageGateProjectId = approvalDetails.StageGateProjectId;

        //this.ExchangeRate = approvalDetails.ExchangeRate;
        //this.Amount = approvalDetails.Amount;
        //this.Budget = approvalDetails.Budget;
        //this.PreviousAfes = approvalDetails.PreviousAfes;
        //this.RemainingBudget = approvalDetails.RemainingBudget;
        //this.CashBackBefore = approvalDetails.CashBackBefore;
        //this.CashBackAfter = approvalDetails.CashBackAfter;
        //this.ReturnOnAssets = approvalDetails.ReturnOnAssets;
        //this.NPV = approvalDetails.NPV;
        //this.IRR = approvalDetails.IRR;
        //this.NetWriteOff = approvalDetails.NetWriteOff;
    }
}