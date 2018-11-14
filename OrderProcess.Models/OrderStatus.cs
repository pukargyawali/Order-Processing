using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderProcess.Models
{
    public enum OrderStatus
    {
        NotProcessed = 0,  
        OrderPlaced = 1, 
        Shipped = 2,
        Delivered = 3,
        Cancelled = 4
    }
}