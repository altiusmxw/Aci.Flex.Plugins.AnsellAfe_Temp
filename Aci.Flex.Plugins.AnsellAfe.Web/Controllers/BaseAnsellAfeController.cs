using Aci.Flex.Portal;
using Aci.Flex.Portal.Controllers;
using System;
using System.Configuration;

namespace Aci.Flex.Plugins.AnsellAfe.Web.Controllers
{
    public abstract class BaseAnsellAfeController : BaseController
    {
        protected Guid m_UserIdentifier
        {
            get
            {
#if DEBUG
                return new Guid(ConfigurationManager.AppSettings["UserIdentifier"]);
#else
                return LogOnHelper.CurrentLogOnContext.User.FlexIdentifier;
#endif
            }
        }
    }
}