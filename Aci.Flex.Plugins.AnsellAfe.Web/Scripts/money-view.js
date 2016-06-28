var MoneyView = (function () {
    function MoneyView(value) {
        this._text = ko.observable();
        this.Value = ko.observable();
        this.Text = ko.computed({
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
        this.Text(value.toString());
    }
    return MoneyView;
}());
//# sourceMappingURL=money-view.js.map