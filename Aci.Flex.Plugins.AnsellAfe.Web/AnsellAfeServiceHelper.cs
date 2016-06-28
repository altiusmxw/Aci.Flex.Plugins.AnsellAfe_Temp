using Aci.Flex.Core.Logging;
using Aci.Flex.Plugins.AnsellAfe.Server.Interfaces;
using Aci.Flex.Portal.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Aci.Flex.Plugins.AnsellAfe.Web
{
    internal class AnsellAfeServiceHelper
    {
        const string afeService = "Aci.Flex.Plugins.AnsellAfe.Server.AnsellAfeService";

        public static TReturn UseAnsellAfeService<TReturn>(Func<IAnsellAfeService, TReturn> code)
        {
            return PlatformServices.Client.UseModelService(afeService, code);
        }

        public static Task<TReturn> UseAnsellAfeServiceAsync<TReturn>(Func<IAnsellAfeServiceAsync, Task<TReturn>> code)
        {
            return PlatformServices.Client.UseModelServiceAsync(afeService, code);
        }

        public static void LogError(string message)
        {
            Log.Error(message);
        }

        public static void LogException(Exception ex)
        {
            Log.Exception(ex);
        }
    }
}