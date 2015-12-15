using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.WebHooks;
using Newtonsoft.Json.Linq;

namespace Webhook.Controllers
{
    public class WebhookController : WebHookHandler
    {
        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context)
        {
            var action = context.Actions.First();
            JObject data = context.GetDataOrDefault<JObject>();

            return Task.FromResult(true);
        }
    }
}