var Aci;
(function (Aci) {
    var Flex;
    (function (Flex) {
        var Portal;
        (function (Portal) {
            var ServiceHelper;
            (function (ServiceHelper) {
                function PostData(url, payload) {
                    var deferred = Q.defer();
                    $.ajax({
                        type: "POST",
                        contentType: "application/json; charset=utf-8",
                        url: url,
                        data: payload,
                        dataType: "json",
                        success: function (response) {
                            deferred.resolve(response);
                        },
                        error: function (jqXHR, textStatus, errorThrown) {
                            deferred.reject(textStatus);
                        }
                    });
                    return deferred.promise;
                }
                ServiceHelper.PostData = PostData;
                function PostDataArray(url, payload) {
                    var deferred = Q.defer();
                    $.ajax({
                        type: "POST",
                        contentType: "application/json; charset=utf-8",
                        url: url,
                        data: payload,
                        dataType: "json",
                        success: function (response) {
                            var array = new Array();
                            if (response == null) {
                                return array;
                            }
                            $.each(response, function (index, value) {
                                var v = ko.mapping.fromJS(value);
                                array.push(v);
                            });
                            deferred.resolve(array);
                        },
                        error: function (jqXHR, textStatus, errorThrown) {
                            deferred.reject(textStatus);
                        }
                    });
                    return deferred.promise;
                }
                ServiceHelper.PostDataArray = PostDataArray;
                function GetData(url, mapping, koMap) {
                    var deferred = Q.defer();
                    $.ajax({
                        type: "GET",
                        url: url,
                        cache: false,
                        success: function (response) {
                            if (response == null) {
                                deferred.reject("null response");
                            }
                            else if (response === true || response === false) {
                                deferred.resolve(response);
                            }
                            else {
                                if (koMap) {
                                    var mapped = ko.mapping.fromJS(response, mapping);
                                    deferred.resolve(mapped);
                                }
                                else {
                                    deferred.resolve(response);
                                }
                            }
                        },
                        error: function (jqXHR, textStatus, errorThrown) {
                            deferred.reject(errorThrown);
                        }
                    });
                    return deferred.promise;
                }
                ServiceHelper.GetData = GetData;
                function GetMapping(typeName) {
                    if (typeName === "Aci.Flex.Server.ObjectModel.UserHierarchyRoleInfo") {
                        return {
                            "HierarchyRole": {
                                create: function (options) {
                                    return ko.observable(ko.mapping.fromJS(options.data));
                                }
                            },
                            "Role": {
                                create: function (options) {
                                    return ko.observable(ko.mapping.fromJS(options.data));
                                }
                            },
                            "Entity": {
                                create: function (options) {
                                    return ko.observable(ko.mapping.fromJS(options.data));
                                }
                            }
                        };
                    }
                    return {};
                }
                ServiceHelper.GetMapping = GetMapping;
                function GetArrayData(url, typeHint) {
                    var deferred = Q.defer();
                    $.ajax({
                        type: "GET",
                        url: url,
                        cache: false,
                        success: function (response) {
                            var array = new Array();
                            if (response == null) {
                                return array;
                            }
                            var type = response[0];
                            var mapping = GetMapping(typeHint);
                            $.each(response, function (index, value) {
                                var v = ko.mapping.fromJS(value, mapping);
                                array.push(v);
                            });
                            deferred.resolve(array);
                        },
                        error: function (jqXHR, textStatus, errorThrown) {
                            deferred.reject(errorThrown);
                        }
                    });
                    return deferred.promise;
                }
                ServiceHelper.GetArrayData = GetArrayData;
                function DeleteData(url, mapping, koMap) {
                    var deferred = Q.defer();
                    $.ajax({
                        type: "DELETE",
                        url: url,
                        cache: false,
                        success: function (response) {
                            if (response == null) {
                                deferred.reject("null response");
                            }
                            else if (response === true || response === false) {
                                deferred.resolve(response);
                            }
                            else {
                                if (koMap) {
                                    var mapped = ko.mapping.fromJS(response, mapping);
                                    deferred.resolve(mapped);
                                }
                                else {
                                    deferred.resolve(response);
                                }
                            }
                        },
                        error: function (jqXHR, textStatus, errorThrown) {
                            deferred.reject(errorThrown);
                        }
                    });
                    return deferred.promise;
                }
                ServiceHelper.DeleteData = DeleteData;
                function GetAssignedHierarchyRoles(userIdentifier) {
                    var baseUrl = $.url("portal");
                    var targetUrl = baseUrl + "api/core/GetAssignedHierarchyRoles?userIdentifier=" + userIdentifier;
                    var mapping = {
                        "HierarchyRole": {
                            create: function (options) {
                                return ko.observable(ko.mapping.fromJS(options.data));
                            }
                        },
                        "Role": {
                            create: function (options) {
                                return ko.observable(ko.mapping.fromJS(options.data));
                            }
                        },
                        "Entity": {
                            create: function (options) {
                                return ko.observable(ko.mapping.fromJS(options.data));
                            }
                        }
                    };
                    return GetArrayData(targetUrl, "Aci.Flex.Server.ObjectModel.UserHierarchyRoleInfo");
                }
                ServiceHelper.GetAssignedHierarchyRoles = GetAssignedHierarchyRoles;
            })(ServiceHelper = Portal.ServiceHelper || (Portal.ServiceHelper = {}));
        })(Portal = Flex.Portal || (Flex.Portal = {}));
    })(Flex = Aci.Flex || (Aci.Flex = {}));
})(Aci || (Aci = {}));
//# sourceMappingURL=ServiceHelper.js.map