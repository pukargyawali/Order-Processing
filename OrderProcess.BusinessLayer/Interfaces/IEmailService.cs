using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcess.Models;

namespace OrderProcess.BusinessLayer.Interfaces
{
    public interface IEmailService
    {
        bool SendEmail(string Email, string subject, string content);          
    }
}
