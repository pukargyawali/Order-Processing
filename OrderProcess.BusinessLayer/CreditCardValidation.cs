using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcess.Models;

namespace OrderProcess.BusinessLayer
{
    public class CreditCardValidation
    {
        public bool ValidateCard(CreditCardDetail ccDetail)
        {
            // Todo : contains the detail for credit card validatioin by calling to 
            // service. Just for example this mehtod always returns true for now. 

            return true; 
        }
    }
}
