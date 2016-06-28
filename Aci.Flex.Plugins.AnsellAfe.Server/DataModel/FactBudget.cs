using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server.DataModel
{
    public class FactBudget
    {
        public long FactId { get; set; }
        public int DivisionId { get; set; }
        public int FunctionId { get; set; }
        public int SiteId { get; set; }
        public int Year { get; set; }
        public decimal Data { get; set; }
        public DateTime InsertedDate { get; set; }
    }
}
