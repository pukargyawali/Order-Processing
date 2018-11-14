using OrderProcess.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcess.Models;

namespace OrderProcessTest
{
    public class FakeEmailService : IEmailService
    {       
        public bool SendEmail(string email, string subject, string content) 
        {
            //throw new NotImplementedException();
            // Todo: Code for sending emails. 
            // get the email address from department object. 
            // Get the order details from order object. 

            return true; 
        }
    }
}
