using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ASPNET_WebHooks.Controllers_Api
{    
    [Authorize]
    public class NotifyApiController : ApiController
    {

        //[HttpPost]
        //[Route("")]
        //public void Post(object message)
        //{
        //    Console.WriteLine($"Received webhook: {message}");
        //}

        [HttpGet]       
        public HttpResponseMessage Get(string echo)
        {
            Console.WriteLine($"Received echo request for validation of the registration");

            var resp = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(echo, Encoding.UTF8, "text/plain")
            };
            return resp;
        }


        [HttpPost]
        public async Task Post()
        {
            // Create an event with 'event2' and additional data
            await this.NotifyAsync("event2", new { P1 = "p1" });
        }

    }
}
