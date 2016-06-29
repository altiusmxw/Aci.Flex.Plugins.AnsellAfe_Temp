using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Mapping
{
    public class AuthorizationMap : EntityTypeConfiguration<Authorization>
    {
        public AuthorizationMap()
        {
            ToTable("Authorization");
            HasKey(x => x.AuthorizationId);

            Property(x => x.AuthorizationId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.AuthorizationCategoryId).IsRequired();
            Property(x => x.UserIdentifier).IsRequired();
            Property(x => x.ManagerIdentifier).IsRequired();
            Property(x => x.Authority).IsRequired().HasPrecision(28, 8);
            Property(x => x.UserTitle).IsRequired();
            Property(x => x.UserName).IsRequired();
        }
    }
}
