var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var Validator = (function () {
    function Validator() {
        this._isValid = ko.observable(false);
        this.fieldValidity = {};
        this.IsValid = ko.computed({
            read: function () {
                return this._isValid();
            },
            write: function (value) {
                this._isValid(value);
            },
            owner: this
        });
    }
    Validator.prototype.revalidate = function () {
        var self = this;
        for (var field in self.fieldValidity) {
            if (!self.fieldValidity[field]) {
                self.IsValid(false);
                return;
            }
        }
        self.IsValid(true);
    };
    return Validator;
}());
var AfeSearchValidator = (function (_super) {
    __extends(AfeSearchValidator, _super);
    function AfeSearchValidator(searchString) {
        _super.call(this);
        var self = this;
        self.fieldValidity["searchString"] = false;
        self.revalidate();
        searchString.subscribe(function (newValue) {
            self.fieldValidity["searchString"] = newValue.length > 0;
            self.revalidate();
        });
    }
    return AfeSearchValidator;
}(Validator));
//# sourceMappingURL=validator.js.map