namespace Aci.Flex.Plugins.AnsellAfe.Server.Workflow {
    
    #line 19 "C:\Local Source\Git\Demos\Ansell\Aci.Flex.Plugins.AnsellAfe\Aci.Flex.Plugins.AnsellAfe.Server\Workflow\DynamicWorkflow.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\Local Source\Git\Demos\Ansell\Aci.Flex.Plugins.AnsellAfe\Aci.Flex.Plugins.AnsellAfe.Server\Workflow\DynamicWorkflow.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 20 "C:\Local Source\Git\Demos\Ansell\Aci.Flex.Plugins.AnsellAfe\Aci.Flex.Plugins.AnsellAfe.Server\Workflow\DynamicWorkflow.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\Local Source\Git\Demos\Ansell\Aci.Flex.Plugins.AnsellAfe\Aci.Flex.Plugins.AnsellAfe.Server\Workflow\DynamicWorkflow.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\Local Source\Git\Demos\Ansell\Aci.Flex.Plugins.AnsellAfe\Aci.Flex.Plugins.AnsellAfe.Server\Workflow\DynamicWorkflow.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\Local Source\Git\Demos\Ansell\Aci.Flex.Plugins.AnsellAfe\Aci.Flex.Plugins.AnsellAfe.Server\Workflow\DynamicWorkflow.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 21 "C:\Local Source\Git\Demos\Ansell\Aci.Flex.Plugins.AnsellAfe\Aci.Flex.Plugins.AnsellAfe.Server\Workflow\DynamicWorkflow.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 22 "C:\Local Source\Git\Demos\Ansell\Aci.Flex.Plugins.AnsellAfe\Aci.Flex.Plugins.AnsellAfe.Server\Workflow\DynamicWorkflow.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 23 "C:\Local Source\Git\Demos\Ansell\Aci.Flex.Plugins.AnsellAfe\Aci.Flex.Plugins.AnsellAfe.Server\Workflow\DynamicWorkflow.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 24 "C:\Local Source\Git\Demos\Ansell\Aci.Flex.Plugins.AnsellAfe\Aci.Flex.Plugins.AnsellAfe.Server\Workflow\DynamicWorkflow.xaml"
    using Aci.Flex.Plugins.AnsellAfe.Server.Objects;
    
    #line default
    #line hidden
    
    #line 25 "C:\Local Source\Git\Demos\Ansell\Aci.Flex.Plugins.AnsellAfe\Aci.Flex.Plugins.AnsellAfe.Server\Workflow\DynamicWorkflow.xaml"
    using Aci.Flex.Server.Workflow;
    
    #line default
    #line hidden
    
    #line 1 "C:\Local Source\Git\Demos\Ansell\Aci.Flex.Plugins.AnsellAfe\Aci.Flex.Plugins.AnsellAfe.Server\Workflow\DynamicWorkflow.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class DynamicWorkflow : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = DynamicWorkflow_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DynamicWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext2_ForReadOnly valDataContext0 = ((DynamicWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DynamicWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext2_ForReadOnly valDataContext1 = ((DynamicWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DynamicWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext2_ForReadOnly valDataContext2 = ((DynamicWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new DynamicWorkflow_TypedDataContext2(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext2 refDataContext3 = ((DynamicWorkflow_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext3.GetLocation<Aci.Flex.Plugins.AnsellAfe.Server.Objects.DynamicApprovals>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DynamicWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext2_ForReadOnly valDataContext4 = ((DynamicWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new DynamicWorkflow_TypedDataContext2(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext2 refDataContext5 = ((DynamicWorkflow_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext5.GetLocation<System.Guid>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new DynamicWorkflow_TypedDataContext2(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext2 refDataContext6 = ((DynamicWorkflow_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext6.GetLocation<bool>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new DynamicWorkflow_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext3_ForReadOnly valDataContext7 = ((DynamicWorkflow_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new DynamicWorkflow_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext3_ForReadOnly valDataContext8 = ((DynamicWorkflow_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new DynamicWorkflow_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext3_ForReadOnly valDataContext9 = ((DynamicWorkflow_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new DynamicWorkflow_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext3_ForReadOnly valDataContext10 = ((DynamicWorkflow_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new DynamicWorkflow_TypedDataContext3(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext3 refDataContext11 = ((DynamicWorkflow_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext11.GetLocation<bool>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new DynamicWorkflow_TypedDataContext3(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext3 refDataContext12 = ((DynamicWorkflow_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext12.GetLocation<bool>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new DynamicWorkflow_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext3_ForReadOnly valDataContext13 = ((DynamicWorkflow_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new DynamicWorkflow_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext4_ForReadOnly valDataContext14 = ((DynamicWorkflow_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext15 = ((DynamicWorkflow_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext16 = ((DynamicWorkflow_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext17 = ((DynamicWorkflow_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext18 = ((DynamicWorkflow_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext19 = ((DynamicWorkflow_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext20 = ((DynamicWorkflow_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new DynamicWorkflow_TypedDataContext5(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext5 refDataContext21 = ((DynamicWorkflow_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext21.GetLocation<Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext22 = ((DynamicWorkflow_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext23 = ((DynamicWorkflow_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext24 = ((DynamicWorkflow_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext25 = ((DynamicWorkflow_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext26 = ((DynamicWorkflow_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext27 = ((DynamicWorkflow_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext28 = ((DynamicWorkflow_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext29 = ((DynamicWorkflow_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext30 = ((DynamicWorkflow_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new DynamicWorkflow_TypedDataContext5(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext5 refDataContext31 = ((DynamicWorkflow_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext31.GetLocation<bool>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new DynamicWorkflow_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext3_ForReadOnly valDataContext32 = ((DynamicWorkflow_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new DynamicWorkflow_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext3_ForReadOnly valDataContext33 = ((DynamicWorkflow_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new DynamicWorkflow_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext6_ForReadOnly valDataContext34 = ((DynamicWorkflow_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext35 = ((DynamicWorkflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext36 = ((DynamicWorkflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext37 = ((DynamicWorkflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext38 = ((DynamicWorkflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext39 = ((DynamicWorkflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext40 = ((DynamicWorkflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new DynamicWorkflow_TypedDataContext7(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext7 refDataContext41 = ((DynamicWorkflow_TypedDataContext7)(cachedCompiledDataContext[9]));
                return refDataContext41.GetLocation<Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails>(refDataContext41.ValueType___Expr41Get, refDataContext41.ValueType___Expr41Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext42 = ((DynamicWorkflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext43 = ((DynamicWorkflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext44 = ((DynamicWorkflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext45 = ((DynamicWorkflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext46 = ((DynamicWorkflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext47 = ((DynamicWorkflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext48 = ((DynamicWorkflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext49 = ((DynamicWorkflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext50 = ((DynamicWorkflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new DynamicWorkflow_TypedDataContext7(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext7 refDataContext51 = ((DynamicWorkflow_TypedDataContext7)(cachedCompiledDataContext[9]));
                return refDataContext51.GetLocation<bool>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new DynamicWorkflow_TypedDataContext3(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext3 refDataContext52 = ((DynamicWorkflow_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext52.GetLocation<bool>(refDataContext52.ValueType___Expr52Get, refDataContext52.ValueType___Expr52Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new DynamicWorkflow_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext3_ForReadOnly valDataContext53 = ((DynamicWorkflow_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DynamicWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext2_ForReadOnly valDataContext54 = ((DynamicWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DynamicWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext2_ForReadOnly valDataContext55 = ((DynamicWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DynamicWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext2_ForReadOnly valDataContext56 = ((DynamicWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DynamicWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext2_ForReadOnly valDataContext57 = ((DynamicWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DynamicWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext2_ForReadOnly valDataContext58 = ((DynamicWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext58.ValueType___Expr58Get();
            }
            if ((expressionId == 59)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DynamicWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext2_ForReadOnly valDataContext59 = ((DynamicWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext59.ValueType___Expr59Get();
            }
            if ((expressionId == 60)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DynamicWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext2_ForReadOnly valDataContext60 = ((DynamicWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DynamicWorkflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new DynamicWorkflow_TypedDataContext2(locations, activityContext, true);
                }
                DynamicWorkflow_TypedDataContext2 refDataContext61 = ((DynamicWorkflow_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext61.GetLocation<Aci.Flex.Plugins.AnsellAfe.Server.Objects.DynamicApprovals>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set, expressionId, this.rootActivity, activityContext);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                DynamicWorkflow_TypedDataContext2_ForReadOnly valDataContext0 = new DynamicWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                DynamicWorkflow_TypedDataContext2_ForReadOnly valDataContext1 = new DynamicWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                DynamicWorkflow_TypedDataContext2_ForReadOnly valDataContext2 = new DynamicWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                DynamicWorkflow_TypedDataContext2 refDataContext3 = new DynamicWorkflow_TypedDataContext2(locations, true);
                return refDataContext3.GetLocation<Aci.Flex.Plugins.AnsellAfe.Server.Objects.DynamicApprovals>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                DynamicWorkflow_TypedDataContext2_ForReadOnly valDataContext4 = new DynamicWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                DynamicWorkflow_TypedDataContext2 refDataContext5 = new DynamicWorkflow_TypedDataContext2(locations, true);
                return refDataContext5.GetLocation<System.Guid>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                DynamicWorkflow_TypedDataContext2 refDataContext6 = new DynamicWorkflow_TypedDataContext2(locations, true);
                return refDataContext6.GetLocation<bool>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set);
            }
            if ((expressionId == 7)) {
                DynamicWorkflow_TypedDataContext3_ForReadOnly valDataContext7 = new DynamicWorkflow_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                DynamicWorkflow_TypedDataContext3_ForReadOnly valDataContext8 = new DynamicWorkflow_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                DynamicWorkflow_TypedDataContext3_ForReadOnly valDataContext9 = new DynamicWorkflow_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                DynamicWorkflow_TypedDataContext3_ForReadOnly valDataContext10 = new DynamicWorkflow_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                DynamicWorkflow_TypedDataContext3 refDataContext11 = new DynamicWorkflow_TypedDataContext3(locations, true);
                return refDataContext11.GetLocation<bool>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                DynamicWorkflow_TypedDataContext3 refDataContext12 = new DynamicWorkflow_TypedDataContext3(locations, true);
                return refDataContext12.GetLocation<bool>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                DynamicWorkflow_TypedDataContext3_ForReadOnly valDataContext13 = new DynamicWorkflow_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                DynamicWorkflow_TypedDataContext4_ForReadOnly valDataContext14 = new DynamicWorkflow_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext15 = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext16 = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext17 = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext18 = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext19 = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext20 = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                DynamicWorkflow_TypedDataContext5 refDataContext21 = new DynamicWorkflow_TypedDataContext5(locations, true);
                return refDataContext21.GetLocation<Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set);
            }
            if ((expressionId == 22)) {
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext22 = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext23 = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext24 = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext25 = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext26 = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext27 = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext28 = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext29 = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                DynamicWorkflow_TypedDataContext5_ForReadOnly valDataContext30 = new DynamicWorkflow_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                DynamicWorkflow_TypedDataContext5 refDataContext31 = new DynamicWorkflow_TypedDataContext5(locations, true);
                return refDataContext31.GetLocation<bool>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set);
            }
            if ((expressionId == 32)) {
                DynamicWorkflow_TypedDataContext3_ForReadOnly valDataContext32 = new DynamicWorkflow_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                DynamicWorkflow_TypedDataContext3_ForReadOnly valDataContext33 = new DynamicWorkflow_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                DynamicWorkflow_TypedDataContext6_ForReadOnly valDataContext34 = new DynamicWorkflow_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext35 = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext36 = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext37 = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext38 = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext39 = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext40 = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                DynamicWorkflow_TypedDataContext7 refDataContext41 = new DynamicWorkflow_TypedDataContext7(locations, true);
                return refDataContext41.GetLocation<Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails>(refDataContext41.ValueType___Expr41Get, refDataContext41.ValueType___Expr41Set);
            }
            if ((expressionId == 42)) {
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext42 = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext43 = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext44 = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext45 = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext46 = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext47 = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext48 = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext49 = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                DynamicWorkflow_TypedDataContext7_ForReadOnly valDataContext50 = new DynamicWorkflow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                DynamicWorkflow_TypedDataContext7 refDataContext51 = new DynamicWorkflow_TypedDataContext7(locations, true);
                return refDataContext51.GetLocation<bool>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set);
            }
            if ((expressionId == 52)) {
                DynamicWorkflow_TypedDataContext3 refDataContext52 = new DynamicWorkflow_TypedDataContext3(locations, true);
                return refDataContext52.GetLocation<bool>(refDataContext52.ValueType___Expr52Get, refDataContext52.ValueType___Expr52Set);
            }
            if ((expressionId == 53)) {
                DynamicWorkflow_TypedDataContext3_ForReadOnly valDataContext53 = new DynamicWorkflow_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                DynamicWorkflow_TypedDataContext2_ForReadOnly valDataContext54 = new DynamicWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                DynamicWorkflow_TypedDataContext2_ForReadOnly valDataContext55 = new DynamicWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                DynamicWorkflow_TypedDataContext2_ForReadOnly valDataContext56 = new DynamicWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                DynamicWorkflow_TypedDataContext2_ForReadOnly valDataContext57 = new DynamicWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                DynamicWorkflow_TypedDataContext2_ForReadOnly valDataContext58 = new DynamicWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext58.ValueType___Expr58Get();
            }
            if ((expressionId == 59)) {
                DynamicWorkflow_TypedDataContext2_ForReadOnly valDataContext59 = new DynamicWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext59.ValueType___Expr59Get();
            }
            if ((expressionId == 60)) {
                DynamicWorkflow_TypedDataContext2_ForReadOnly valDataContext60 = new DynamicWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                DynamicWorkflow_TypedDataContext2 refDataContext61 = new DynamicWorkflow_TypedDataContext2(locations, true);
                return refDataContext61.GetLocation<Aci.Flex.Plugins.AnsellAfe.Server.Objects.DynamicApprovals>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "WorkflowStatusImages.Submit") 
                        && (DynamicWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ActivityCommentRequirementType.None") 
                        && (DynamicWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ChallengeResponseRequirementType.None") 
                        && (DynamicWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Approvals") 
                        && (DynamicWorkflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Approvals.UserIdentifier") 
                        && (DynamicWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Creator") 
                        && (DynamicWorkflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsRecall") 
                        && (DynamicWorkflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "WorkflowStatusImages.Fail") 
                        && (DynamicWorkflow_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ActivityCommentRequirementType.Allowed") 
                        && (DynamicWorkflow_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Creator") 
                        && (DynamicWorkflow_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ChallengeResponseRequirementType.None") 
                        && (DynamicWorkflow_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsRecall") 
                        && (DynamicWorkflow_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ParallelComplete") 
                        && (DynamicWorkflow_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Approvals.AdditionalApprovers") 
                        && (DynamicWorkflow_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!IsRecall") 
                        && (DynamicWorkflow_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "NotificationSources.ApprovalRequired") 
                        && (DynamicWorkflow_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "user.FlexIdentifier.ToString()") 
                        && (DynamicWorkflow_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "string.Format(\"Approval_{0}\", user.FlexIdentifier)") 
                        && (DynamicWorkflow_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ActivityCommentRequirementType.Allowed") 
                        && (DynamicWorkflow_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "user.FlexIdentifier") 
                        && (DynamicWorkflow_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ChallengeResponseRequirementType.None") 
                        && (DynamicWorkflow_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ApprovalResumptionDetails") 
                        && (DynamicWorkflow_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ApprovalResumptionDetails.IsApproved") 
                        && (DynamicWorkflow_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ApprovalResumptionDetails.UserIdentifier") 
                        && (DynamicWorkflow_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ApprovalResumptionDetails.Comment") 
                        && (DynamicWorkflow_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "WorkflowStatusImages.Success") 
                        && (DynamicWorkflow_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ApprovalResumptionDetails.UserIdentifier") 
                        && (DynamicWorkflow_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ApprovalResumptionDetails.Comment") 
                        && (DynamicWorkflow_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "WorkflowStatusImages.Fail") 
                        && (DynamicWorkflow_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "NotificationSources.AfeRejected") 
                        && (DynamicWorkflow_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Creator.ToString()") 
                        && (DynamicWorkflow_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsRecall") 
                        && (DynamicWorkflow_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!IsRecall") 
                        && (DynamicWorkflow_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Approvals.RequiredApprovers") 
                        && (DynamicWorkflow_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!IsRecall") 
                        && (DynamicWorkflow_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "NotificationSources.ApprovalRequired") 
                        && (DynamicWorkflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "user.FlexIdentifier.ToString()") 
                        && (DynamicWorkflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "string.Format(\"Approval_{0}\", user.FlexIdentifier)") 
                        && (DynamicWorkflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ActivityCommentRequirementType.Allowed") 
                        && (DynamicWorkflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "user.FlexIdentifier") 
                        && (DynamicWorkflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ChallengeResponseRequirementType.None") 
                        && (DynamicWorkflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ApprovalResumptionDetails") 
                        && (DynamicWorkflow_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ApprovalResumptionDetails.IsApproved") 
                        && (DynamicWorkflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ApprovalResumptionDetails.UserIdentifier") 
                        && (DynamicWorkflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ApprovalResumptionDetails.Comment") 
                        && (DynamicWorkflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "WorkflowStatusImages.Success") 
                        && (DynamicWorkflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ApprovalResumptionDetails.UserIdentifier") 
                        && (DynamicWorkflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ApprovalResumptionDetails.Comment") 
                        && (DynamicWorkflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "WorkflowStatusImages.Fail") 
                        && (DynamicWorkflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "NotificationSources.AfeRejected") 
                        && (DynamicWorkflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Creator.ToString()") 
                        && (DynamicWorkflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsRecall") 
                        && (DynamicWorkflow_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ParallelComplete") 
                        && (DynamicWorkflow_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ParallelComplete") 
                        && (DynamicWorkflow_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IsRecall") 
                        && (DynamicWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "NotificationSources.AfeApproved") 
                        && (DynamicWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Creator.ToString()") 
                        && (DynamicWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 56;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "WorkflowStatusImages.Submit") 
                        && (DynamicWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 57;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ActivityCommentRequirementType.None") 
                        && (DynamicWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 58;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Creator") 
                        && (DynamicWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 59;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ChallengeResponseRequirementType.None") 
                        && (DynamicWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 60;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Approvals") 
                        && (DynamicWorkflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 61;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new DynamicWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new DynamicWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new DynamicWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new DynamicWorkflow_TypedDataContext2(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new DynamicWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new DynamicWorkflow_TypedDataContext2(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new DynamicWorkflow_TypedDataContext2(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new DynamicWorkflow_TypedDataContext3_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new DynamicWorkflow_TypedDataContext3_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new DynamicWorkflow_TypedDataContext3_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new DynamicWorkflow_TypedDataContext3_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new DynamicWorkflow_TypedDataContext3(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new DynamicWorkflow_TypedDataContext3(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new DynamicWorkflow_TypedDataContext3_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new DynamicWorkflow_TypedDataContext4_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new DynamicWorkflow_TypedDataContext5_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new DynamicWorkflow_TypedDataContext5_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new DynamicWorkflow_TypedDataContext5_ForReadOnly(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new DynamicWorkflow_TypedDataContext5_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new DynamicWorkflow_TypedDataContext5_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new DynamicWorkflow_TypedDataContext5_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new DynamicWorkflow_TypedDataContext5(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new DynamicWorkflow_TypedDataContext5_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new DynamicWorkflow_TypedDataContext5_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new DynamicWorkflow_TypedDataContext5_ForReadOnly(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new DynamicWorkflow_TypedDataContext5_ForReadOnly(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new DynamicWorkflow_TypedDataContext5_ForReadOnly(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new DynamicWorkflow_TypedDataContext5_ForReadOnly(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new DynamicWorkflow_TypedDataContext5_ForReadOnly(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new DynamicWorkflow_TypedDataContext5_ForReadOnly(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new DynamicWorkflow_TypedDataContext5_ForReadOnly(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new DynamicWorkflow_TypedDataContext5(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new DynamicWorkflow_TypedDataContext3_ForReadOnly(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new DynamicWorkflow_TypedDataContext3_ForReadOnly(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new DynamicWorkflow_TypedDataContext6_ForReadOnly(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new DynamicWorkflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new DynamicWorkflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new DynamicWorkflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new DynamicWorkflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new DynamicWorkflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new DynamicWorkflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new DynamicWorkflow_TypedDataContext7(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new DynamicWorkflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new DynamicWorkflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new DynamicWorkflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new DynamicWorkflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new DynamicWorkflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new DynamicWorkflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new DynamicWorkflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new DynamicWorkflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new DynamicWorkflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new DynamicWorkflow_TypedDataContext7(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new DynamicWorkflow_TypedDataContext3(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new DynamicWorkflow_TypedDataContext3_ForReadOnly(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new DynamicWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new DynamicWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr55GetTree();
            }
            if ((expressionId == 56)) {
                return new DynamicWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr56GetTree();
            }
            if ((expressionId == 57)) {
                return new DynamicWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr57GetTree();
            }
            if ((expressionId == 58)) {
                return new DynamicWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr58GetTree();
            }
            if ((expressionId == 59)) {
                return new DynamicWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr59GetTree();
            }
            if ((expressionId == 60)) {
                return new DynamicWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr60GetTree();
            }
            if ((expressionId == 61)) {
                return new DynamicWorkflow_TypedDataContext2(locationReferences).@__Expr61GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class DynamicWorkflow_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public DynamicWorkflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class DynamicWorkflow_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public DynamicWorkflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class DynamicWorkflow_TypedDataContext1 : DynamicWorkflow_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public DynamicWorkflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return DynamicWorkflow_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class DynamicWorkflow_TypedDataContext1_ForReadOnly : DynamicWorkflow_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public DynamicWorkflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return DynamicWorkflow_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class DynamicWorkflow_TypedDataContext2 : DynamicWorkflow_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool IsRecall;
            
            protected System.Guid Creator;
            
            public DynamicWorkflow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Aci.Flex.Plugins.AnsellAfe.Server.Objects.DynamicApprovals Approvals {
                get {
                    return ((Aci.Flex.Plugins.AnsellAfe.Server.Objects.DynamicApprovals)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 98 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Aci.Flex.Plugins.AnsellAfe.Server.Objects.DynamicApprovals>> expression = () => 
              Approvals;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Aci.Flex.Plugins.AnsellAfe.Server.Objects.DynamicApprovals @__Expr3Get() {
                
                #line 98 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
              Approvals;
                
                #line default
                #line hidden
            }
            
            public Aci.Flex.Plugins.AnsellAfe.Server.Objects.DynamicApprovals ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(Aci.Flex.Plugins.AnsellAfe.Server.Objects.DynamicApprovals value) {
                
                #line 98 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                
              Approvals = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(Aci.Flex.Plugins.AnsellAfe.Server.Objects.DynamicApprovals value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 112 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                  Creator;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr5Get() {
                
                #line 112 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                  Creator;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(System.Guid value) {
                
                #line 112 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                
                  Creator = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(System.Guid value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 126 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      IsRecall;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr6Get() {
                
                #line 126 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                      IsRecall;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr6Set(bool value) {
                
                #line 126 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                
                      IsRecall = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr6Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr6Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr61GetTree() {
                
                #line 505 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Aci.Flex.Plugins.AnsellAfe.Server.Objects.DynamicApprovals>> expression = () => 
                                  Approvals;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Aci.Flex.Plugins.AnsellAfe.Server.Objects.DynamicApprovals @__Expr61Get() {
                
                #line 505 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                  Approvals;
                
                #line default
                #line hidden
            }
            
            public Aci.Flex.Plugins.AnsellAfe.Server.Objects.DynamicApprovals ValueType___Expr61Get() {
                this.GetValueTypeValues();
                return this.@__Expr61Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr61Set(Aci.Flex.Plugins.AnsellAfe.Server.Objects.DynamicApprovals value) {
                
                #line 505 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                
                                  Approvals = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr61Set(Aci.Flex.Plugins.AnsellAfe.Server.Objects.DynamicApprovals value) {
                this.GetValueTypeValues();
                this.@__Expr61Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.IsRecall = ((bool)(this.GetVariableValue((1 + locationsOffset))));
                this.Creator = ((System.Guid)(this.GetVariableValue((2 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((1 + locationsOffset), this.IsRecall);
                this.SetVariableValue((2 + locationsOffset), this.Creator);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 0)].Name != "Approvals") 
                            || (locationReferences[(offset + 0)].Type != typeof(Aci.Flex.Plugins.AnsellAfe.Server.Objects.DynamicApprovals)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "IsRecall") 
                            || (locationReferences[(offset + 1)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "Creator") 
                            || (locationReferences[(offset + 2)].Type != typeof(System.Guid)))) {
                    return false;
                }
                return DynamicWorkflow_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class DynamicWorkflow_TypedDataContext2_ForReadOnly : DynamicWorkflow_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool IsRecall;
            
            protected System.Guid Creator;
            
            public DynamicWorkflow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Aci.Flex.Plugins.AnsellAfe.Server.Objects.DynamicApprovals Approvals {
                get {
                    return ((Aci.Flex.Plugins.AnsellAfe.Server.Objects.DynamicApprovals)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 103 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              WorkflowStatusImages.Submit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr0Get() {
                
                #line 103 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
              WorkflowStatusImages.Submit;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 88 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Aci.Flex.Server.Workflow.ActivityCommentRequirementType>> expression = () => 
              ActivityCommentRequirementType.None;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Aci.Flex.Server.Workflow.ActivityCommentRequirementType @__Expr1Get() {
                
                #line 88 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
              ActivityCommentRequirementType.None;
                
                #line default
                #line hidden
            }
            
            public Aci.Flex.Server.Workflow.ActivityCommentRequirementType ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 93 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Aci.Flex.Server.Workflow.ChallengeResponseRequirementType>> expression = () => 
              ChallengeResponseRequirementType.None;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Aci.Flex.Server.Workflow.ChallengeResponseRequirementType @__Expr2Get() {
                
                #line 93 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
              ChallengeResponseRequirementType.None;
                
                #line default
                #line hidden
            }
            
            public Aci.Flex.Server.Workflow.ChallengeResponseRequirementType ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 117 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                  Approvals.UserIdentifier;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr4Get() {
                
                #line 117 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                  Approvals.UserIdentifier;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 488 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          IsRecall;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr54Get() {
                
                #line 488 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                          IsRecall;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 532 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      NotificationSources.AfeApproved;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr55Get() {
                
                #line 532 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                      NotificationSources.AfeApproved;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr55Get() {
                this.GetValueTypeValues();
                return this.@__Expr55Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr56GetTree() {
                
                #line 537 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      Creator.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr56Get() {
                
                #line 537 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                      Creator.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr56Get() {
                this.GetValueTypeValues();
                return this.@__Expr56Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr57GetTree() {
                
                #line 510 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  WorkflowStatusImages.Submit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr57Get() {
                
                #line 510 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                  WorkflowStatusImages.Submit;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr57Get() {
                this.GetValueTypeValues();
                return this.@__Expr57Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr58GetTree() {
                
                #line 495 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Aci.Flex.Server.Workflow.ActivityCommentRequirementType>> expression = () => 
                                  ActivityCommentRequirementType.None;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Aci.Flex.Server.Workflow.ActivityCommentRequirementType @__Expr58Get() {
                
                #line 495 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                  ActivityCommentRequirementType.None;
                
                #line default
                #line hidden
            }
            
            public Aci.Flex.Server.Workflow.ActivityCommentRequirementType ValueType___Expr58Get() {
                this.GetValueTypeValues();
                return this.@__Expr58Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr59GetTree() {
                
                #line 515 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                  Creator;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr59Get() {
                
                #line 515 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                  Creator;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr59Get() {
                this.GetValueTypeValues();
                return this.@__Expr59Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr60GetTree() {
                
                #line 500 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Aci.Flex.Server.Workflow.ChallengeResponseRequirementType>> expression = () => 
                                  ChallengeResponseRequirementType.None;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Aci.Flex.Server.Workflow.ChallengeResponseRequirementType @__Expr60Get() {
                
                #line 500 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                  ChallengeResponseRequirementType.None;
                
                #line default
                #line hidden
            }
            
            public Aci.Flex.Server.Workflow.ChallengeResponseRequirementType ValueType___Expr60Get() {
                this.GetValueTypeValues();
                return this.@__Expr60Get();
            }
            
            protected override void GetValueTypeValues() {
                this.IsRecall = ((bool)(this.GetVariableValue((1 + locationsOffset))));
                this.Creator = ((System.Guid)(this.GetVariableValue((2 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 0)].Name != "Approvals") 
                            || (locationReferences[(offset + 0)].Type != typeof(Aci.Flex.Plugins.AnsellAfe.Server.Objects.DynamicApprovals)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "IsRecall") 
                            || (locationReferences[(offset + 1)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "Creator") 
                            || (locationReferences[(offset + 2)].Type != typeof(System.Guid)))) {
                    return false;
                }
                return DynamicWorkflow_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class DynamicWorkflow_TypedDataContext3 : DynamicWorkflow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool ParallelComplete;
            
            public DynamicWorkflow_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 169 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              IsRecall;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr11Get() {
                
                #line 169 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                              IsRecall;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(bool value) {
                
                #line 169 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                
                              IsRecall = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 179 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              ParallelComplete;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr12Get() {
                
                #line 179 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                              ParallelComplete;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(bool value) {
                
                #line 179 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                
                              ParallelComplete = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 476 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              ParallelComplete;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr52Get() {
                
                #line 476 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                              ParallelComplete;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr52Set(bool value) {
                
                #line 476 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                
                              ParallelComplete = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr52Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr52Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.ParallelComplete = ((bool)(this.GetVariableValue((3 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((3 + locationsOffset), this.ParallelComplete);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 3)].Name != "ParallelComplete") 
                            || (locationReferences[(offset + 3)].Type != typeof(bool)))) {
                    return false;
                }
                return DynamicWorkflow_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class DynamicWorkflow_TypedDataContext3_ForReadOnly : DynamicWorkflow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool ParallelComplete;
            
            public DynamicWorkflow_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 157 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              WorkflowStatusImages.Fail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr7Get() {
                
                #line 157 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                              WorkflowStatusImages.Fail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 147 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Aci.Flex.Server.Workflow.ActivityCommentRequirementType>> expression = () => 
                              ActivityCommentRequirementType.Allowed;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Aci.Flex.Server.Workflow.ActivityCommentRequirementType @__Expr8Get() {
                
                #line 147 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                              ActivityCommentRequirementType.Allowed;
                
                #line default
                #line hidden
            }
            
            public Aci.Flex.Server.Workflow.ActivityCommentRequirementType ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 162 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                              Creator;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr9Get() {
                
                #line 162 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                              Creator;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 152 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Aci.Flex.Server.Workflow.ChallengeResponseRequirementType>> expression = () => 
                              ChallengeResponseRequirementType.None;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Aci.Flex.Server.Workflow.ChallengeResponseRequirementType @__Expr10Get() {
                
                #line 152 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                              ChallengeResponseRequirementType.None;
                
                #line default
                #line hidden
            }
            
            public Aci.Flex.Server.Workflow.ChallengeResponseRequirementType ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 191 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<Aci.Flex.Core.PersonInfo>>> expression = () => 
                              Approvals.AdditionalApprovers;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IEnumerable<Aci.Flex.Core.PersonInfo> @__Expr13Get() {
                
                #line 191 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                              Approvals.AdditionalApprovers;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IEnumerable<Aci.Flex.Core.PersonInfo> ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 329 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              !IsRecall;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr32Get() {
                
                #line 329 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                              !IsRecall;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 336 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<Aci.Flex.Core.PersonInfo>>> expression = () => 
                                  Approvals.RequiredApprovers;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IEnumerable<Aci.Flex.Core.PersonInfo> @__Expr33Get() {
                
                #line 336 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                  Approvals.RequiredApprovers;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IEnumerable<Aci.Flex.Core.PersonInfo> ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 140 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        ParallelComplete;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr53Get() {
                
                #line 140 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                        ParallelComplete;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            protected override void GetValueTypeValues() {
                this.ParallelComplete = ((bool)(this.GetVariableValue((3 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 3)].Name != "ParallelComplete") 
                            || (locationReferences[(offset + 3)].Type != typeof(bool)))) {
                    return false;
                }
                return DynamicWorkflow_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class DynamicWorkflow_TypedDataContext4 : DynamicWorkflow_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public DynamicWorkflow_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Aci.Flex.Core.PersonInfo user {
                get {
                    return ((Aci.Flex.Core.PersonInfo)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 5))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 5);
                }
                expectedLocationsCount = 5;
                if (((locationReferences[(offset + 4)].Name != "user") 
                            || (locationReferences[(offset + 4)].Type != typeof(Aci.Flex.Core.PersonInfo)))) {
                    return false;
                }
                return DynamicWorkflow_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class DynamicWorkflow_TypedDataContext4_ForReadOnly : DynamicWorkflow_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public DynamicWorkflow_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Aci.Flex.Core.PersonInfo user {
                get {
                    return ((Aci.Flex.Core.PersonInfo)(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 201 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  !IsRecall;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr14Get() {
                
                #line 201 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                  !IsRecall;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 5))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 5);
                }
                expectedLocationsCount = 5;
                if (((locationReferences[(offset + 4)].Name != "user") 
                            || (locationReferences[(offset + 4)].Type != typeof(Aci.Flex.Core.PersonInfo)))) {
                    return false;
                }
                return DynamicWorkflow_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class DynamicWorkflow_TypedDataContext5 : DynamicWorkflow_TypedDataContext4 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public DynamicWorkflow_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails ApprovalResumptionDetails {
                get {
                    return ((Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 239 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails>> expression = () => 
                                        ApprovalResumptionDetails;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails @__Expr21Get() {
                
                #line 239 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                        ApprovalResumptionDetails;
                
                #line default
                #line hidden
            }
            
            public Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr21Set(Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails value) {
                
                #line 239 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                
                                        ApprovalResumptionDetails = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr21Set(Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails value) {
                this.GetValueTypeValues();
                this.@__Expr21Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 311 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              IsRecall;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr31Get() {
                
                #line 311 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                              IsRecall;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr31Set(bool value) {
                
                #line 311 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                
                                              IsRecall = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr31Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr31Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 5)].Name != "ApprovalResumptionDetails") 
                            || (locationReferences[(offset + 5)].Type != typeof(Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails)))) {
                    return false;
                }
                return DynamicWorkflow_TypedDataContext4.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class DynamicWorkflow_TypedDataContext5_ForReadOnly : DynamicWorkflow_TypedDataContext4_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public DynamicWorkflow_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails ApprovalResumptionDetails {
                get {
                    return ((Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 212 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        NotificationSources.ApprovalRequired;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr15Get() {
                
                #line 212 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                        NotificationSources.ApprovalRequired;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 217 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        user.FlexIdentifier.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr16Get() {
                
                #line 217 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                        user.FlexIdentifier.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 229 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        string.Format("Approval_{0}", user.FlexIdentifier);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr17Get() {
                
                #line 229 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                        string.Format("Approval_{0}", user.FlexIdentifier);
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 224 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Aci.Flex.Server.Workflow.ActivityCommentRequirementType>> expression = () => 
                                        ActivityCommentRequirementType.Allowed;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Aci.Flex.Server.Workflow.ActivityCommentRequirementType @__Expr18Get() {
                
                #line 224 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                        ActivityCommentRequirementType.Allowed;
                
                #line default
                #line hidden
            }
            
            public Aci.Flex.Server.Workflow.ActivityCommentRequirementType ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 244 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                        user.FlexIdentifier;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr19Get() {
                
                #line 244 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                        user.FlexIdentifier;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 234 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Aci.Flex.Server.Workflow.ChallengeResponseRequirementType>> expression = () => 
                                        ChallengeResponseRequirementType.None;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Aci.Flex.Server.Workflow.ChallengeResponseRequirementType @__Expr20Get() {
                
                #line 234 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                        ChallengeResponseRequirementType.None;
                
                #line default
                #line hidden
            }
            
            public Aci.Flex.Server.Workflow.ChallengeResponseRequirementType ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 251 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                        ApprovalResumptionDetails.IsApproved;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr22Get() {
                
                #line 251 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                        ApprovalResumptionDetails.IsApproved;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 269 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                              ApprovalResumptionDetails.UserIdentifier;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr23Get() {
                
                #line 269 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                              ApprovalResumptionDetails.UserIdentifier;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 259 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              ApprovalResumptionDetails.Comment;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr24Get() {
                
                #line 259 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                              ApprovalResumptionDetails.Comment;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 264 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              WorkflowStatusImages.Success;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr25Get() {
                
                #line 264 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                              WorkflowStatusImages.Success;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 291 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                              ApprovalResumptionDetails.UserIdentifier;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr26Get() {
                
                #line 291 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                              ApprovalResumptionDetails.UserIdentifier;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 281 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              ApprovalResumptionDetails.Comment;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr27Get() {
                
                #line 281 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                              ApprovalResumptionDetails.Comment;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 286 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              WorkflowStatusImages.Fail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr28Get() {
                
                #line 286 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                              WorkflowStatusImages.Fail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 299 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              NotificationSources.AfeRejected;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr29Get() {
                
                #line 299 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                              NotificationSources.AfeRejected;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 304 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              Creator.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr30Get() {
                
                #line 304 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                              Creator.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 5)].Name != "ApprovalResumptionDetails") 
                            || (locationReferences[(offset + 5)].Type != typeof(Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails)))) {
                    return false;
                }
                return DynamicWorkflow_TypedDataContext4_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class DynamicWorkflow_TypedDataContext6 : DynamicWorkflow_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public DynamicWorkflow_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext6(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Aci.Flex.Core.PersonInfo user {
                get {
                    return ((Aci.Flex.Core.PersonInfo)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 5))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 5);
                }
                expectedLocationsCount = 5;
                if (((locationReferences[(offset + 4)].Name != "user") 
                            || (locationReferences[(offset + 4)].Type != typeof(Aci.Flex.Core.PersonInfo)))) {
                    return false;
                }
                return DynamicWorkflow_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class DynamicWorkflow_TypedDataContext6_ForReadOnly : DynamicWorkflow_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public DynamicWorkflow_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Aci.Flex.Core.PersonInfo user {
                get {
                    return ((Aci.Flex.Core.PersonInfo)(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 346 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      !IsRecall;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr34Get() {
                
                #line 346 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                      !IsRecall;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 5))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 5);
                }
                expectedLocationsCount = 5;
                if (((locationReferences[(offset + 4)].Name != "user") 
                            || (locationReferences[(offset + 4)].Type != typeof(Aci.Flex.Core.PersonInfo)))) {
                    return false;
                }
                return DynamicWorkflow_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class DynamicWorkflow_TypedDataContext7 : DynamicWorkflow_TypedDataContext6 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public DynamicWorkflow_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext7(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails ApprovalResumptionDetails {
                get {
                    return ((Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 384 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails>> expression = () => 
                                            ApprovalResumptionDetails;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails @__Expr41Get() {
                
                #line 384 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                            ApprovalResumptionDetails;
                
                #line default
                #line hidden
            }
            
            public Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr41Set(Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails value) {
                
                #line 384 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                
                                            ApprovalResumptionDetails = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr41Set(Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails value) {
                this.GetValueTypeValues();
                this.@__Expr41Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr51GetTree() {
                
                #line 456 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                  IsRecall;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr51Get() {
                
                #line 456 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                                  IsRecall;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr51Set(bool value) {
                
                #line 456 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                
                                                  IsRecall = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr51Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr51Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 5)].Name != "ApprovalResumptionDetails") 
                            || (locationReferences[(offset + 5)].Type != typeof(Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails)))) {
                    return false;
                }
                return DynamicWorkflow_TypedDataContext6.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class DynamicWorkflow_TypedDataContext7_ForReadOnly : DynamicWorkflow_TypedDataContext6_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public DynamicWorkflow_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DynamicWorkflow_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails ApprovalResumptionDetails {
                get {
                    return ((Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 357 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                            NotificationSources.ApprovalRequired;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr35Get() {
                
                #line 357 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                            NotificationSources.ApprovalRequired;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 362 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                            user.FlexIdentifier.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr36Get() {
                
                #line 362 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                            user.FlexIdentifier.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 374 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                            string.Format("Approval_{0}", user.FlexIdentifier);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr37Get() {
                
                #line 374 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                            string.Format("Approval_{0}", user.FlexIdentifier);
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 369 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Aci.Flex.Server.Workflow.ActivityCommentRequirementType>> expression = () => 
                                            ActivityCommentRequirementType.Allowed;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Aci.Flex.Server.Workflow.ActivityCommentRequirementType @__Expr38Get() {
                
                #line 369 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                            ActivityCommentRequirementType.Allowed;
                
                #line default
                #line hidden
            }
            
            public Aci.Flex.Server.Workflow.ActivityCommentRequirementType ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 389 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                            user.FlexIdentifier;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr39Get() {
                
                #line 389 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                            user.FlexIdentifier;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 379 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Aci.Flex.Server.Workflow.ChallengeResponseRequirementType>> expression = () => 
                                            ChallengeResponseRequirementType.None;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Aci.Flex.Server.Workflow.ChallengeResponseRequirementType @__Expr40Get() {
                
                #line 379 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                            ChallengeResponseRequirementType.None;
                
                #line default
                #line hidden
            }
            
            public Aci.Flex.Server.Workflow.ChallengeResponseRequirementType ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 396 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                            ApprovalResumptionDetails.IsApproved;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr42Get() {
                
                #line 396 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                            ApprovalResumptionDetails.IsApproved;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 414 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                                  ApprovalResumptionDetails.UserIdentifier;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr43Get() {
                
                #line 414 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                                  ApprovalResumptionDetails.UserIdentifier;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 404 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  ApprovalResumptionDetails.Comment;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr44Get() {
                
                #line 404 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                                  ApprovalResumptionDetails.Comment;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 409 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  WorkflowStatusImages.Success;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr45Get() {
                
                #line 409 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                                  WorkflowStatusImages.Success;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 436 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                                  ApprovalResumptionDetails.UserIdentifier;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr46Get() {
                
                #line 436 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                                  ApprovalResumptionDetails.UserIdentifier;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 426 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  ApprovalResumptionDetails.Comment;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr47Get() {
                
                #line 426 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                                  ApprovalResumptionDetails.Comment;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 431 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  WorkflowStatusImages.Fail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr48Get() {
                
                #line 431 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                                  WorkflowStatusImages.Fail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 444 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  NotificationSources.AfeRejected;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr49Get() {
                
                #line 444 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                                  NotificationSources.AfeRejected;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr50GetTree() {
                
                #line 449 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  Creator.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr50Get() {
                
                #line 449 "C:\LOCAL SOURCE\GIT\DEMOS\ANSELL\ACI.FLEX.PLUGINS.ANSELLAFE\ACI.FLEX.PLUGINS.ANSELLAFE.SERVER\WORKFLOW\DYNAMICWORKFLOW.XAML"
                return 
                                                  Creator.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 5)].Name != "ApprovalResumptionDetails") 
                            || (locationReferences[(offset + 5)].Type != typeof(Aci.Flex.Server.Workflow.ApprovalWorkflowResumptionDetails)))) {
                    return false;
                }
                return DynamicWorkflow_TypedDataContext6_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
