using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcess.Common
{
    public class PaymentGateway : IPaymentGateway
    {
        public bool ChargePayment(string creditCardNumber, decimal amount)
        {
            // this method calls to the web service api and gets the response. 
            // for now the method returns true for the testing purpose. 
            // for that purpose we need to add a reference to a web service and call the api. 
            return true;  
        }
    }
}
