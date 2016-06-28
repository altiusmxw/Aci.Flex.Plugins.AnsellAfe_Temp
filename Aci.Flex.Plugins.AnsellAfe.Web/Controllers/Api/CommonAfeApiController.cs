using Aci.Flex.Core.Logging;
using Aci.Flex.Interfaces;
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
    [ExportAsFlexPlugin(typeof(CommonAfeApiController), typeof(IFlexApiControllerV2), false)]
    [RoutePrefix("api/commonafeapi")]
    public class CommonAfeApiController : BaseAnsellAfeApiController, IFlexApiControllerV2
    {
        [Route("getdivisions")]
        [ResponseType(typeof(IEnumerable<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Division>))]
        [HttpGet]
        public async Task<IHttpActionResult> GetDivisions()
        {
            try
            {
                var divisions = await AnsellAfeServiceHelper.UseAnsellAfeServiceAsync(s => s.GetDivisionsAsync());
                return Ok(divisions);
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
                return Ok(new List<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Division>());
            }
        }

        [Route("getfunctions")]
        [ResponseType(typeof(IEnumerable<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Function>))]
        [HttpGet]
        public async Task<IHttpActionResult> GetFunctions()
        {
            try
            {
                var functions = await AnsellAfeServiceHelper.UseAnsellAfeServiceAsync(s => s.GetFunctionsAsync());
                return Ok(functions);
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
                return Ok(new List<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Function>());
            }
        }

        [Route("getsites")]
        [ResponseType(typeof(IEnumerable<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Site>))]
        [HttpGet]
        public async Task<IHttpActionResult> GetSites()
        {
            try
            {
                var sites = await AnsellAfeServiceHelper.UseAnsellAfeServiceAsync(s => s.GetSitesAsync());
                return Ok(sites);
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
                return Ok(new List<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Site>());
            }
        }

        [Route("getnatures")]
        [ResponseType(typeof(IEnumerable<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Nature>))]
        [HttpGet]
        public async Task<IHttpActionResult> GetNatures()
        {
            try
            {
                var natures = await AnsellAfeServiceHelper.UseAnsellAfeServiceAsync(s => s.GetNaturesAsync());
                return Ok(natures);
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
                return Ok(new List<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Nature>());
            }
        }

        [Route("getpurposes")]
        [ResponseType(typeof(IEnumerable<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Purpose>))]
        [HttpGet]
        public async Task<IHttpActionResult> GetPurposes()
        {
            try
            {
                var purposes = await AnsellAfeServiceHelper.UseAnsellAfeServiceAsync(s => s.GetPurposesAsync());
                return Ok(purposes);
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
                return Ok(new List<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Purpose>());
            }
        }

        [Route("getcurrencies")]
        [ResponseType(typeof(IEnumerable<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Currency>))]
        [HttpGet]
        public async Task<IHttpActionResult> GetCurrencies()
        {
            try
            {
                var currencies = await AnsellAfeServiceHelper.UseAnsellAfeServiceAsync(s => s.GetCurrenciesAsync());
                return Ok(currencies);
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
                return Ok(new List<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Currency>());
            }
        }

        [Route("getusdexchangerates")]
        [ResponseType(typeof(IEnumerable<Tuple<int, decimal>>))]
        [HttpGet]
        public async Task<IHttpActionResult> GetUsdExchangeRates()
        {
            try
            {
                var rates = await AnsellAfeServiceHelper.UseAnsellAfeServiceAsync(s => s.GetUsdExchangeRateAsync());
                return Ok(rates);
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
                return Ok(new List<Tuple<int, decimal>>());
            }
        }

        [Route("getbudget")]
        [ResponseType(typeof(decimal))]
        [HttpGet]
        public async Task<IHttpActionResult> GetBudget(int divisionId, int functionId, int siteId, int year)
        {
            try
            {
                var budget = await AnsellAfeServiceHelper.UseAnsellAfeServiceAsync(s => s.GetBudgetAsync(divisionId, functionId, siteId, year));
                return Ok(budget);
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
                return Ok(0);
            }
        }
    }
}