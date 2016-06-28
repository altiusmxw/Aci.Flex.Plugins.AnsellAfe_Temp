using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Mapping
{
    public class NatureMap : EntityTypeConfiguration<Nature>
    {
        public NatureMap()
        {
            ToTable("Nature");
            HasKey(x => x.NatureId);

            Property(x => x.NatureId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.NatureName).IsRequired();
        }
    }
}
