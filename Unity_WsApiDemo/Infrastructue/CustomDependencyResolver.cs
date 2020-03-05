using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using Unity_WsApiDemo.Controllers;
using Unity_WsApiDemo.Service;

namespace Unity_WsApiDemo.Infrastructue
{
    public class CustomDependencyResolver : IDependencyResolver
    {
        public IDependencyScope BeginScope()
        {
            return this;
        }

        public void Dispose()
        {
            //不需要做任何事
        }

        public object GetService(Type serviceType)
        {
            //判斷要解析的物件
            if (serviceType == typeof(OrderController))
            {
                var service = new OrderService();
                return new OrderController(service);
            }
            return null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return new List<object>();
        }
    }
}