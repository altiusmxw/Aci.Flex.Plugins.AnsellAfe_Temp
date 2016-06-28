using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server.DataModel
{
    public class ExchangeRate
    {
        public int FromCurrency { get; set; }
        public int ToCurrency { get; set; }
        public decimal ExchangeRateValue { get; set; }
    }
}
