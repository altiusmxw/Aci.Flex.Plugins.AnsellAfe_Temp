using Aci.Flex.Core.Logging;
using Aci.Flex.Interfaces;
using Aci.Flex.Plugins.AnsellAfe.Web.Models;
using Aci.Flex.Portal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace Aci.Flex.Plugins.AnsellAfe.Web.Controllers.Api
{
    [ExportAsFlexPlugin(typeof(SaveAfeApiController), typeof(IFlexApiControllerV2), false)]
    [RoutePrefix("api/saveafeapi")]
    public class SaveAfeApiController : BaseAnsellAfeApiController, IFlexApiControllerV2
    {
        [Route("saveafe")]
        [ResponseType(typeof(Aci.Flex.Plugins.AnsellAfe.Server.Objects.SaveAfeReturnDetails))]
        [HttpPost]
        public async Task<IHttpActionResult> SaveAfe(Aci.Flex.Plugins.AnsellAfe.Server.Objects.AfeSubmitData afe)
        {
            try
            {
                var returnDetails = await AnsellAfeServiceHelper.UseAnsellAfeServiceAsync(s => s.SaveAfeAsync(m_UserIdentifier, afe, false));
                return Ok(returnDetails);
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
                return Ok(new Aci.Flex.Plugins.AnsellAfe.Server.Objects.SaveAfeReturnDetails() { Success = false });
            }
        }
        [Route("savedraftafe")]
        [ResponseType(typeof(Aci.Flex.Plugins.AnsellAfe.Server.Objects.SaveAfeReturnDetails))]
        [HttpPost]
        public async Task<IHttpActionResult> SaveDraftAfe(Aci.Flex.Plugins.AnsellAfe.Server.Objects.AfeSubmitData afe)
        {
            try
            {
                var returnDetails = await AnsellAfeServiceHelper.UseAnsellAfeServiceAsync(s => s.SaveAfeAsync(m_UserIdentifier, afe, true));
                return Ok(returnDetails);
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
                return Ok(new Aci.Flex.Plugins.AnsellAfe.Server.Objects.SaveAfeReturnDetails() { Success = false });
            }
        }
    }
}