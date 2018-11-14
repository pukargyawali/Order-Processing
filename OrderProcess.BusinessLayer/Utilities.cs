using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcess.Models;

namespace OrderProcess.BusinessLayer
{
    public class Utilities
    {
        public static string GetContentForOrder(Order order)
        {
            // We can use this method to generate the email body dynamically from the order details. 
            return String.Format("Order of OrderID : {0} has been placed.", order.ID); 
        }

        public static string GetEmailSubjectForOrder(Order order)
        {
            return String.Format("Order of OrderID : {0} has been placed.", order.ID);  
        }
    }
}
