using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Mapping
{
    public class FactFinancialMap : EntityTypeConfiguration<FactFinancial>
    {
        public FactFinancialMap()
        {
            ToTable("FactFinancial");
            HasKey(x => x.FactId);

            Property(x => x.FactId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.DivisionId).IsRequired();
            Property(x => x.FunctionId).IsRequired();
            Property(x => x.SiteId).IsRequired();
            Property(x => x.NatureId).IsRequired();
            Property(x => x.PurposeId).IsRequired();
            Property(x => x.Year).IsRequired();
            Property(x => x.InsertedDate).IsRequired();
            Property(x => x.InsertedBy).IsRequired();

            Property(x => x.Money).IsOptional().HasPrecision(28, 8);
            Property(x => x.Months).IsOptional();
            Property(x => x.Percentage).IsOptional().HasPrecision(20, 10);
        }
    }
}
