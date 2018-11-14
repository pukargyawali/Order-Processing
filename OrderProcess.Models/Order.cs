using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderProcess.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal Amount { get; set; }

        public virtual IList<Product> Products { get; set; } 

        public OrderStatus Status { get; set; }

        public int CustomerID { get; set; }

        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }

        public int CreditCardID { get; set; }

        [ForeignKey("CreditCardID")]
        public CreditCardDetail CreditCard { get; set; }

        public int ProductQuantityID { get; set; }

        public virtual ProductQuantity ProductQuantity { get; set; } 

        public List<Department> DepartmentsToNotify { get; set; }
               
    }
}