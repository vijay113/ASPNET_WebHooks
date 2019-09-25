using Microsoft.AspNet.WebHooks;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ASPNET_WebHooks.CustomWebHook
{
    public class TestHandler : WebHookHandler
    {
        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context)
        {

            string action = context.Actions.First();
            JObject data = context.GetDataOrDefault<JObject>();
            return Task.FromResult(true);

            // for VSTS webhooks.
            //string msg = string.Format(CultureInfo.CurrentCulture, VstsReceiverResources.Handler_NonMappedEventType, action);
            //context.RequestContext.Configuration.DependencyResolver.GetLogger().Warn(msg);
            //return ExecuteAsync(context, data);

        }
    }
}