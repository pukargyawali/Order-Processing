using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcess.Common
{
    public interface IPaymentGateway
    {
        Boolean ChargePayment(string creditCardNumber, decimal amount); 
    }
}
