using ReservationAPI.Database;
using ReservationAPI.Database.Entities;
using ReservationAPI.Interfaces;
using System.Linq;

namespace ReservationAPI.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly DataContext _context;

        public ReservationRepository(DataContext context)
        {
            _context = context;
        }

        public void CancelReservation(int id)
        {
            var reservation = _context.Reservations.FirstOrDefault(x => x.Id == id);

            if(reservation != null)
            {
                _context.Reservations.Remove(reservation);
                _context.SaveChanges();
            }
        }

        public void MakeReservation(Reservation reservation)
        {
            _context.Reservations.Add(reservation);
            _context.SaveChanges();
        }
    }
}
