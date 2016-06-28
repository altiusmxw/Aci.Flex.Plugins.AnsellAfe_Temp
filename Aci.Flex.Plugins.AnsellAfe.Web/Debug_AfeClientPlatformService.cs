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
            "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6ImEzck1VZ01Gdjl0UGNsTGE2eUYzekFrZnF1RSIsImtpZCI6ImEzck1VZ01Gdjl0UGNsTGE2eUYzekFrZnF1RSJ9.eyJpc3MiOiJodHRwczovL2ZsZXguYWx0aS51cyIsImF1ZCI6Imh0dHBzOi8vZmxleC5hbHRpLnVzL3Jlc291cmNlcyIsImV4cCI6MTQ2NzExMjI3MiwibmJmIjoxNDY3MDcyNjcyLCJjbGllbnRfaWQiOiJmbGV4cG9ydGFsY2xpZW50Iiwic2NvcGUiOlsib3BlbmlkIiwiZmxleCJdLCJzdWIiOiI2ODRjYWRhYS0zYjE1LTRmY2YtODZjYS0wZDc3NGRhZDkyOTIiLCJhdXRoX3RpbWUiOjE0NjcwNzI2NzEsImlkcCI6Imlkc3J2IiwiZ2l2ZW5fbmFtZSI6Ik1pY2hhZWwiLCJmYW1pbHlfbmFtZSI6IldlbGNoIiwiZW1haWwiOiJtaWNoYWVsLndlbGNoQGFsdGl1cy11c2EuY29tIiwibmFtZSI6Ik1pY2hhZWwgV2VsY2giLCJtb2RlbC1pZGVudGlmaWVyIjoiMzBkOWQxYmUtYmM4MC00YzY2LWE3MmMtMDdhMDJmNDExODg0IiwibW9kZWwtdHlwZSI6IkFjaS5GbGV4LlBsdWdpbnMuQW5zZWxsQWZlLlNlcnZlci5BbnNlbGxBZmVNb2RlbCIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6IlN1cGVydXNlciIsImFtciI6WyJwYXNzd29yZCJdfQ.d8HUl79CbXyv2NeMDk7bxtq9Jap8lEv5TJvg49iii-PVXNdy9Ifites49_S-nFLQ7yyUofkXhX7LwguAsAhZ6Z-mva5bGN5gdKgurG7zKS79eTSEHRXV-oP7l8kh6w-g4VlgwYbCAT-MvOERVf6-ur8DNlQT1wNoYhg-JcvkIX8IHpHluIUxRMvKPgFrmbLRQiR2vtOLSnF4YmnNBwohzQ0SGEUi7gkJM-vwh6sXJJD39VIYDNkmrls7m8MlsqHkD3juzXiSob07v_RFbCSWF0RdDY6bypU7gFTy9BGaBtL-eDjzEMfVeRylZ1BP0y7aJz4dbQDt2jR1ZPenW-Q2Hg"
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