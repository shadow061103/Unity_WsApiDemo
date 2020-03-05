using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Unity_WsApiDemo.Service;

namespace Unity_WsApiDemo.Controllers
{
    public class OrderController : ApiController
    {
        private readonly IOrderService _orderService;

        //建構子注入
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            //IOrderService _orderService=new OrderService();
            var result = _orderService.Get(id);
            return Ok(result);
        }
    }
}
