using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OrderProcess.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; } 

        public string Email { get; set; }

        /// <summary>
        /// House number and Street name 
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Apt or Unit Number 
        /// </summary>
        public string Address2 { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public virtual List<CreditCardDetail> PaymentCards { get; set; }
    }
}