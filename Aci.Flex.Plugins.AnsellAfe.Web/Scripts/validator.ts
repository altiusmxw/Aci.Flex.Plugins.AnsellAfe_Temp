class Validator {
    private _isValid: KnockoutObservable<boolean> = ko.observable<boolean>(false);
    fieldValidity: { [field: string]: boolean } = {}

    IsValid = ko.computed<boolean>({
        read: function () {
            return this._isValid();
        },
        write: function (value) {
            this._isValid(value);
        },
        owner: this
    });

    revalidate() {
        var self = this;

        for (var field in self.fieldValidity) {
            if (!self.fieldValidity[field]) {
                self.IsValid(false);
                return;
            }
        }

        self.IsValid(true);
    }
}

class AfeSearchValidator extends Validator {
    constructor(searchString: KnockoutObservable<string>) {
        super();
        var self = this;

        self.fieldValidity["searchString"] = false;

        self.revalidate();

        searchString.subscribe((newValue) => {
            self.fieldValidity["searchString"] = newValue.length > 0;
            self.revalidate();
        });
    }
}