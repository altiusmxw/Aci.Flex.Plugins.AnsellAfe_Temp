module CommonAfeHelper {
    export function getReadableDate(date: Date): string {
        if (!date)
            return "";

        //return ("0" + (date.getMonth() + 1)).slice(-2) + "/" + ("0" + date.getDate()).slice(-2) + "/" + date.getFullYear();
        return moment(date).format("YYYY MMM DD");
    }

    export function bindHandlers(): void {
        ko.bindingHandlers.totalCost = {
            update: function (element, valueAccessor) {
                var value = Math.round(ko.unwrap(valueAccessor()));
                $(element).val(value.toString());
                $(element).inputmask(
                    {
                        alias: 'numeric',
                        groupSeparator: ',',
                        autoGroup: true,
                        digits: 0,
                        digitsOptional: false,
                        placeholder: '0'
                    });
                $(element).siblings(".total-cost").text($(element).val());
            }
        };

        ko.bindingHandlers.totalWi = {
            update: function (element, valueAccessor) {
                var value = ko.unwrap(valueAccessor());
                $(element).val(value);
                $(element).inputmask('Regex', { regex: "[0-9]{0,3}\\.[0-9]{0,5}" });

                var visibleElem = $(element).siblings(".total-working-interest");
                var rndVal = +(+value).toFixed(5);

                visibleElem.text('');
                if (!isNaN(rndVal)) {
                    visibleElem.text(rndVal.toString());
                    visibleElem.parent().removeClass('text-danger');
                    if (value && rndVal > 100)
                        visibleElem.parent().addClass('text-danger');
                }
            }
        };

        ko.bindingHandlers.enable_bs = {
            update: function (element, valueAccessor) {
                var value = ko.unwrap(valueAccessor());
                var button = $(element).find('button');

                button.disable();

                if (value)
                    button.enable();
            }
        };

        ko.bindingHandlers.wi = {
            update: function (element, valueAccessor) {
                var value = ko.unwrap(valueAccessor());
                $(element).val(value);
                $(element).inputmask('Regex', { regex: "[0-9]{0,3}\\.[0-9]{0,5}" });

                var visibleElem = $(element).siblings(".total-working-interest");
                var rndVal = +(+value).toFixed(5);

                visibleElem.text(rndVal.toString());
            }
        };

        ko.bindingHandlers.allowBindings = {
            init: function (elem, valueAccessor) {
                // Let bindings proceed as normal *only if* my value is false
                var shouldAllowBindings = ko.unwrap(valueAccessor());
                return { controlsDescendantBindings: !shouldAllowBindings };
            }
        };
    }
}