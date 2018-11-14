using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OrderProcess.Models
{
    public class Inventory
    {
        [Key] 
        public int ID { get; set; } 

        public int ProductID { get; set; }   

        [ForeignKey("ProductID")] 
        public virtual Product Product { get; set; }  

        public int Quantity { get; set; }  
    }
}