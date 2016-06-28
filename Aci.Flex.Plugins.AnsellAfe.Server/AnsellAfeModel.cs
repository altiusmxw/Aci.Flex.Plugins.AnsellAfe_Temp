using Aci.Flex.DataModel;
using Aci.Flex.Interfaces;
using Aci.Flex.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server
{
    [ExportAsFlexPlugin(typeof(AnsellAfeModel), typeof(IFlexModel), false)]
    public class AnsellAfeModel : BaseModel
    {
        public override string Name { get { return "Ansell AFE Tracker Demo"; } }

        public override IEnumerable<SiteMapNode> GetDefaultSiteMap()
        {
            return SiteMapHelper.GetDefaultSiteMap("Aci.Flex.Plugins.AnsellAfe.Server.ansellafe.sitemap");
        }
    }
}
