using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Mapping
{
    public class SiteMap : EntityTypeConfiguration<Site>
    {
        public SiteMap()
        {
            ToTable("Site");
            HasKey(x => x.SiteId);

            Property(x => x.SiteId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.SiteName).IsRequired();
            Property(x => x.SiteCode).IsRequired();
            Property(x => x.Region).IsRequired();
        }
    }
}
