using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity_WsApiDemo.Models;

namespace Unity_WsApiDemo.Service
{
    public class OrderService : IOrderService
    {
      public  Order Get(int id)
        {
           return new Order()
           {
               OrderId = 1,
               CustomerName = "John",
               Items = new List<OrderItems>()
               {
                   new OrderItems(){ ItemName = "Mac book pro"},
                   new OrderItems(){ ItemName = "Iphone 11"}

               }
           };
        }
    }
}