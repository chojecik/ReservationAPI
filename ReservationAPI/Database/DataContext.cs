using Microsoft.EntityFrameworkCore;
using ReservationAPI.Database.Entities;

namespace ReservationAPI.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }

        public DbSet<ReservationSlot> ReservationSlots { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
