using Microsoft.AspNet.WebHooks;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ASPNET_WebHooks.FilterEvents
{
    /// <summary>
    /// Use a IWebHookFilterProvider implementation to describe the events that users can 
    /// subscribe to. A wildcard is always registered meaning that users can register for 
    /// "all events". It is possible to have 0, 1, or more IWebHookFilterProvider 
    /// implementations.
    /// </summary>
    public class MyFilterProvider : IWebHookFilterProvider
    {
        private readonly Collection<WebHookFilter> filters = new Collection<WebHookFilter>
        {
        new WebHookFilter { Name = "event1", Description = "This event1 happened."},
        new WebHookFilter { Name = "event2", Description = "This event2 happened."},
        };
       

        Task<Collection<WebHookFilter>> IWebHookFilterProvider.GetFiltersAsync()
        {
            return Task.FromResult(this.filters);
        }
    }
}
