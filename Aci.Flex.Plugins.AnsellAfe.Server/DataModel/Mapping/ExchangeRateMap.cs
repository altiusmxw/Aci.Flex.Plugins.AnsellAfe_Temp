using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Mapping
{
    public class ExchangeRateMap : EntityTypeConfiguration<ExchangeRate>
    {
        public ExchangeRateMap()
        {
            ToTable("ExchangeRate");
            HasKey(x => new { x.FromCurrency, x.ToCurrency });

            Property(x => x.FromCurrency).IsRequired();
            Property(x => x.ToCurrency).IsRequired();
            Property(x => x.ExchangeRateValue).IsRequired().HasPrecision(20, 10);
        }
    }
}
