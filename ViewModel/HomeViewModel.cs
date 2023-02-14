using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Travel_Agency.Models;

namespace Travel_Agency.ViewModel
{
    public class HomeViewModel
    {
        public bool ways_flag=false;
        public List<Admin> Admins { get; set; }
        public List<Admin> Admins_back { get; set; }
    }
}