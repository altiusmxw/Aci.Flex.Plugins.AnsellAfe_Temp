﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Aci.Flex.Plugins.AnsellAfe.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Workflow/Approval.cshtml")]
    public partial class _Views_Workflow_Approval_cshtml : System.Web.Mvc.WebViewPage<Aci.Flex.Server.Workflow.FlexActivityMetadata>
    {
        public _Views_Workflow_Approval_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Workflow\Approval.cshtml"
  
    Layout = "~/Views/Shared/_AfeLayout.cshtml";
#if DEBUG
        ;

            
            #line default
            #line hidden
WriteLiteral("    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 143), Tuple.Create("\"", 201)
            
            #line 7 "..\..\Views\Workflow\Approval.cshtml"
, Tuple.Create(Tuple.Create("", 149), Tuple.Create<System.Object, System.Int32>(Url.Content("~/Scripts/TypeScriptClasses.js?v=1.0")
            
            #line default
            #line hidden
, 149), false)
);

WriteLiteral("></script>\r\n");

WriteLiteral("    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 225), Tuple.Create("\"", 279)
            
            #line 8 "..\..\Views\Workflow\Approval.cshtml"
, Tuple.Create(Tuple.Create("", 231), Tuple.Create<System.Object, System.Int32>(Url.Content("~/Scripts/common-helper.js?v=1.0")
            
            #line default
            #line hidden
, 231), false)
);

WriteLiteral("></script>\r\n");

WriteLiteral("    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 303), Tuple.Create("\"", 358)
            
            #line 9 "..\..\Views\Workflow\Approval.cshtml"
, Tuple.Create(Tuple.Create("", 309), Tuple.Create<System.Object, System.Int32>(Url.Content("~/Scripts/afe-approval.js?v=1.0.1")
            
            #line default
            #line hidden
, 309), false)
);

WriteLiteral("></script>\r\n");

WriteLiteral("    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 382), Tuple.Create("\"", 445)
            
            #line 10 "..\..\Views\Workflow\Approval.cshtml"
, Tuple.Create(Tuple.Create("", 388), Tuple.Create<System.Object, System.Int32>(Url.Content("~/CodeGen/CommonAfeApiController.js?v=1.0")
            
            #line default
            #line hidden
, 388), false)
);

WriteLiteral("></script>\r\n");

            
            #line 11 "..\..\Views\Workflow\Approval.cshtml"
#else
    ;

            
            #line default
            #line hidden
WriteLiteral("    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 483), Tuple.Create("\"", 590)
            
            #line 13 "..\..\Views\Workflow\Approval.cshtml"
, Tuple.Create(Tuple.Create("", 489), Tuple.Create<System.Object, System.Int32>(Url.Content("~/Resources/Scripts/Aci.Flex.Plugins.AnsellAfe.Web.Scripts.TypeScriptClasses.js?v=1.0")
            
            #line default
            #line hidden
, 489), false)
);

WriteLiteral("></script>\r\n");

WriteLiteral("    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 614), Tuple.Create("\"", 717)
            
            #line 14 "..\..\Views\Workflow\Approval.cshtml"
, Tuple.Create(Tuple.Create("", 620), Tuple.Create<System.Object, System.Int32>(Url.Content("~/Resources/Scripts/Aci.Flex.Plugins.AnsellAfe.Web.Scripts.common-helper.js?v=1.0")
            
            #line default
            #line hidden
, 620), false)
);

WriteLiteral("></script>\r\n");

WriteLiteral("    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 741), Tuple.Create("\"", 843)
            
            #line 15 "..\..\Views\Workflow\Approval.cshtml"
, Tuple.Create(Tuple.Create("", 747), Tuple.Create<System.Object, System.Int32>(Url.Content("~/Resources/Scripts/Aci.Flex.Plugins.AnsellAfe.Web.Scripts.afe-approval.js?v=1.0")
            
            #line default
            #line hidden
, 747), false)
);

WriteLiteral("></script>\r\n");

WriteLiteral("    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 867), Tuple.Create("\"", 979)
            
            #line 16 "..\..\Views\Workflow\Approval.cshtml"
, Tuple.Create(Tuple.Create("", 873), Tuple.Create<System.Object, System.Int32>(Url.Content("~/Resources/CodeGen/Aci.Flex.Plugins.AnsellAfe.Web.CodeGen.CommonAfeApiController.js?v=1.0")
            
            #line default
            #line hidden
, 873), false)
);

WriteLiteral("></script>\r\n");

            
            #line 17 "..\..\Views\Workflow\Approval.cshtml"
#endif

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" id=\"binding-container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" id=\"approval-modal\"");

WriteLiteral(" class=\"modal-body\"");

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"row afe-group-row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-12 afe-group-outer\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-12 afe-group no-padding\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"box-header\"");

WriteLiteral("><h5>ACE Request Information</h5></div>\r\n                        <div");

WriteLiteral(" class=\"box-content\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"row col-md-6\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                        <label");

WriteLiteral(" class=\"control-label col-md-4\"");

WriteLiteral(">Creation Date</label>\r\n                                        <div");

WriteLiteral(" class=\"data-value col-md-8\"");

WriteLiteral(" data-bind=\"text: CommonAfeHelper.getReadableDate(CreateDate())\"");

WriteLiteral("></div>\r\n                                    </div>\r\n                            " +
"    </div>\r\n                                <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                        <label");

WriteLiteral(" class=\"control-label col-md-4\"");

WriteLiteral(">Project Name</label>\r\n                                        <div");

WriteLiteral(" class=\"data-value col-md-8\"");

WriteLiteral(" data-bind=\"text: ProjectName\"");

WriteLiteral("></div>\r\n                                    </div>\r\n                            " +
"    </div>\r\n                                <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                        <label");

WriteLiteral(" class=\"control-label col-md-4\"");

WriteLiteral(">Unit Division</label>\r\n                                        <div");

WriteLiteral(" class=\"data-value col-md-8\"");

WriteLiteral(" data-bind=\"text: DivisionName\"");

WriteLiteral("></div>\r\n                                    </div>\r\n                            " +
"    </div>\r\n                                <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                        <label");

WriteLiteral(" class=\"control-label col-md-4\"");

WriteLiteral(">Function</label>\r\n                                        <div");

WriteLiteral(" class=\"data-value col-md-8\"");

WriteLiteral(" data-bind=\"text: FunctionName\"");

WriteLiteral("></div>\r\n                                    </div>\r\n                            " +
"    </div>\r\n                                <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                        <label");

WriteLiteral(" class=\"control-label col-md-4\"");

WriteLiteral(">Site</label>\r\n                                        <div");

WriteLiteral(" class=\"data-value col-md-8\"");

WriteLiteral(" data-bind=\"text: SiteName\"");

WriteLiteral("></div>\r\n                                    </div>\r\n                            " +
"    </div>\r\n                            </div>\r\n\r\n                            <d" +
"iv");

WriteLiteral(" class=\"row col-md-6\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                        <label");

WriteLiteral(" class=\"control-label col-md-4\"");

WriteLiteral(">AFE Type</label>\r\n                                        <div");

WriteLiteral(" class=\"data-value col-md-8\"");

WriteLiteral(" data-bind=\"text: AfeType\"");

WriteLiteral("></div>\r\n                                    </div>\r\n                            " +
"    </div>\r\n                                <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                        <label");

WriteLiteral(" class=\"control-label col-md-4\"");

WriteLiteral(">Stage-Gate Project ID</label>\r\n                                        <div");

WriteLiteral(" class=\"data-value col-md-8\"");

WriteLiteral(" data-bind=\"text: StageGateProjectId\"");

WriteLiteral("></div>\r\n                                    </div>\r\n                            " +
"    </div>\r\n                                <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                        <label");

WriteLiteral(" class=\"control-label col-md-4\"");

WriteLiteral(">Reference No</label>\r\n                                        <div");

WriteLiteral(" class=\"data-value col-md-8\"");

WriteLiteral(" data-bind=\"text: ReferenceNo\"");

WriteLiteral("></div>\r\n                                    </div>\r\n                            " +
"    </div>\r\n                                <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                        <label");

WriteLiteral(" class=\"control-label col-md-4\"");

WriteLiteral(">Capital or Revenue</label>\r\n                                        <div");

WriteLiteral(" class=\"data-value col-md-8\"");

WriteLiteral(" data-bind=\"text: ExpenditureType\"");

WriteLiteral(@"></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div");

WriteLiteral(" class=\"row afe-group-row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-12 afe-group-outer\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-12 afe-group no-padding\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"box-header\"");

WriteLiteral("><h5>Currency & Rate</h5></div>\r\n                        <div");

WriteLiteral(" class=\"box-content\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"row col-md-6\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                        <label");

WriteLiteral(" class=\"control-label col-md-4\"");

WriteLiteral(">Currency Code</label>\r\n                                        <div");

WriteLiteral(" class=\"data-value col-md-8\"");

WriteLiteral(" data-bind=\"text: CurrencyCode\"");

WriteLiteral("></div>\r\n                                    </div>\r\n                            " +
"    </div>\r\n                            </div>\r\n\r\n                            <d" +
"iv");

WriteLiteral(" class=\"row col-md-6\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                        <label");

WriteLiteral(" class=\"control-label col-md-4\"");

WriteLiteral(">Exchange Rate</label>\r\n                                        <div");

WriteLiteral(" class=\"data-value col-md-8\"");

WriteLiteral(" data-bind=\"text: ExchangeRate\"");

WriteLiteral(@"></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div");

WriteLiteral(" class=\"row afe-group-row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-12 afe-group-outer\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-12 afe-group no-padding\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"box-header\"");

WriteLiteral("><h5>Financial Information</h5></div>\r\n                        <div");

WriteLiteral(" class=\"box-content\"");

WriteLiteral(">\r\n                            <table");

WriteLiteral(" name=\"afe-costs\"");

WriteLiteral(" class=\"table afe-table\"");

WriteLiteral(">\r\n                                <thead>\r\n                                    <" +
"tr>\r\n                                        <th></th>\r\n                        " +
"                <th");

WriteLiteral(" style=\"width: 250px;\"");

WriteLiteral(">Local Currency Amount</th>\r\n                                        <th");

WriteLiteral(" style=\"width: 250px;\"");

WriteLiteral(">Amount or %</th>\r\n                                        <th");

WriteLiteral(" style=\"width: 50px;\"");

WriteLiteral(@"></th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>1. Estimated Amount Required</td>
                                        <td");

WriteLiteral(" class=\"afe-financial-data-entry\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"total-cost\"");

WriteLiteral("></div>\r\n                                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"cost hidden\"");

WriteLiteral(" data-bind=\"totalCost: Amount\"");

WriteLiteral(" />\r\n                                        </td>\r\n                             " +
"           <td");

WriteLiteral(" class=\"afe-financial-data-entry\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"total-cost\"");

WriteLiteral("></div>\r\n                                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"cost hidden\"");

WriteLiteral(" data-bind=\"totalCost: Amount_USD\"");

WriteLiteral(@" />
                                        </td>
                                        <td>USD</td>
                                    </tr>
                                    <tr>
                                        <td>2. Budget Item</td>
                                        <td");

WriteLiteral(" class=\"afe-financial-data-entry\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"total-cost\"");

WriteLiteral("></div>\r\n                                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"cost hidden\"");

WriteLiteral(" data-bind=\"totalCost: Budget_LC\"");

WriteLiteral(" />\r\n                                        </td>\r\n                             " +
"           <td");

WriteLiteral(" class=\"afe-financial-data-entry\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"total-cost\"");

WriteLiteral("></div>\r\n                                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"cost hidden\"");

WriteLiteral(" data-bind=\"totalCost: Budget\"");

WriteLiteral(" />\r\n                                        </td>\r\n                             " +
"           <td>USD</td>\r\n                                    </tr>\r\n\r\n          " +
"                          <tr>\r\n                                        <td");

WriteLiteral(" style=\"padding-left: 19px;\"");

WriteLiteral(">2b. Previous AFEs</td>\r\n                                        <td");

WriteLiteral(" class=\"afe-financial-data-entry\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"total-cost\"");

WriteLiteral("></div>\r\n                                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"cost hidden\"");

WriteLiteral(" data-bind=\"totalCost: PrevAfe_LC\"");

WriteLiteral(" />\r\n                                        </td>\r\n                             " +
"           <td");

WriteLiteral(" class=\"afe-financial-data-entry\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"total-cost\"");

WriteLiteral("></div>\r\n                                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"cost hidden\"");

WriteLiteral(" data-bind=\"totalCost: PreviousAfes\"");

WriteLiteral(" />\r\n                                        </td>\r\n                             " +
"           <td>USD</td>\r\n                                    </tr>\r\n            " +
"                        <tr>\r\n                                        <td");

WriteLiteral(" style=\"padding-left: 19px;\"");

WriteLiteral(">2c. Remaining Budget</td>\r\n                                        <td");

WriteLiteral(" class=\"afe-financial-data-entry\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"total-cost\"");

WriteLiteral("></div>\r\n                                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"cost hidden\"");

WriteLiteral(" data-bind=\"totalCost: RemainingBudget\"");

WriteLiteral(" />\r\n                                        </td>\r\n                             " +
"           <td");

WriteLiteral(" class=\"afe-financial-data-entry\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"total-cost\"");

WriteLiteral("></div>\r\n                                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"cost hidden\"");

WriteLiteral(" data-bind=\"totalCost: RemainingBudget_USD\"");

WriteLiteral(@" />
                                        </td>
                                        <td>USD</td>
                                    </tr>

                                    <tr>
                                        <td>3. i. Cash Payback (before interest)</td>
                                        <td></td>
                                        <td");

WriteLiteral(" class=\"afe-financial-data-entry\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" data-bind=\"text: CashBackBefore\"");

WriteLiteral("></div>\r\n                                        </td>\r\n                         " +
"               <td>Months</td>\r\n                                    </tr>\r\n     " +
"                               <tr>\r\n                                        <td" +
"");

WriteLiteral(" style=\"padding-left: 19px;\"");

WriteLiteral(">ii. Cash Payback (after interest)</td>\r\n                                        " +
"<td></td>\r\n                                        <td");

WriteLiteral(" class=\"afe-financial-data-entry\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" data-bind=\"text: CashBackAfter\"");

WriteLiteral(@"></div>
                                        </td>
                                        <td>Months</td>
                                    </tr>
                                    <tr>
                                        <td>4. Average Return on Total Assets (EBIT/Total Assets)</td>
                                        <td></td>
                                        <td");

WriteLiteral(" class=\"afe-financial-data-entry\"");

WriteLiteral(">\r\n                                            <span");

WriteLiteral(" class=\"total-working-interest\"");

WriteLiteral("></span>\r\n                                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"working-interest hidden\"");

WriteLiteral(" style=\"width: 1px\"");

WriteLiteral(" data-bind=\"totalWi: ReturnOnAssets\"");

WriteLiteral(@" />
                                        </td>
                                        <td>%</td>
                                    </tr>
                                    <tr>
                                        <td>5. Net Present Value</td>
                                        <td></td>
                                        <td");

WriteLiteral(" class=\"afe-financial-data-entry\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"total-cost\"");

WriteLiteral("></div>\r\n                                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"cost hidden\"");

WriteLiteral(" data-bind=\"totalCost: NPV\"");

WriteLiteral(@" />
                                        </td>
                                        <td>USD</td>
                                    </tr>
                                    <tr>
                                        <td>6. Internal Rate of Return</td>
                                        <td></td>
                                        <td");

WriteLiteral(" class=\"afe-financial-data-entry\"");

WriteLiteral(">\r\n                                            <span");

WriteLiteral(" class=\"total-working-interest\"");

WriteLiteral("></span>\r\n                                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"working-interest hidden\"");

WriteLiteral(" style=\"width: 1px\"");

WriteLiteral(" data-bind=\"totalWi: IRR\"");

WriteLiteral(@" />
                                        </td>
                                        <td>%</td>
                                    </tr>
                                    <tr>
                                        <td>7. Net Write-off on Replaced Assets</td>
                                        <td");

WriteLiteral(" class=\"afe-financial-data-entry\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"total-cost\"");

WriteLiteral("></div>\r\n                                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"cost hidden\"");

WriteLiteral(" data-bind=\"totalCost: NetWriteOff\"");

WriteLiteral(" />\r\n                                        </td>\r\n                             " +
"           <td");

WriteLiteral(" class=\"afe-financial-data-entry\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"total-cost\"");

WriteLiteral("></div>\r\n                                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"cost hidden\"");

WriteLiteral(" data-bind=\"totalCost: WriteOff_USD\"");

WriteLiteral(@" />
                                        </td>
                                        <td>USD</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>


        <div");

WriteLiteral(" class=\"row afe-group-row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-12 afe-group-outer\"");

WriteLiteral(" style=\"margin-top: 20px;\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-12 afe-group no-padding\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"box-header\"");

WriteLiteral("><h5>Comments</h5></div>\r\n                        <div");

WriteLiteral(" class=\"box-content\"");

WriteLiteral(">\r\n                            <textarea");

WriteLiteral(" id=\"txtComments\"");

WriteLiteral(" rows=\"8\"");

WriteLiteral(" style=\"width: 100%;\"");

WriteLiteral(" data-bind=\"value: Comments\"");

WriteLiteral("></textarea>\r\n                        </div>\r\n                    </div>\r\n       " +
"         </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" style=\"float: right;\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(">Cancel</button>\r\n                    <button");

WriteLiteral(" id=\"btnRetract\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-danger\"");

WriteLiteral(" onclick=\"ApprovalHelper.Reject()\"");

WriteLiteral(">Reject</button>\r\n                    <button");

WriteLiteral(" id=\"btnRetract\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" onclick=\"ApprovalHelper.Approve()\"");

WriteLiteral(">Approve</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n  " +
"  </div>\r\n\r\n    <div");

WriteLiteral(" id=\"approval-progress\"");

WriteLiteral(" class=\"flex-update-progress collapse\"");

WriteLiteral(" data-container-id=\"binding-container\"");

WriteLiteral("><div");

WriteLiteral(" class=\"loader\"");

WriteLiteral("></div></div>\r\n</div>\r\n\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    ApprovalHelper.Initialize(\'");

            
            #line 282 "..\..\Views\Workflow\Approval.cshtml"
                          Write(Model.WorkflowInstanceId);

            
            #line default
            #line hidden
WriteLiteral("\');\r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591