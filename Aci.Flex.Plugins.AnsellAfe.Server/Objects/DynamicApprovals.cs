using Aci.Flex.Core;
using Aci.Flex.Server.Workflow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server.Objects
{
    public class DynamicApprovals : BaseWorkflowResumptionDetails
    {
        public List<PersonInfo> RequiredApprovers;
        public List<PersonInfo> AdditionalApprovers;
    }
}
