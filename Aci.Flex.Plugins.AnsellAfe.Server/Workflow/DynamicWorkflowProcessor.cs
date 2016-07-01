using Aci.Flex.Interfaces;
using Aci.Flex.Server.Workflow;
using Aci.Flex.Server.Workflow.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server.Workflow
{
        public partial class DynamicWorkflow : IFlexWorkflowDefinition
        {
            public void InitializeWorkflow() { }
        }

        [ExportAsFlexPlugin(typeof(DynamicWorkflowProcessor), typeof(IWorkflowProcessor), false)]
        public class DynamicWorkflowProcessor : BaseWorkflowProcessor<DynamicWorkflow>
        {
            public override string Name { get { return "(Ansell AFE) Dynamic Workflow"; } }
            public override bool IsVisible { get { return true; } }

            //public override IEnumerable<KeyValuePair<int, string>> WorkflowRoles
            //{
            //    get
            //    {
            //        //foreach (WorkflowRoleType role in Enum.GetValues(typeof(WorkflowRoleType)))
            //        //{
            //        //    yield return role.ToKeyValuePair();
            //        //}
            //    }
            //}
        }
}
