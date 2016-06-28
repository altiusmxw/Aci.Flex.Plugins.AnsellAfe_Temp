using Aci.Flex.Interfaces;
using Aci.Flex.Portal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Aci.Flex.Plugins.AnsellAfe.Web.Controllers.Api
{
    public class BaseAnsellAfeApiController : ApiController, IFlexPlugin
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

        public string Name { get { return this.GetType().FullName; } }
        public int PluginType { get { return (int)Aci.Flex.Interfaces.PluginType.ApiController; } }
    }
}
