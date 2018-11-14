using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations; 

namespace OrderProcess.Models
{
    public class ProductQuantity
    {
        [Key] 
        public int ID { get; set; }   

        public int ProductID { get; set; }     

        [ForeignKey("ProductID")] 
        public Product Product { get; set; }      

        public int OrderID { get; set; }   

        [ForeignKey("OrderID")] 
        public Order Order { get; set; }        

        public int Quantity { get; set; }        
    }
}

