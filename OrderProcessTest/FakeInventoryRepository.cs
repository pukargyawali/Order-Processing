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
    /// This acts as a mockup repository for storing and accessing inventories related data. 
    /// </summary>
    public class FakeInventoryRepository : IRepository<Inventory>, IInventoryRepository
    {
        private List<Inventory> inventories;

        public FakeInventoryRepository()
        {
            this.inventories = new List<Inventory>();
        }

        public FakeInventoryRepository(List<Inventory> inventories)
        {
            this.inventories = inventories;
        }

        public void Add(Inventory entity)
        {
            this.inventories.Add(entity);
        }

        public void AddRange(IEnumerable<Inventory> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Inventory> Find(Expression<Func<Inventory, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Inventory Get(int id)
        {
            return this.inventories.FirstOrDefault(x => x.ID == id);
        }

        public IEnumerable<Inventory> GetAll()
        {
            throw new NotImplementedException();
        }

        public Inventory GetInventory(int productID)
        {
            return this.inventories.FirstOrDefault(x => x.ProductID == productID);
        }

        public bool IsInInventory(int productID, int quantityOrdered)
        {
            // this method uses the data source to query the availability of inventory
            // for testing purpose it returns true for now. 
            return this.inventories.Any(x => x.ProductID == productID && x.Quantity >= quantityOrdered);
        }

        public void Remove(Inventory entity)
        {
            this.inventories.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Inventory> entities)
        {
            throw new NotImplementedException();
        }

        public void UpdateInventory(int productID, int quantityOrdered)
        {
            Inventory inv = this.inventories.FirstOrDefault(x => x.Product.ID == productID);
            inv.Quantity = inv.Quantity - quantityOrdered;
        }
    }
}
