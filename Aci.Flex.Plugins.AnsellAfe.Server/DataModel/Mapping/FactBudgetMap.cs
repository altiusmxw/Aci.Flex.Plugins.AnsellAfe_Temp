using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Mapping
{
    public class FactBudgetMap : EntityTypeConfiguration<FactBudget>
    {
        public FactBudgetMap()
        {
            ToTable("FactBudget");
            HasKey(x => x.FactId);

            Property(x => x.FactId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.DivisionId).IsRequired();
            Property(x => x.FunctionId).IsRequired();
            Property(x => x.SiteId).IsRequired();
            Property(x => x.Year).IsRequired();
            Property(x => x.Data).IsRequired().HasPrecision(28, 8);
            Property(x => x.InsertedDate).IsRequired();
        }
    }
}
