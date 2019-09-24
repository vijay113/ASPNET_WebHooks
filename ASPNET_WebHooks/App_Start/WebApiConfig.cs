﻿using System.Web.Http;

namespace ASPNET_WebHooks
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Load Web API controllers and Azure Storage store
            config.InitializeCustomWebHooks();

            config.InitializeCustomWebHooksSqlStorage();
            //config.InitializeCustomWebHooksAzureStorage();

            config.InitializeCustomWebHooksApis();

            config.InitializeReceiveCustomWebHooks();
           

        }
    }
}
