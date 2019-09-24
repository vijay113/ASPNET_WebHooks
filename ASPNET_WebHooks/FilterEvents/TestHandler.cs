using Microsoft.AspNet.WebHooks;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ASPNET_WebHooks.FilterEvents
{
    public class TestHandler : WebHookHandler
    {
        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context)
        {

            string action = context.Actions.First();
            JObject data = context.GetDataOrDefault<JObject>();
            return Task.FromResult(true);
        }
    }
}