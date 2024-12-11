using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-CFA56CN;initial catalog=ApiDb;integrated security=true;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Room>().ToTable(tb => tb.HasTrigger("RoomDecrease")).ToTable(tb => tb.HasTrigger("RoomIncrease"));
            modelBuilder.Entity<Staff>().ToTable(tb => tb.HasTrigger("StaffDecrease")).ToTable(tb => tb.HasTrigger("StaffIncrease"));
            modelBuilder.Entity<Guest>().ToTable(tb => tb.HasTrigger("GuestDecrease")).ToTable(tb => tb.HasTrigger("GuestIncrease"));


        }

        public DbSet<Room> Rooms { get; set; }  
        public DbSet<Service> Services { get; set; }  
        public DbSet<Staff> Staffs { get; set; }  
        public DbSet<Subscribe> Subscribes { get; set; }  
        public DbSet<Testimonial> Testimonials { get; set; }  
        public DbSet<About> Abouts { get; set; }  
        public DbSet<Booking> Bookings { get; set; }  
        public DbSet<Guest> Guests { get; set; }  
        public DbSet<Contact> Contacts { get; set; }  
        public DbSet<SendMessage> SendMessages { get; set; }  
        public DbSet<MessageCategory> MessageCategories { get; set; }  
        public DbSet<WorkLocation> WorkLocations { get; set; }  
    }
}
