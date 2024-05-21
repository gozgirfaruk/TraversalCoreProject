using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class TreversalContext : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-MT6QAH6\\SQLEXPRESS;initial catalog=TreversalDB; integrated security=true");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FeatureSmall> FeatureSmalls { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ReComment> ReComments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

    }
}
