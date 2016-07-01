using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server.Objects
{
    public class AfeSearchResult
    {
        public long AfeId { get; set; }
        public string ProjectName { get; set; }
        public Guid WorkflowIdentifier { get; set; }
    }
}
