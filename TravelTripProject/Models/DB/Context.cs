using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelTripProject.Models.DB
{
    public class Context: DbContext
    {
        public DbSet<Admin> admins { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Type> types { get; set; }
       
    }
}