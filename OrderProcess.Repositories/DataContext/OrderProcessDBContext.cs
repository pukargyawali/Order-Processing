using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OrderProcess.Models;

namespace OrderProcess.DataContext
{
    /// <summary>
    /// DataContect for connecting to SQL Server. 
    /// </summary>
    public class OrderProcessDBContext : DbContext
    {
        public OrderProcessDBContext() : base("name=OrderProcessDBConnection") 
        {
            
        }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<CreditCardDetail> CreditCards { get; set; }   

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<Inventory> Inventories { get; set; }

        public virtual DbSet<Order> Orders { get; set; }  
    }
}