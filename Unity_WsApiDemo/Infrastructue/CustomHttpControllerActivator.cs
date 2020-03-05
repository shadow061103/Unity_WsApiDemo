using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using Unity;
using Unity_WsApiDemo.Controllers;
using Unity_WsApiDemo.Service;

namespace Unity_WsApiDemo.Infrastructue
{
    public class CustomHttpControllerActivator : IHttpControllerActivator
    {
        private IUnityContainer _container;

        public CustomHttpControllerActivator(IUnityContainer container)
        {
            _container = container;
        }

        public IHttpController Create(HttpRequestMessage request, 
            HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            /* 不使用DI容器的寫法
            if (controllerType == typeof(OrderController))
            {
                var orderService = new OrderService();
                request.Properties.Add("RequestTime",DateTime.Now);
                return new OrderController(orderService);

            }
            return null;
            */
            var controller = _container.Resolve(controllerType);
            return controller as IHttpController;
            
        }
    }
}