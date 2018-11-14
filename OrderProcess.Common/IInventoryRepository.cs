using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrderProcess.Models;

namespace OrderProcess.Common
{
    public interface IInventoryRepository : IRepository<Inventory>
    {
        bool IsInInventory(int productID, int quantity);          
        void UpdateInventory(int productID, int QuantityOrdered);             
    } 
}