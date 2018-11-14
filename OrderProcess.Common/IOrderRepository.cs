using OrderProcess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcess.Common
{
    public interface IOrderRepository : IRepository<Order>
    {             
        void UpdateOrder(Order order);

        void CancelOrder(Order order);         
    }
}
