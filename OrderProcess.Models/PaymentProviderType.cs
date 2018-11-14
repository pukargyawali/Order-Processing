using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderProcess.Models
{
    public enum PaymentProviderType
    {
        Master = 0, 
        Visa = 1, 
        Discover = 2, 
        AMEX = 3 
    }
}