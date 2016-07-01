var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var ApprovalHelper;
(function (ApprovalHelper) {
    var viewModel;
    var workflowId;
    function Initialize(_workflowId) {
        showLoader = setTimeout(function () {
            if (!$.url('isdebug'))
                initializeFlexUpdateProgress($("#approval-progress"));
            $("#approval-progress").show();
        }, 300);
        workflowId = _workflowId;
        Flex.ApiClient.CommonAfeApi.GetApprovalAfeDetails(workflowId).then(function (vm) {
            viewModel = new ApprovalViewModel(vm);
            CommonAfeHelper.bindHandlers();
            ko.applyBindings(viewModel, $("#binding-container")[0]);
            clearTimeout(showLoader);
            $("#approval-progress").hide();
        });
    }
    ApprovalHelper.Initialize = Initialize;
    function Approve() {
        SubmitApproval(true);
    }
    ApprovalHelper.Approve = Approve;
    function Reject() {
        SubmitApproval(false);
    }
    ApprovalHelper.Reject = Reject;
    function SubmitApproval(isApproved) {
        showLoader = setTimeout(function () {
            if (!$.url('isdebug'))
                initializeFlexUpdateProgress($("#approval-progress"));
            $("#approval-progress").show();
        }, 300);
        Flex.ApiClient.CommonAfeApi.SubmitApproval(workflowId, isApproved, viewModel.Comments()).then(function (success) {
            clearTimeout(showLoader);
            $("#approval-progress").hide();
            if (success) {
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
})(ApprovalHelper || (ApprovalHelper = {}));
var ApprovalViewModel = (function (_super) {
    __extends(ApprovalViewModel, _super);
    function ApprovalViewModel(approvalDetails) {
        var _this = this;
        _super.call(this);
        this.WriteOff_USD = ko.pureComputed(function () {
            var self = _this;
            var lc = self.NetWriteOff();
            return lc * self.ExchangeRate();
        }, this);
        this.RemainingBudget_USD = ko.pureComputed(function () {
            var self = _this;
            var lc = self.RemainingBudget();
            return lc * self.ExchangeRate();
        }, this);
        this.PrevAfe_LC = ko.pureComputed(function () {
            var self = _this;
            var lc = self.PreviousAfes();
            return lc / self.ExchangeRate();
        }, this);
        this.Budget_LC = ko.pureComputed(function () {
            var self = _this;
            var lc = self.Budget();
            return lc / self.ExchangeRate();
        }, this);
        this.Amount_USD = ko.pureComputed(function () {
            var self = _this;
            var lc = self.Amount();
            return lc * self.ExchangeRate();
        }, this);
        this.Comments = ko.observable("");
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
    return ApprovalViewModel;
}(Aci.Flex.Plugins.AnsellAfe.Server.Objects.ApprovalAfeDetails));
//# sourceMappingURL=afe-approval.js.map