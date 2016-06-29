using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Mapping
{
    public class AuthorizationCategoryMap : EntityTypeConfiguration<AuthorizationCategory>
    {
        public AuthorizationCategoryMap()
        {
            ToTable("AuthorizationCategory");
            HasKey(x => x.AuthorizationCategoryId);

            Property(x => x.AuthorizationCategoryId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.NatureId).IsRequired();
            Property(x => x.DivisionId).IsRequired();
            Property(x => x.FunctionId).IsRequired();
        }
    }
}
