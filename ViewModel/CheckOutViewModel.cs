using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Travel_Agency.Models;

namespace Travel_Agency.ViewModel
{
    public class CheckOutViewModel
    {
        public CheckOut ck { get; set; }
        public int number_of_tickets { get; set; }
        public int flight_id { get; set; }

        public bool ways { get; set; }


    }
}