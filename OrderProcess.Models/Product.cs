using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderProcess.Models
{
    /// <summary>
    /// Model to represent product and its attributes. 
    /// </summary>
    public class Product
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public virtual IList<Order> Orders { get; set; }      

        public ProductQuantity QuantityOrdered { get; set; }  
    }
}

