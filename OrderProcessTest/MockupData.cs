using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcess.Models;

namespace OrderProcessTest
{
    /// <summary>
    /// Creates mockup data for Unit testing. 
    /// </summary>
    public class MockupData
    {
        public static Order GetMockupOrder() 
        {
            Product p = new Product();
            p.ID = 1001;
            p.Name = "Dell Laptop";
            p.Description = "250 GB HDD, 16 GB RAM, Dual core"; 
            p.Price = 100.0M;

            ProductQuantity prdQuantity = new ProductQuantity();
            prdQuantity.Product = p;
            prdQuantity.Quantity = 1;
            p.QuantityOrdered = prdQuantity;

            ProductQuantity PrdQty = new ProductQuantity();
            PrdQty.ProductID = p.ID;
            PrdQty.Quantity = 5;

            List<Product> products = new List<Product>();
            products.Add(p);

            Customer c = new Customer();
            c.ID = 101;
            c.FirstName = "Amrit";
            c.LastName = "Poudyal";

            Department departmentSales = new Department(); 
            departmentSales.Email = "ship@theCompany.com"; 
            departmentSales.ID = 2005; 
            departmentSales.Name = "Shipping"; 

            List<Department> departmentsToNotify = new List<Department>();
            departmentsToNotify.Add(departmentSales);

            CreditCardDetail ccDetail = new CreditCardDetail();
            ccDetail.ID = 2500;
            ccDetail.CreditCardNumber = "5222345689786953";
            ccDetail.ExpirationDate = DateTime.Now.AddYears(3);
            ccDetail.PaymentProviderType = PaymentProviderType.Visa;
            ccDetail.SecurityCode = "233";
            ccDetail.Customer = c;
            ccDetail.CustomerID = c.ID;

            Order order = new Order();
            order.ID = 5001;
            order.Products = products;
            order.Customer = c;
            order.CustomerID = c.ID;
            order.CreditCard = ccDetail;
            order.CreditCardID = ccDetail.ID;
            order.Status = OrderStatus.NotProcessed;
            order.Amount = 200.52M;
            order.DepartmentsToNotify = departmentsToNotify;

            prdQuantity.Order = order;

            return order;
        }

        public static List<Inventory> GetMockupInventories() 
        {
            List<Inventory> inventories = new List<Inventory>();

            Product product = new Product();
            product.ID = 1001;
            product.Name = "Dell Laptop";
            product.Description = "250 GB HDD, 16 GB RAM, Dual core";
            product.Price = 100.0M;

            Inventory inventory = new Inventory();
            inventory.ID = 2001;
            inventory.Product = product;
            inventory.ProductID = product.ID;
            inventory.Quantity = 5;

            inventories.Add(inventory);

            return inventories;
        } 
    }
}
