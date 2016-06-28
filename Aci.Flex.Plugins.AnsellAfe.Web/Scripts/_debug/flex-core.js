$.holdReady(true);
$.getScript($.url("signalRService") + "/hubs", function () {
    $.holdReady(false);
});
$(function () {
    $.fn.pixels = function (property) {
        var prop = this.css(property);
        if (!prop) {
            return 0;
        }
        return parseInt(prop.slice(0, -2), 10);
    };
    $.fn.enable = function () {
        this.removeAttr("disabled");
    };
    $.fn.disable = function () {
        this.attr("disabled", "disabled");
    };
    if ($.fn.bootstrapValidator) {
        $.fn.bootstrapValidator.DEFAULT_OPTIONS = $.extend({}, $.fn.bootstrapValidator.DEFAULT_OPTIONS, {
            container: "tooltip",
            feedbackIcons: {
                required: "fa fa-asterisk",
                valid: "fa fa-check",
                invalid: "fa fa-times",
                validating: "fa fa-refresh"
            }
        });
    }
    //initializeSignalR();
    //initializeSearch();
});
function initializeSignalR() {
    var messageCountCookieName = "messageCount";
    if ($.connection == null) {
        return;
    }
    $.connection.hub.url = $.url("signalRService");
    $.connection.hub.logging = true;
    var messageHubProxy = $.connection.signalRDelivery;
    messageHubProxy.client.newInfoMessage = function (title, message, onclick) {
        var growl = {
            class_name: "info",
            // (string | mandatory) the heading of the notification
            title: "<i class='fa fa-info-circle'></i> " + title,
            // (string | mandatory) the text inside the notification
            text: message,
            on_click: ""
        };
        if (onclick) {
            growl.on_click = onclick;
        }
        $.gritter.add(growl);
    };
    $.connection.hub.error(function (error) {
        console.log("SignalR error: " + error);
    });
    if ($.loc != null) {
        $.connection.hub.qs = { "userId": $.loc("UserId") };
    }
    $.connection.hub.start();
    var count = $.cookie(messageCountCookieName);
    if (!count) {
        $.ajax({
            type: "GET",
            contentType: "application/json; charset=utf-8",
            url: $.url("portal") + "api/Notification/UnreadInboxMessageCount",
            dataType: "json",
            success: function (response) {
                $.cookie(messageCountCookieName, response, { path: "/" });
                setMessageCount(response);
            }
        });
    }
    else {
        setMessageCount(count);
    }
    messageHubProxy.client.messageCountChange = function (count) {
        $.cookie(messageCountCookieName, count, { path: "/" });
        setMessageCount(count);
    };
    messageHubProxy.client.avatarChanged = function (userIdentifier, cacheStamp) {
        var imgSrc = $.url("portal") + "handlers/avatarhandler.ashx?userIdentifier=" + userIdentifier + "&cv=" + cacheStamp;
        $(".avatar").attr("src", imgSrc);
        $(".dropdown-avatar").attr("src", imgSrc);
    };
}
function initializeSearch() {
    var searchUrl = $.url("portal") + "/api/core/search?query=%QUERY";
    var searcher = new Bloodhound({
        datumTokenizer: Bloodhound.tokenizers.obj.whitespace("value"),
        queryTokenizer: Bloodhound.tokenizers.whitespace,
        remote: searchUrl
    });
    var searchItemSelected = function (event, suggestion, dataset) {
        window.location = $.url("portal") + suggestion.RelativeUrl;
    };
    searcher.initialize();
    $("#searchBox").typeahead(null, {
        name: "flexSearch",
        displayKey: "DisplayText",
        source: searcher.ttAdapter(),
        hint: false
    });
    $("#searchBox").bind({ "typeahead:selected": searchItemSelected });
}
function setMessageCount(count) {
    $("[id$='lblMessageCountBadge']").text(count);
    $("[id$='lblMessageCountLabel']").text(count);
}
function changeModel(modelIdentifier) {
    var url = $.url("portal") + "Account/SignIn?modelIdentifier=" + modelIdentifier;
    window.location.assign(url);
    //Aci.Flex.Portal.ModelNavigationControllerClient.ChangeModel(modelIdentifier)
    //    .then(
    //    (r) => {
    //        if (r) {
    //            window.location = $.url("portal");
    //        } else {
    //            alert("Failed to change model.");
    //        }
    //    });
    //$.ajax({
    //    type: "GET",
    //    contentType: "application/json; charset=utf-8",
    //    url: $.url("portal") + "api/modelnavigation/changemodel/" + modelIdentifier,
    //    dataType: "json",
    //    success: function (response) {
    //        if (response)
    //            window.location = $.url("portal");
    //        else
    //            alert("Failed to change model.");
    //    },
    //    error: function (jqXHR, textStatus, errorThrown) {
    //        alert(errorThrown);
    //    }
    //});
}
function getQueryStrings() {
    var vars = [], hash;
    var queryString = document.URL.split("?")[1];
    if (queryString !== undefined) {
        var queryStringParts = queryString.split("&");
        for (var i = 0; i < queryStringParts.length; i++) {
            hash = queryStringParts[i].split("=");
            var value = hash.length <= 1 ? hash[0] : hash[1];
            vars.push(value);
            vars[hash[0]] = value;
        }
    }
    return vars;
}
function swConfirm(message, callback) {
    swal({
        title: 'Are you sure?',
        text: message,
        type: "warning",
        showCancelButton: true
    }, function (confirmed) {
        if (callback) {
            callback(confirmed);
        }
    });
}
var Flex;
(function (Flex) {
    var Utils;
    (function (Utils) {
        function allTrue(values) {
            return values.every(function (v) {
                return v;
            });
        }
        Utils.allTrue = allTrue;
        function allPromisesTrue(promises) {
            return Q.all(promises).then(function (resolved) {
                return allTrue(resolved);
            }, function (error) {
                return false;
            });
        }
        Utils.allPromisesTrue = allPromisesTrue;
        function join(u1, v1, predicate, selector) {
            var result = [];
            u1 = u1 || [];
            v1 = v1 || [];
            for (var i = 0, j = u1.length; i < j; i++) {
                for (var ii = 0, jj = v1.length; ii < jj; ii++) {
                    var uu = u1[i];
                    var vv = v1[ii];
                    if (predicate(uu, vv)) {
                        result.push(selector(uu, vv));
                    }
                }
            }
            return result;
        }
        Utils.join = join;
        function formatNumberAsCurrency(valueToBeFormatted, decimalPlaces, decimalSeparator, thousandSeparator) {
            decimalPlaces = isNaN(decimalPlaces = Math.abs(decimalPlaces)) ? 2 : decimalPlaces;
            decimalSeparator = decimalSeparator == undefined ? "." : decimalSeparator;
            thousandSeparator = thousandSeparator == undefined ? "," : thousandSeparator;
            var s = valueToBeFormatted < 0 ? "-" : "";
            var i = valueToBeFormatted.toFixed(decimalPlaces) + "";
            var j = (j = i.length) > 3 ? j % 3 : 0;
            return s + (j ? i.substr(0, j) + thousandSeparator : "") + i.substr(j).replace(/(\d{3})(?=\d)/g, "$1" + thousandSeparator);
        }
        Utils.formatNumberAsCurrency = formatNumberAsCurrency;
    })(Utils = Flex.Utils || (Flex.Utils = {}));
})(Flex || (Flex = {}));
//# sourceMappingURL=flex-core.js.map