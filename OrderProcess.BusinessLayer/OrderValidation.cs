using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcess.Repositories;
using OrderProcess.Models;
using OrderProcess.BusinessLayer.Interfaces;
using OrderProcess.Common;

namespace OrderProcess.BusinessLayer
{
    /// <summary>
    /// Validates the order before inserting to DB and charging the payment.   
    /// </summary>
    public class OrderValidation
    {
        private IInventoryRepository invRepo;
        private IOrderRepository orderRepo;

        public OrderValidation(IInventoryRepository invRepo, IOrderRepository orderRepo)   
        {
            this.invRepo = invRepo;
            this.orderRepo = orderRepo;
        }

        public bool ValidateOrder(Order order)
        {
            bool isValid = true;

            RemoveProductWithQuantityZero(order);

            if (order == null || order.Products == null || order.Products.Count == 0 || order.CreditCard == null)
            {
                isValid = false;
            }

            if (isValid)
            {
                isValid = ValidateInventory(order);
            }

            return isValid;
        }

        private void RemoveProductWithQuantityZero(Order order)
        {
            if (order != null)
            {
                (order.Products as List<Product>).RemoveAll(x => x.QuantityOrdered.Quantity <= 0);
            }
        }

        private bool ValidateInventory(Order order)
        {
            foreach (Product product in order.Products)
            {
                if (product.QuantityOrdered.Quantity <= 0) return false;
                if (!invRepo.IsInInventory(product.ID, product.QuantityOrdered.Quantity))
                    return false;
            }

            return true;
        }
    }
}
