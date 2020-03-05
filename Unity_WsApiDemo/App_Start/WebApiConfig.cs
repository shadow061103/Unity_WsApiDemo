using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using Unity;
using Unity.Lifetime;
using Unity_WsApiDemo.Controllers;
using Unity_WsApiDemo.Infrastructue;
using Unity_WsApiDemo.Service;

namespace Unity_WsApiDemo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 設定和服務

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //替換 IHttpControllerActivator 實作
            //config.Services.Replace(typeof(IHttpControllerActivator),
            //    new CustomHttpControllerActivator());

            //DI容器
            //var container = new UnityContainer();
            //container.RegisterType<OrderController>();
            //container.RegisterType<IOrderService, OrderService>();
            //var customControllerActivator=new CustomHttpControllerActivator(container);
            //config.Services.Replace(typeof(IHttpControllerActivator),
            //    customControllerActivator);


            //替換IDependencyResolver
            //config.DependencyResolver=new CustomDependencyResolver();
            //DI容器使用UnityDependencyResolver 來解析
            var container=new UnityContainer();
            var lifeManager = new HierarchicalLifetimeManager();
            container.RegisterType<IOrderService, OrderService>(lifeManager);
            var resolver=new UnityDependencyResolver(container);
            config.DependencyResolver = resolver;


        }

    }
}
