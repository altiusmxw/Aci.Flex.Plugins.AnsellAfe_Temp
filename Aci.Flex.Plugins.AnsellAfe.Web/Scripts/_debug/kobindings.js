// Data tables binding

function getDataTable(elem) {
    return $(elem).closest("table").DataTable();
}

function refreshDataTable(elem) {
    getDataTable(elem).destroy();
    getDataTable(elem);
}

function addRow(elem) {
    var dt = getDataTable(elem);
    dt.row.add(elem);
    refreshDataTable(elem);
}

function removeRow(elem) {
    var dt = getDataTable(elem);
    var parent = $(elem).parent()
    dt.row(elem).remove();
    refreshDataTable(parent);
}

function afterRender(elements, data) {
    if (elements.length === 0) return;

    elements.forEach(function (elem) {
        if (elem.nodeName && elem.nodeName.toLowerCase() === 'tr') {
            addRow(elem);
        }
    })
}

function afterAdd(elem, index, data) {
    if (elem.nodeName && elem.nodeName.toLowerCase() === 'tr') {
        addRow(elem);
    }
}

function beforeRemove(elem, index, data) {
    if (elem.nodeName && elem.nodeName.toLowerCase() === 'tr') {
        removeRow(elem);
    }
}

ko.bindingHandlers.datatable = {
    accessorMod: function (element, valueAccessor, allBindings, viewModel, bindingContext) {
        var ret = valueAccessor();

        return function () {
            return {
                data: ret.data ? ret.data : ret,
                afterAdd: function (elem, index, data) {
                    afterAdd.call(this, elem, index, data, element);
                    if (ret.afterAdd) {
                        ret.afterAdd.call(this, elem, index, data);
                    }
                },
                beforeRemove: function (elem, index, data) {
                    beforeRemove.call(this, elem, index, data, element);
                    if (ret.beforeRemove) {
                        ret.beforeRemove.call(this, elem, index, data);
                    }
                },
                afterRender: function (elements, data) {
                    afterRender.call(this, elements, data, element);
                    if (ret.afterRender) {
                        ret.afterRender.call(this, elements, data);
                    }
                },
            };
        };
    },

    init: function (element, valueAccessor, allBindings, viewModel, bindingContext) {
        var nodes = Array.prototype.slice.call(element.childNodes, 0);
        ko.utils.arrayForEach(nodes, function (node) {
            if (node && node.nodeType !== 1) {
                node.parentNode.removeChild(node);
            }
        });

        valueAccessor = ko.bindingHandlers.datatable.accessorMod(element, valueAccessor, allBindings, viewModel, bindingContext);
        return ko.bindingHandlers.foreach.init.call(this, element, valueAccessor, allBindings, viewModel, bindingContext);
    },

    update: function (element, valueAccessor, allBindings, viewModel, bindingContext) {
        valueAccessor = ko.bindingHandlers.datatable.accessorMod(element, valueAccessor, allBindings, viewModel, bindingContext);
        return ko.bindingHandlers.foreach.update.apply(this, arguments);
    }
};

// End datatables binding

ko.bindingHandlers.selectPickerOptions = {
    init: function (element, valueAccessor, allBindingsAccessor) {
        var selectPickerOptions = allBindingsAccessor().selectPickerOptions;
        if (typeof selectPickerOptions !== 'undefined' && selectPickerOptions !== null) {
            var options = selectPickerOptions.optionsArray;
            if (!ko.isObservable(options))
                options = ko.observable(options);
            ko.bindingHandlers.options.init(element, options, allBindingsAccessor);
        }
    },
    update: function (element, valueAccessor, allBindingsAccessor) {
        var hasDisabledAttr = false;
        if ($(element).attr('disabled'))
            hasDisabledAttr = true;

        var selectPickerOptions = allBindingsAccessor().selectPickerOptions;
        if (typeof selectPickerOptions !== 'undefined' && selectPickerOptions !== null) {
            var options = selectPickerOptions.optionsArray,
                optionsText = selectPickerOptions.optionsText,
                optionsValue = selectPickerOptions.optionsValue,
                optionsCaption = selectPickerOptions.optionsCaption,
                isDisabled = selectPickerOptions.disabledCondition || hasDisabledAttr || false,
                resetOnDisabled = selectPickerOptions.resetOnDisabled || false;
            if (!ko.isObservable(options))
                options = ko.observable(options);
            //if (ko.utils.unwrapObservable(options).length > 0) {
            // call the default Knockout options binding
            ko.bindingHandlers.options.update(element, options, allBindingsAccessor);
            //}
            if (isDisabled && resetOnDisabled) {
                // the dropdown is disabled and we need to reset it to its first option
                $(element).selectpicker('val', $(element).children('option:first').val());
            }
            $(element).prop('disabled', isDisabled);
        }
    }
}

ko.bindingHandlers.selectPicker = {
    init: function (element, valueAccessor, allBindingsAccessor) {
        if ($(element).is('select')) {
            if (ko.isObservable(valueAccessor())) {
                if ($(element).prop('multiple') && $.isArray(ko.utils.unwrapObservable(valueAccessor()))) {
                    // in the case of a multiple select where the valueAccessor() is an observableArray, call the default Knockout selectedOptions binding
                    ko.bindingHandlers.selectedOptions.init(element, valueAccessor, allBindingsAccessor);
                } else {
                    // regular select and observable so call the default value binding
                    ko.bindingHandlers.value.init(element, valueAccessor, allBindingsAccessor);
                }
            }
            $(element).addClass('selectpicker').selectpicker();
        }
    },
    update: function (element, valueAccessor, allBindingsAccessor) {
        if ($(element).is('select')) {
            var hasDisabledAttr = false;
            if ($(element).attr('disabled'))
                hasDisabledAttr = true;

            var selectPickerOptions = allBindingsAccessor().selectPickerOptions;
            if (typeof selectPickerOptions !== 'undefined' && selectPickerOptions !== null) {
                var options = selectPickerOptions.optionsArray,
                    optionsText = selectPickerOptions.optionsText,
                    optionsValue = selectPickerOptions.optionsValue,
                    optionsCaption = selectPickerOptions.optionsCaption,
                    isDisabled = selectPickerOptions.disabledCondition || hasDisabledAttr || false,
                    resetOnDisabled = selectPickerOptions.resetOnDisabled || false;
                if (!ko.isObservable(options))
                    options = ko.observable(options);
                //if (ko.utils.unwrapObservable(options).length > 0) {
                // call the default Knockout options binding
                ko.bindingHandlers.options.update(element, options, allBindingsAccessor);
                //}
                if (isDisabled && resetOnDisabled) {
                    // the dropdown is disabled and we need to reset it to its first option
                    $(element).selectpicker('val', $(element).children('option:first').val());
                }
                $(element).prop('disabled', isDisabled);
            }
            if (ko.isObservable(valueAccessor())) {
                if ($(element).prop('multiple') && $.isArray(ko.utils.unwrapObservable(valueAccessor()))) {
                    // in the case of a multiple select where the valueAccessor() is an observableArray, call the default Knockout selectedOptions binding
                    ko.bindingHandlers.selectedOptions.update(element, valueAccessor);
                } else {
                    // call the default Knockout value binding
                    ko.bindingHandlers.value.update(element, valueAccessor);
                }
            }

            $(element).selectpicker('refresh');
        }
    }
};

ko.bindingHandlers.showModal = {
    init: function (element, valueAccessor) {
        return;
    },
    update: function (element, valueAccessor) {
        var value = valueAccessor();
        if (ko.utils.unwrapObservable(value)) {
            $(element).modal("show");
            // this is to focus input field inside dialog
            $("input", element).focus();
        } else {
            $(element).modal("hide");
        }
    }
};


ko.bindingHandlers.bootstrapSwitchOn = {
    init: function (element, valueAccessor, allBindingsAccessor, viewModel) {

        var switchElement = $(element);

        var value = valueAccessor();

        var unwrappedValue = ko.utils.unwrapObservable(value);

        switchElement.bootstrapSwitch();

        switchElement.bootstrapSwitch('state', unwrappedValue); // Set intial state


        switchElement.on('switchChange.bootstrapSwitch', function (e, data) {
            value(data);
        }); // Update the model when changed.
    },
    update: function (element, valueAccessor, allBindingsAccessor, viewModel) {
        var vStatus = $(element).bootstrapSwitch('state');
        var vmStatus = ko.utils.unwrapObservable(valueAccessor());

        if (vStatus != vmStatus) {
            $(element).bootstrapSwitch('state', vmStatus);
        }
    }
};

ko.bindingHandlers.cost = {
    init: function (element, valueAccessor, allBindingAccessor, viewModel, context) {
        var value = valueAccessor();
        ko.bindingHandlers.value.init(element, valueAccessor, allBindingAccessor, viewModel, context);
        $(element).inputmask(
            {
                alias: 'numeric',
                groupSeparator: ',',
                autoGroup: true,
                digits: 0,
                digitsOptional: false,
                placeholder: '0',
                allowNegative: true
            });
    }
};

ko.bindingHandlers.bindIframe = {
    init: function (element, valueAccessor) {
        function bindIframe() {
            try {
                var iframeInit = element.contentWindow.initChildFrame,
                    iframedoc = element.contentDocument.body;
            } catch (e) {
                // ignored
            }
            if (iframeInit)
                iframeInit(ko, valueAccessor());
            else if (iframedoc) {
                var span = document.createElement('span');
                span.setAttribute('data-bind', 'text: someProperty');
                iframedoc.appendChild(span);
                ko.applyBindings(valueAccessor(), iframedoc);
            }
        };
        bindIframe();
        ko.utils.registerEventHandler(element, 'load', bindIframe);
    }
};


/**
 * @summary     Datatables Custom Binding for Knockout.js
 * @description Allows Datatables to work with Knockout.js
 * @version     0
 * @file        knockout-datatables.js
 * @author      Chad Mullins
 * @originalSrc    https://github.com/CogShift/Knockout.Extensions
 *
 * This source file is free software, under either the GPL v2 license or a
 * BSD style license, available at:
 *   http://datatables.net/license_gpl2
 *   http://datatables.net/license_bsd
 * 
 * This source file is distributed in the hope that it will be useful, but 
 * WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY 
 * or FITNESS FOR A PARTICULAR PURPOSE. See the license files for details.
 * 
 * For details please refer to: http://www.datatables.net
 */

/*jslint sloppy: true, white: true, vars: true, nomen: true, eqeq: true, browser: true, plusplus: true */
/*globals $, jQuery, isInitialisedKey, ko*/

ko.bindingHandlers.dataTable = {
    'init': function (element, valueAccessor, allBindingsAccessor, viewModel, bindingContext) {

        "use strict";

        var binding, isInitialisedKey, options, theIndex, dataSource, dataTable, unwrappedItems, destRow, columnName, accesor;

        if ($.data(element, isInitialisedKey) === true) {
            return;
        }

        binding = ko.utils.unwrapObservable(valueAccessor());
        isInitialisedKey = "ko.bindingHandlers.dataTable.isInitialised";
        options = {};

        // ** Initialise the DataTables options object with the data-bind settings **

        // Clone the options object found in the data bindings.  This object will form the base for the DataTable initialisation object.
        if (binding.options) {
            options = $.extend(options, binding.options);
        }
        // Define the tables columns.
        if (binding.columns && binding.columns.length) {
            options.aoColumns = [];
            ko.utils.arrayForEach(binding.columns, function (col) {
                options.aoColumns.push({ mDataProp: col });

            });
        }

        // Define column data attributes
        if (binding.columns && binding.columns.length) {
            options.aoColumns = [];
            ko.utils.arrayForEach(binding.columns, function (col) {

                options.aoColumns.push({ mDataProp: col.name });

                theIndex = binding.columns.indexOf(col);

                if (col.dataSort) {
                    options.aoColumns[theIndex].iDataSort = col.dataSort;
                }

                if (col.sortType) {
                    options.aoColumns[theIndex].sType = col.sortType;
                }

                if (col.sortable === false) {
                    options.aoColumns[theIndex].bSortable = col.sortable;
                }

                if (col.visible === false) {
                    options.aoColumns[theIndex].bVisible = col.visible;
                }

            });
        }

        if (binding.sortingFixed && binding.sortingFixed.length) {
            options.aaSortingFixed = [];
            ko.utils.arrayForEach(binding.sortingFixed, function (item) {
                options.aaSortingFixed.push(
                    [item.column, item.direction]
                );

            });
        }

        if (binding.initialSortColumn) {
            options.aaSortingFixed = [[binding.initialSortColumn, 'asc']];
        }

        if (binding.autoWidth) {
            options.bAutoWidth = binding.autoWidth;
        } else {
            options.bAutoWidth = false;
        }

        if (binding.sDom) {
            options.sDom = binding.sDom;
        }

        if (binding.iDisplayLength) {
            options.iDisplayLength = binding.iDisplayLength;
        }

        if (binding.sPaginationType) {
            options.sPaginationType = binding.sPaginationType;
        }

        if (binding.bPaginate) {
            options.bPaginate = binding.bPaginate;
        }

        if (binding.oLanguage) {
            options.oLanguage = binding.oLanguage;
        }

        // Register the row template to be used with the DataTable.
        if (binding.rowTemplate && binding.rowTemplate !== '') {
            options.fnRowCallback = function (row, data, displayIndex, displayIndexFull) {
                // Render the row template for this row.
                ko.renderTemplate(binding.rowTemplate, data, null, row, "replaceChildren");
                return row;
            };
        }

        // Set the data source of the DataTable.
        if (binding.dataSource) {

            dataSource = ko.utils.unwrapObservable(binding.dataSource);

            if (dataSource instanceof Array) {
                // Set the initial datasource of the table.
                options.aaData = ko.utils.unwrapObservable(binding.dataSource);

                // If the data source is a knockout observable array...
                if (ko.isObservable(binding.dataSource)) {
                    // Subscribe to the dataSource observable.  This callback will fire whenever items are added to 
                    // and removed from the data source.
                    binding.dataSource.subscribe(function (newItems) {
                        // ** Redraw table **
                        dataTable = $(element).dataTable();
                        // Get a list of rows in the DataTable.
                        var tableNodes = dataTable.fnGetNodes();

                        // If the table contains rows...
                        if (tableNodes.length) {
                            // Unregister each of the table rows from knockout.
                            ko.utils.arrayForEach(tableNodes, function (node) { ko.cleanNode(node); });
                            // Clear the datatable of rows.
                            dataTable.fnClearTable();
                        }

                        // Unwrap the items in the data source if required.
                        unwrappedItems = [];
                        ko.utils.arrayForEach(newItems, function (item) {
                            dataTable.fnAddData(ko.utils.unwrapObservable(item));
                        });
                    });
                }

            } else { // If the dataSource was not a function that retrieves data, or a javascript object array containing data.
                throw 'The dataSource defined must a javascript object array';
            }
        }

        // If no fnRowCallback has been registered in the DataTable's options, then register the default fnRowCallback.
        // This default fnRowCallback function is called for every row in the data source.  The intention of this callback
        // is to build a table row that is bound it's associated record in the data source via knockout js.
        if (!options.fnRowCallback) {
            options.fnRowCallback = function (row, srcData, displayIndex, displayIndexFull) {
                var columns = this.fnSettings().aoColumns;

                // Empty the row that has been build by the DataTable of any child elements.
                destRow = $(row);
                destRow.empty();

                // For each column in the data table...
                ko.utils.arrayForEach(columns, function (column) {

                    var newCell, accesor;

                    columnName = column.mDataProp;

                    newCell = $("<td></td>");

                    // bind the cell to the observable in the current data row.
                    accesor = eval("srcData['" + columnName.replace(".", "']['") + "']");

                    destRow.append(newCell);
                    if (columnName === 'action') {
                        ko.applyBindingsToNode(newCell[0], { html: accesor }, srcData);
                    } else {
                        ko.applyBindingsToNode(newCell[0], { text: accesor }, srcData);
                    }
                });

                return destRow[0];
            };
        }

        // If no fnDrawCallback has been registered in the DataTable's options, then register the default here. 
        // This default callback is called every time the table is drawn (for example, when the pagination is clicked). 

        if (!options.fnDrawCallback) {

            options.fnDrawCallback = function () {

                /*
                // There are some assumptions here that need to be better abstracted
                $(binding.expandIcon).click(function(){
                    var theRow = $(this).parent().parent()[0]; //defined by the relationship between the clickable expand icon and the row. assumes that the icon (the trigger) is in a td which is in a tr. 
                    rowContent = $(theRow).find(".hiddenRow").html();
                    
                    tableId = local[binding.gridId];
                    
                    if(tableId.fnIsOpen(theRow)){
                        $(this).removeClass('icon-contract '+binding.expandIcon);
                        $(this).addClass('icon-expand '+binding.expandIcon);
                        tableId.fnClose(theRow);
                    }else{
                        $(this).removeClass('icon-expand '+binding.expandIcon);
                        $(this).addClass('icon-contract ' +binding.expandIcon);
                        tableId.fnOpen(theRow, rowContent, 'info_row');
                    }
                });
                */

                if (binding.tooltip) {
                    if (binding.tooltip[0]) {
                        // bootstrap tooltip definition
                        $("[rel=" + binding.tooltip[1] + "]").tooltip({
                            placement: 'top',
                            trigger: 'hover',
                            animation: true,
                            delay: {
                                show: 1000,
                                hide: 10
                            }
                        });
                    }
                }
            };

        }

        binding.gridId = $(element).dataTable(options);

        $.data(element, isInitialisedKey, true);

        // Tell knockout that the control rendered by this binding is capable of managing the binding of it's descendent elements.
        // This is crutial, otherwise knockout will attempt to rebind elements that have been printed by the row template.
        return { controlsDescendantBindings: true };

    },

    convertDataCriteria: function (srcOptions) {

        var i, j, getColIndex, destOptions, optionsLen;

        getColIndex = function (name) {
            var matches = name.match("\\d+");

            if (matches && matches.length) {
                return matches[0];
            }
            return null;
        };

        destOptions = { Columns: [] };
        optionsLen = srcOptions.length;
        // Figure out how many columns in in the data table.
        for (i = 0; i < optionsLen ; i++) {
            if (srcOptions[i].name == "iColumns") {
                for (j = 0; j < srcOptions[i].value; j++) {
                    destOptions.Columns.push({});
                }
                break;
            }
        }

        ko.utils.arrayForEach(srcOptions, function (item) {

            var colIndex = getColIndex(item.name), cog;

            if (item.name == "iDisplayStart") {
                destOptions.RecordsToSkip = item.value;
            } else if (item.name == "iDisplayLength") {
                destOptions.RecordsToTake = item.value;
            } else if (item.name == "sSearch") {
                destOptions.GlobalSearchText = item.value;
            } else if (cog.string.startsWith(item.name, "bSearchable_")) {
                destOptions.Columns[colIndex].IsSearchable = item.value;
            } else if (cog.string.startsWith(item.name, "sSearch_")) {
                destOptions.Columns[colIndex].SearchText = item.value;
            } else if (cog.string.startsWith(item.name, "mDataProp_")) {
                destOptions.Columns[colIndex].ColumnName = item.value;
            } else if (cog.string.startsWith(item.name, "iSortCol_")) {
                destOptions.Columns[item.value].IsSorted = true;
                destOptions.Columns[item.value].SortOrder = colIndex;

                var sortOrder = ko.utils.arrayFilter(srcOptions, function (item) {
                    return item.name == "sSortDir_" + colIndex;
                });

                if (sortOrder.length && sortOrder[0].value == "desc") {
                    destOptions.Columns[item.value].SortDirection = "Descending";
                } else {
                    destOptions.Columns[item.value].SortDirection = "Ascending";
                }
            }
        });

        return destOptions;
    }
};

ko.bindingHandlers.daterangepickerStart = {
    init: function (element, valueAccessor, allBindingsAccessor) {
        //initialize datepicker with some optional options
        var options = allBindingsAccessor().daterangepickerOptions || {};
        options.applyClass = "btn btn-primary";
        $(element).daterangepicker(options,
            function (ev) {
                var observable = valueAccessor();
                observable(ev.date);
            });

    },
    update: function (element, valueAccessor) {
        var value = ko.utils.unwrapObservable(valueAccessor());
        $(element).data('daterangepicker').setStartDate(value);

    }
};

ko.bindingHandlers.daterangepickerEnd = {
    init: function (element, valueAccessor, allBindingsAccessor) {
        //initialize datepicker with some optional options
        var options = allBindingsAccessor().daterangepickerOptions || {};
        options.applyClass = "btn btn-primary";
        $(element).daterangepicker(options,
            function (ev) {
                var observable = valueAccessor();
                observable(ev.date);
            });

    },
    update: function (element, valueAccessor) {
        var value = ko.utils.unwrapObservable(valueAccessor());
        $(element).data('daterangepicker').setEndDate(value);

    }
};


ko.bindingHandlers.hidden = {
    update: function (element, valueAccessor) {
        ko.bindingHandlers.visible.update(element, function () {
            return !ko.utils.unwrapObservable(valueAccessor());
        });
    }
};

ko.bindingHandlers.spinner = {
    init: function (element, valueAccessor, allBindingsAccessor) {
        var value = valueAccessor();

        $(element).TouchSpin().on("stopspin",
            function (event, ui) { value(ui.val); });
    },

    update: function (element, valueAccessor) {
        var value = ko.utils.unwrapObservable(valueAccessor());
        $(element).TouchSpin("value", value);
    }
}

ko.bindingHandlers.dateTimePicker = {
    init: function (element, valueAccessor, allBindingsAccessor) {
        //initialize datepicker with some optional options
        var options = allBindingsAccessor().dateTimePickerOptions || {};
        $(element).datetimepicker(options);

        //when a user changes the date, update the view model
        ko.utils.registerEventHandler(element, "dp.change", function (event) {
            var value = valueAccessor();
            if (ko.isObservable(value)) {

                if (event.date != null && !(event.date instanceof Date)) {
                    var m = moment(event.date.toDate());
                    value(m.utc().toDate());
                    //value(event.date.toDate());
                } else {
                    var m = moment(event.date);
                    value(m.utc().toDate());
                    //value(event.date);
                }
            }
        });

        ko.utils.domNodeDisposal.addDisposeCallback(element, function () {
            var picker = $(element).data("DateTimePicker");
            if (picker) {
                picker.destroy();
            }
        });
    },
    update: function (element, valueAccessor, allBindings, viewModel, bindingContext) {

        var picker = $(element).data("DateTimePicker");
        //when the view model is updated, update the widget
        if (picker) {
            var koDate = ko.utils.unwrapObservable(valueAccessor());

            if (koDate == undefined)
                koDate = null;
            //in case return from server datetime i am get in this form for example /Date(93989393)/ then fomat this
            //  koDate = (typeof (koDate) !== 'object') ? new Date(parseFloat(koDate.replace(/[^0-9]/g, ''))) : koDate;
            if (koDate != null) {
                var m = moment(koDate).local();

                picker.date(m.toDate());
            }
            else {
                picker.date(koDate);
            }
        }
    }
};

