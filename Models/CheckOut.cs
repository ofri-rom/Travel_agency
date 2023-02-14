using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_Agency.Models
{
    public class CheckOut
    {
        [Key]
        
        public string Id { get; set; }
        
        public string Name { get; set; }
        
        public string Last_name { get; set; }
        
        public string credit_number { get; set; }
        
        public string Exp_date { get; set; }
        
        public string Cvv { get; set; }
    }
}