class MoneyView {
    constructor(value: number) {
        this.Text(value.toString());
    }

    private _text = ko.observable<string>();

    Value = ko.observable<number>();

    Text = ko.computed<string>({
        read: function () {
            return this._text();
        },
        write: function (value) {
            this._text(value);
            var t = value.replace("$", "").replace(/,/g, "");
            var v = t.length == 0 ? "0" : t;
            this.Value(parseFloat(v));
        },
        owner: this
    });
}