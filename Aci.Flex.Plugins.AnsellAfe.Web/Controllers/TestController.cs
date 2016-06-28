using Aci.Flex.Interfaces;
using Aci.Flex.Portal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aci.Flex.Plugins.AnsellAfe.Web.Controllers
{
    [ExportAsFlexPlugin(typeof(TestController), typeof(IFlexController), false)]
    public class TestController : BaseAnsellAfeController
    {
        public override string ControllerName { get { return "Test"; } }

        // GET: Test
        public ActionResult Index()
        {
            var result = AnsellAfeServiceHelper.UseAnsellAfeService(c => c.DummyDatabaseCall());
#if DEBUG
            return View();
#else
            return this.RazorView();
#endif
        }
    }
}