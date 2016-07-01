using Aci.Flex.Client.Shared;
using Aci.Flex.Core;
using Aci.Flex.Interfaces;
using Aci.Flex.Portal.Platform.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Aci.Flex.Plugins.AnsellAfe.Web
{
    public class AfeClientPlatformService : IClientPlatformService
    {
        static ClientTokenBehavior behavior = new ClientTokenBehavior(() =>
            "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6ImEzck1VZ01Gdjl0UGNsTGE2eUYzekFrZnF1RSIsImtpZCI6ImEzck1VZ01Gdjl0UGNsTGE2eUYzekFrZnF1RSJ9.eyJpc3MiOiJodHRwczovL2ZsZXguYWx0aS51cyIsImF1ZCI6Imh0dHBzOi8vZmxleC5hbHRpLnVzL3Jlc291cmNlcyIsImV4cCI6MTQ2NzI2OTIwMiwibmJmIjoxNDY3MjI5NjAyLCJjbGllbnRfaWQiOiJmbGV4cG9ydGFsY2xpZW50Iiwic2NvcGUiOlsib3BlbmlkIiwiZmxleCJdLCJzdWIiOiI2ODRjYWRhYS0zYjE1LTRmY2YtODZjYS0wZDc3NGRhZDkyOTIiLCJhdXRoX3RpbWUiOjE0NjcyMjk2MDIsImlkcCI6Imlkc3J2IiwiZ2l2ZW5fbmFtZSI6Ik1pY2hhZWwiLCJmYW1pbHlfbmFtZSI6IldlbGNoIiwiZW1haWwiOiJtaWNoYWVsLndlbGNoQGFsdGl1cy11c2EuY29tIiwibmFtZSI6Ik1pY2hhZWwgV2VsY2giLCJtb2RlbC1pZGVudGlmaWVyIjoiMzBkOWQxYmUtYmM4MC00YzY2LWE3MmMtMDdhMDJmNDExODg0IiwibW9kZWwtdHlwZSI6IkFjaS5GbGV4LlBsdWdpbnMuQW5zZWxsQWZlLlNlcnZlci5BbnNlbGxBZmVNb2RlbCIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6IlN1cGVydXNlciIsImFtciI6WyJwYXNzd29yZCJdfQ.eOcPREaXJk6xgwdyyY2sHpoqh45SrQy3cJywrT99vRjJPTfoVvkpQnjqSb3UOp-fi4cErduHvR51Gztzs6BGUFuIqId4h_I5xZVILmmoR8FW00GBVasV1afkKMtxRLvnAi_6V0DbSID7tlIIlkgwUVO_iVNVocUqM9IV9cW48IBo2OZVjeUmRdXkOaWfsfROmMJ4SiALM2qpENGnh46797S4MIpa4_bBUBDCMee8FgdMDw2JEBQVMrEyE60Jyg_msKohede6ut4XdpIVO8lH0MXavKF7hd2BVYRUlow-4PHrtnK30popeHDL9gXHGUG6L23X8KKV4w3d0Atgw3N7hA"
        );
        public static Uri BaseAddress
        {
            get
            {
                return new Uri("http://localhost:8001");
            }
        }

        private static Uri GetModelEndpoint(string serviceName)
        {
            return new Uri(BaseAddress, "/services/Aci.Flex.Plugins.AnsellAfe.Server.AnsellAfeService");
        }

        public TReturn UseClientService<TReturn>(Func<IClientService, TReturn> code)
        {
            throw new NotImplementedException();
        }

        public Task<TReturn> UseClientServiceAsync<TReturn>(Func<IClientServiceAsync, Task<TReturn>> code)
        {
            throw new NotImplementedException();
        }

        public Task<TReturn> UseModelServiceAsync<TContract, TReturn>(string serviceName, Func<TContract, Task<TReturn>> code) where TContract : class
        {
            var factory = ChannelFactoryWrapper<TContract>.GetWrapper(Aci.Flex.Core.ServiceHelper.GetBinding(BaseAddress));

            var modelEndpoint = GetModelEndpoint(serviceName);

            return ChannelFactoryHelper.UseServiceAsync(factory, modelEndpoint, code, behavior.ToEnumerable());
        }

        public TReturn UseModelService<TContract, TReturn>(string serviceName, Func<TContract, TReturn> code) where TContract : class
        {
            var factory = ChannelFactoryWrapper<TContract>.GetWrapper(Aci.Flex.Core.ServiceHelper.GetBinding(BaseAddress));

            var modelEndpoint = GetModelEndpoint(serviceName);

            return ChannelFactoryHelper.UseService(factory, modelEndpoint, code, behavior.ToEnumerable());
        }
    }

    public class AfePlatformServices : IPortalPlatformServices
    {
        public IClientPlatformService Client
        {
            get
            {
                return new AfeClientPlatformService();
            }
        }
    }
}