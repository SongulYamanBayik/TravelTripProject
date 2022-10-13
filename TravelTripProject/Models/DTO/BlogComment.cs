using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelTripProject.Models.DB;

namespace TravelTripProject.Models.DTO
{
    public class BlogComment
    {
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<Comment> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }
        public IEnumerable<Comment> Deger4 { get; set; }

    }
}