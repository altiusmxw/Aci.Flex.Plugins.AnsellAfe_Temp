using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Mapping
{
    public class AdditionalApproverMap : EntityTypeConfiguration<AdditionalApprover>
    {
        public AdditionalApproverMap()
        {
            ToTable("AdditionalApprover");
            HasKey(x => x.AdditionalApproverId);

            Property(x => x.AdditionalApproverId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.AfeId).IsRequired();
            Property(x => x.ApproverIdentifier).IsRequired();
        }
    }
}
