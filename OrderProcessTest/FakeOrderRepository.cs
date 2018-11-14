using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OrderProcess.Models;
using OrderProcess.Repositories;
using OrderProcess.Common;

namespace OrderProcessTest
{
    /// <summary>
    /// This acts as a mockup repository for storing and accessing order related data. 
    /// </summary> 
    public class FakeOrderRepository : IRepository<Order>, IOrderRepository
    {
        public List<Order> orders = new List<Order>();

        public void Add(Order entity)
        {
            this.orders.Add(entity);
        }

        public void AddRange(IEnumerable<Order> entities)
        {
            throw new NotImplementedException();
        }

        public void CancelOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> Find(Expression<Func<Order, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Order Get(int id)
        {
            return this.orders.FirstOrDefault(x => x.ID == id);
        }

        public IEnumerable<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(int orderID)
        {
            throw new NotImplementedException();
        }

        public bool ProcessOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public bool ProcessPayment(Order order)
        {
            throw new NotImplementedException();
        }

        public void Remove(Order entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Order> entities)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
