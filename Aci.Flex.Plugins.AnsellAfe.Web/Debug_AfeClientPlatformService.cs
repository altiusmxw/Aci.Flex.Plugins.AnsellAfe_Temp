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
            "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6ImEzck1VZ01Gdjl0UGNsTGE2eUYzekFrZnF1RSIsImtpZCI6ImEzck1VZ01Gdjl0UGNsTGE2eUYzekFrZnF1RSJ9.eyJpc3MiOiJodHRwczovL2ZsZXguYWx0aS51cyIsImF1ZCI6Imh0dHBzOi8vZmxleC5hbHRpLnVzL3Jlc291cmNlcyIsImV4cCI6MTQ2NzI1NzkzNiwibmJmIjoxNDY3MjE4MzM2LCJjbGllbnRfaWQiOiJmbGV4cG9ydGFsY2xpZW50Iiwic2NvcGUiOlsib3BlbmlkIiwiZmxleCJdLCJzdWIiOiI2ODRjYWRhYS0zYjE1LTRmY2YtODZjYS0wZDc3NGRhZDkyOTIiLCJhdXRoX3RpbWUiOjE0NjcyMTgzMzUsImlkcCI6Imlkc3J2IiwiZ2l2ZW5fbmFtZSI6Ik1pY2hhZWwiLCJmYW1pbHlfbmFtZSI6IldlbGNoIiwiZW1haWwiOiJtaWNoYWVsLndlbGNoQGFsdGl1cy11c2EuY29tIiwibmFtZSI6Ik1pY2hhZWwgV2VsY2giLCJtb2RlbC1pZGVudGlmaWVyIjoiMzBkOWQxYmUtYmM4MC00YzY2LWE3MmMtMDdhMDJmNDExODg0IiwibW9kZWwtdHlwZSI6IkFjaS5GbGV4LlBsdWdpbnMuQW5zZWxsQWZlLlNlcnZlci5BbnNlbGxBZmVNb2RlbCIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6IlN1cGVydXNlciIsImFtciI6WyJwYXNzd29yZCJdfQ.aLmJhRbdif8VP_EJtqhMIz0BfZFTGdDDkIJniS7pI_vwV1ZpvMADhAuvSRanWVcCtBp5Q-4SsOiyjPO9jQs38ZkBCjLA_0xwAE5iZQPJ0co6fORyxsgsjgR5RvTmfOtC-X9bOrUgUQ04Uao9qzqVBIPFh0O9Co6WChRy6Y7cCjph_NlbRvW92JnxcUWHN6WI9gJwPzXv1NNkeE7CpBe_bCQdBn9GoxUSHCVGdCZfFY1AMHMtirl_TEuTxdS94ny-7ychlMov5wHCG8EFjhZg9JCznxqauYlkUllPj0qJD1QE6o9svNDeQ7g_MoggLX7y4NkkcwPDROz0odTjho7JyQ"
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