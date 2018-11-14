using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations; 

namespace OrderProcess.Models
{
    public class CreditCardDetail
    {
        [Key]
        public int ID { get; set; } 

        public string CreditCardNumber { get; set; } 

        public PaymentProviderType PaymentProviderType { get; set; } 

        public DateTime ExpirationDate { get; set; } 

        public string SecurityCode { get; set; }

        public int CustomerID { get; set; }

        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }
    }
}