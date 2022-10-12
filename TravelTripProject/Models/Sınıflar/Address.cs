using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Sınıflar
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AddressDetail { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
    }
}