using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Routing;
using Unity_WsApiDemo.Infrastructue;

namespace Unity_WsApiDemo
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
           // GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator),
           //new CustomHttpControllerActivator());

        }
    }
}
