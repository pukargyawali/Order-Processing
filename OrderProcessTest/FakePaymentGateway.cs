using System;
using OrderProcess.Repositories;
using OrderProcess.Common;

namespace OrderProcessTest
{
    internal class FakePaymentGateway : IPaymentGateway
    {
        public bool ChargePayment(string creditCardNumber, decimal amount)
        {
            // this is returned as true just for testing purpose.  
            return true; 
        }
    }
}