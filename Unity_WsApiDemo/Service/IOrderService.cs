using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity_WsApiDemo.Models;

namespace Unity_WsApiDemo.Service
{
   public interface IOrderService
   {
       Order Get(int id);
   }
}
