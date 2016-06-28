using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Mapping
{
    public class AfeMap : EntityTypeConfiguration<Afe>
    {
        public AfeMap()
        {
            ToTable("Afe");
            HasKey(x => x.AfeId);

            Property(x => x.AfeId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CreateDate).IsRequired();
            Property(x => x.Creator).IsRequired();

            Property(x => x.IsDraft).IsRequired();
            Property(x => x.IsActive).IsRequired();
            Property(x => x.SupplementIndex).IsRequired();
        }
    }
}
