using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Unity_WsApiDemo.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public string CustomerName { get; set; }

        public IEnumerable<OrderItems> Items { get; set; }
    }
}