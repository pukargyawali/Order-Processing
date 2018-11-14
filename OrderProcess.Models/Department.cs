using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace OrderProcess.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; } 
    }
}