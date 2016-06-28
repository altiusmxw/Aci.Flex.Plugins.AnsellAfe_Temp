$.url = function (url) {
    var lookupTable = { 'portal': '/', 'isdebug': 'true', 'signalRService': 'http://localhost:8001/services/signalr' };
    return lookupTable[url];
}

var isDebug = true;