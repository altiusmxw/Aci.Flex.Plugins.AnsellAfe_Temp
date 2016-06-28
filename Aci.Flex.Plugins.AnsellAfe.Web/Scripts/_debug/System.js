var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var System;
(function (System) {
    var Guid = (function () {
        function Guid(id) {
            this.id = id.toLowerCase();
        }
        Guid.empty = function () {
            return Guid.emptyGuid;
        };
        Guid.emptyId = function () {
            return Guid.emptyGuid.id;
        };
        Guid.newGuid = function () {
            return new Guid(Guid.s4() + Guid.s4() + '-' + Guid.s4() + '-' + Guid.s4() + '-' + Guid.s4() + '-' + Guid.s4() + Guid.s4() + Guid.s4());
        };
        Guid.regex = function (format) {
            switch (format) {
                case 'x':
                case 'X':
                    return (/\{[a-z0-9]{8}(?:-[a-z0-9]{4}){3}-[a-z0-9]{12}\}/i);
                default:
                    return (/[a-z0-9]{8}(?:-[a-z0-9]{4}){3}-[a-z0-9]{12}/i);
            }
        };
        Guid.s4 = function () {
            return Math.floor((1 + Math.random()) * 0x10000).toString(16).substring(1);
        };
        Guid.prototype.toString = function (format) {
            switch (format) {
                case "x":
                case "X":
                    return "{" + this.id + "}";
                default:
                    return this.id;
            }
        };
        Guid.prototype.valueOf = function () {
            return this.id;
        };
        Guid.emptyGuid = new Guid("00000000-0000-0000-0000-000000000000");
        return Guid;
    })();
    System.Guid = Guid;
    var Tuple = (function () {
        function Tuple(item1, item2) {
            this.Item1 = item1;
            this.Item2 = item2;
        }
        return Tuple;
    })();
    System.Tuple = Tuple;
    var StringTuple = (function (_super) {
        __extends(StringTuple, _super);
        function StringTuple(item1, item2) {
            _super.call(this, item1, item2);
        }
        return StringTuple;
    })(Tuple);
    System.StringTuple = StringTuple;
})(System || (System = {}));
var LiteEvent = (function () {
    function LiteEvent() {
        this.handlers = [];
    }
    LiteEvent.prototype.on = function (handler) {
        this.handlers.push(handler);
    };
    LiteEvent.prototype.off = function (handler) {
        this.handlers = this.handlers.filter(function (h) { return h !== handler; });
    };
    LiteEvent.prototype.trigger = function (data) {
        if (this.handlers) {
            this.handlers.slice(0).forEach(function (h) { return h(data); });
        }
    };
    return LiteEvent;
})();
//# sourceMappingURL=System.js.map