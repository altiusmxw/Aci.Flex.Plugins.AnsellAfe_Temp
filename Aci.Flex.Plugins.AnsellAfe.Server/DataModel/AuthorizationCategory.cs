using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server.DataModel
{
    public class AuthorizationCategory
    {
        public int AuthorizationCategoryId { get; set; }
        public int NatureId { get; set; }
        public int DivisionId { get; set; }
        public int FunctionId { get; set; }
    }
}
