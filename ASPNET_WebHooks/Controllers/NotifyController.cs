using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ASPNET_WebHooks.Controllers
{
    [Authorize]
    public class NotifyController : Controller
    {
        // GET: Notify
        public ActionResult Index()
        {
            return View();
        }



        /// <summary>
        /// The input data allows the submitter to include additional data in the WebHook which is then sent to matching receivers. This can be anything that the notification needs to convey data about the event.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Submit()
        {
            // Create an event with action 'event1' and additional data
            await this.NotifyAsync("event1", new { P1 = "p1" });

            return new EmptyResult();
        }
    }
}