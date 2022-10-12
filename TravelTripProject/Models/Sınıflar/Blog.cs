using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Sınıflar
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool LikeStatus { get; set; }
        public int TypeID { get; set; }
        public virtual Type Type { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}