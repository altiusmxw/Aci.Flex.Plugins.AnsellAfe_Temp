using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server.Objects
{
    public class ApprovalAfeDetails
    {
        public long AfeId { get; set; }
        public DateTime CreateDate { get; set; }
        public string ProjectName { get; set; }
        public string DivisionName { get; set; }
        public string FunctionName { get; set; }
        public string SiteName { get; set; }
        public string AfeType { get; set; }
        public string StageGateProjectId { get; set; }
        public string ReferenceNo { get; set; }
        public string ExpenditureType { get; set; }

        public decimal ExchangeRate { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Amount { get; set; }
        public decimal Budget { get; set; }
        public decimal PreviousAfes { get; set; }
        public decimal RemainingBudget { get; set; }
        public int CashBackBefore { get; set; }
        public int CashBackAfter { get; set; }
        public decimal ReturnOnAssets { get; set; }
        public decimal NPV { get; set; }
        public decimal IRR { get; set; }
        public decimal NetWriteOff { get; set; }
    }
}
