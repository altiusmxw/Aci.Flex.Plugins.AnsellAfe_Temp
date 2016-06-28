using Aci.Flex.Interfaces;
using Aci.Flex.Plugins.AnsellAfe.Web.Models;
using Aci.Flex.Portal;
using Aci.Flex.Portal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aci.Flex.Plugins.AnsellAfe.Web.Controllers
{
    [ExportAsFlexPlugin(typeof(AfeCaptureController), typeof(IFlexController), false)]
    public class AfeCaptureController : BaseAnsellAfeController
    {
        public override string ControllerName { get { return "AfeCapture"; } }

        // GET: AfeCapture
        public ActionResult New()
        {
            AfeInitializationData afeData = new AfeInitializationData()
            {
                IsSupplement = false,
                AfeCreateType = AfeCreateType.New
            };

#if DEBUG
            afeData.CreatorName = "Michael Welch";
            return View("Index", afeData);
#else
            afeData.CreatorName = LogOnHelper.CurrentLogOnContext.User.Name;
            return this.RazorView("Index", afeData);
#endif
        }
    }
}