var Attachments = (function () {
    function Attachments() {
        var self = this;
        this.workflowAttachments = ko.observableArray([]);
        this.workflowInstanceId = ko.observable("");
        ko.applyBindings(self, $("#attachment-binding-container")[0]);
    }
    Attachments.prototype.loadWorkflowAttachments = function (workflowId) {
        var self = this;
        self.workflowInstanceId(ko.unwrap(workflowId));
        self.bindFileUpload(self.workflowInstanceId());
        return self.rebind();
    };
    Attachments.prototype.getDownloadLink = function (storageItem) {
        return $.url('portal') + "handlers/storageitemdownloadhandler.ashx?storageItemId=" + storageItem.FlexIdentifier();
    };
    Attachments.prototype.bindFileUpload = function (workflowIdentifier) {
        var self = this;
        $('.fileupload').fileupload({
            url: $.url("portal") + "api/core/CreateWorkflowStorageItems",
            autoUpload: true,
            dataType: 'json',
            maxNumberOfFiles: 2,
            getNumberOfFiles: function () { return 1; }
        }).on("fileuploadsubmit", function (e, data) {
            data.formData = {
                workflowIdentifier: workflowIdentifier,
                isTemporary: true
            };
        }).on('fileuploadfail', function (e, data) {
            alert(data.textStatus);
        }).on('fileuploaddone', function (e, data) {
            self.rebind();
        });
    };
    Attachments.prototype.deleteAttachment = function (storageItem) {
        var self = this;
        swal({ title: "Are you sure?", text: "You will not be able to recover this file!", type: "warning", showCancelButton: true, confirmButtonColor: "#DD6B55", confirmButtonText: "Yes, delete it!", closeOnConfirm: true }, function () {
            Aci.Flex.Portal.CoreControllerClient.DeleteStorageItem(storageItem.FlexIdentifier()).then(function () {
                self.rebind();
            });
        });
    };
    Attachments.prototype.rebind = function () {
        var self = this;
        var deferred = Q.defer();
        self.workflowAttachments.removeAll();
        Aci.Flex.Portal.CoreControllerClient.ResolveGetWorkflowStorageItems(self.workflowInstanceId(), self.workflowAttachments).then(function (loaded) {
            return deferred.resolve(loaded);
        });
        return deferred.promise;
    };
    return Attachments;
})();
//# sourceMappingURL=flex-attachments.js.map