using ASP.NET_Core_MVC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC.Data.Interfaces
{
   public interface IAllOrders
    {
        void createOrder(Order order);

            
    }
}
