using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrderProcess.DataContext;
using OrderProcess.Models;
using OrderProcess.Common;

namespace OrderProcess.Repositories
{
    public class InventoryRepository : Repository<Inventory>, IInventoryRepository
    {
        public InventoryRepository(OrderProcessDBContext context) : base(context)
        {

        }

        public void AddInventory(Inventory inventory)
        {
            throw new NotImplementedException();
        }

        public Inventory GetInventory(int productID)
        {
            throw new NotImplementedException();
        }

        public bool IsInInventory(int productID, int quantity)
        {
            throw new NotImplementedException();
        }

        public void UpdateInventory(int productID, int Quantity) 
        {
            throw new NotImplementedException(); 
        }
    }
}