using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.DB
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        public string USerName { get; set; }
        public string Password { get; set; }
    }
}