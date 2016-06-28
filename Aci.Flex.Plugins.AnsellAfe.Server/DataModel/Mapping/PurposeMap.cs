using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Mapping
{
    public class PurposeMap : EntityTypeConfiguration<Purpose>
    {
        public PurposeMap()
        {
            ToTable("Purpose");
            HasKey(x => x.PurposeId);

            Property(x => x.PurposeId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.PurposeName).IsRequired();
        }
    }
}
