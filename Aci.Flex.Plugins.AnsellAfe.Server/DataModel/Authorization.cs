using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server.DataModel
{
    public class Authorization
    {
        public int AuthorizationId { get; set; }
        public int AuthorizationCategoryId { get; set; }
        public Guid UserIdentifier { get; set; }
        public Guid ManagerIdentifier { get; set; }
        public decimal Authority { get; set; }
        public string UserTitle { get; set; }
        public string UserName { get; set; }
    }
}
