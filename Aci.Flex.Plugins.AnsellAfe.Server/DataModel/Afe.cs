using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server.DataModel
{
    public class Afe
    {
        public long AfeId { get; set; }
        public DateTime CreateDate { get; set; }
        public int DivisionId { get; set; }
        public int FunctionId { get; set; }
        public int SiteId { get; set; }
        public string ExpenditureType { get; set; }
        public string StateGateProjectId { get; set; }
        public string ReferenceNo { get; set; }
        public int NatureId { get; set; }
        public int PurposeId { get; set; }
        public string Description { get; set; }
        public string Proposal { get; set; }
        public string ProjectBenefits { get; set; }
        public string ProjectRisks { get; set; }
        public string ControlMeasures { get; set; }
        public int CurrencyId { get; set; }
        public Guid Creator { get; set; }
        public string ApprovalStatus { get; set; }
        public bool IsActive { get; set; }
        public bool IsDraft { get; set; }
        public long? OriginalAfeId { get; set; }
        public int SupplementIndex { get; set; }
    }
}
