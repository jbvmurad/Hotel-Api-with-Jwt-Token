using Microsoft.EntityFrameworkCore;
using PatikaÖdev.Entity;

namespace PatikaTask.Context
{
    public class PatikaContext :DbContext
    {
        public PatikaContext(DbContextOptions<PatikaContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasOne(c => c.Hotel)  
                .WithMany(h => h.Customers)
                .HasForeignKey(c => c.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Customer>()
                .HasOne(c => c.Room)
                .WithMany(r => r.Customers)  
                .HasForeignKey(c => c.RoomId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Hotel>()
                .HasOne(h => h.Location)
                .WithOne(l => l.Hotel)
                .HasForeignKey<Hotel>(h => h.LocationId)  
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Room>()
                .HasOne(r => r.Hotel)
                .WithMany(h => h.Rooms)
                .HasForeignKey(r => r.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Room>()
                .Property(r => r.Price)
                .HasPrecision(10, 2);
        }

    }
}
