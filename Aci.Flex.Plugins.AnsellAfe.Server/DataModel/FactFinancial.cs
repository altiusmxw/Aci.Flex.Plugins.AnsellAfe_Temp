using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server.DataModel
{
    public class FactFinancial
    {
        public long FactId { get; set; }
        public int DivisionId { get; set; }
        public int FunctionId { get; set; }
        public int SiteId { get; set; }
        public int NatureId { get; set; }
        public int PurposeId { get; set; }
        public int Year { get; set; }
        public decimal? Money { get; set; }
        public int? Months { get; set; }
        public decimal? Percentage { get; set; }
        public DateTime InsertedDate { get; set; }
        public Guid InsertedBy { get; set; }
    }
}
