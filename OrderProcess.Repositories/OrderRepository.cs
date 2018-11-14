using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrderProcess.Models;
using System.Data.Entity;
using OrderProcess.DataContext;
using OrderProcess.Common;

namespace OrderProcess.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(OrderProcessDBContext context) : base(context) { }

        public void CancelOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}