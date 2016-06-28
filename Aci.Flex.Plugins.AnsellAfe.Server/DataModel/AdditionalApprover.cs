using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server.DataModel
{
    public class AdditionalApprover
    {
        public int AdditionalApproverId { get; set; }
        public long AfeId { get; set; }
        public Guid ApproverIdentifier { get; set; }
    }
}
