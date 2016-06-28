var Deformifier = (function () {
    function Deformifier() {
    }
    Deformifier.prototype.deformify = function (container) {
        var inputsToDeform;

        if (container) {
            inputsToDeform = container.find("[data-deformify]");
        } else {
            inputsToDeform = $("[data-deformify]");
        }

        for (var i = 0; i < inputsToDeform.length; i++) {
            var inputToDeform = $(inputsToDeform[i]);
            var options = this.buildOptionsArray(inputToDeform);
            var bindingText = this.parseBindingText(inputToDeform);

            this.buildDeformedElement(inputToDeform, bindingText, options);
        }
    };

    Deformifier.prototype.buildOptionsArray = function (inputToDeform) {
        var options = [];
        var optionsString = inputToDeform.data('deformify-options');

        if (optionsString) {
            var opts = optionsString.split(',');

            opts.forEach(function (opt) {
                var optionDetails = opt.split(':');
                if (optionDetails.length == 2) {
                    options.push(new System.Tuple(optionDetails[0].replace(/ /g, ""), optionDetails[1].replace(/ /g, "")));
                }
            });
        }

        return options;
    };

    Deformifier.prototype.parseCssClass = function (options) {
        var classString = "";

        options.forEach(function (opt) {
            if (opt.Item1 == "class") {
                classString = opt.Item2;
                return false;
            }
        });

        return classString;
    };

    Deformifier.prototype.parseBindingText = function (inputToDeform) {
        var bindingText = inputToDeform.data('deformify');

        if (bindingText == "_inherit_") {
            var bindAttribute = inputToDeform.data("bind");
            var bindValue = bindAttribute.split(':');
            bindingText = bindValue[1];
        }

        return bindingText;
    };

    Deformifier.prototype.buildDeformedElement = function (inputToDeform, bindingText, options) {
        var classString = this.parseCssClass(options);
        if (classString.length == 0)
            classString = "''";
        inputToDeform.replaceWith("<div class=" + classString + " data-bind=\"html: " + bindingText + "\"></div>");
    };
    return Deformifier;
})();
//# sourceMappingURL=deformifier.js.map
