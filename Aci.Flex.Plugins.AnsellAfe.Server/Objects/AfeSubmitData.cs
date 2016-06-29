using Aci.Flex.Core;
using Aci.Flex.Plugins.AnsellAfe.Server.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server.Objects
{
    public class AfeSubmitData
    {
        public Afe Afe { get; set; }
        public List<FinancialData> Financials { get; set; }
        public List<PersonInfo> Approvers { get; set; }
        public List<PersonInfo> AdditionalApprovers { get; set; }

        public AfeSubmitData()
        {
            Financials = new List<FinancialData>();
            Approvers = new List<PersonInfo>();
            AdditionalApprovers = new List<PersonInfo>();
        }
    }

    public class FinancialData
    {
        public int AccountId { get; set; }
        public decimal Value { get; set; }
    }
}
