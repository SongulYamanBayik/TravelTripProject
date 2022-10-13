using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.DB
{
    public class Type
    {
        
        public int TypeID { get; set; }
        public string TypeName { get; set; }
        public ICollection<Blog> blogs { get; set; }

    }
}