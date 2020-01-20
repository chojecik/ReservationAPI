using Microsoft.EntityFrameworkCore;
using ReservationAPI.Database;
using ReservationAPI.Database.Entities;
using ReservationAPI.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ReservationAPI.Repositories
{
    public class ReservationSlotRepository : IReservationSlotRepository
    {
        private readonly DataContext _context;

        public ReservationSlotRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<ReservationSlot> GetAvailableReservationSlots()
        {
            var usedReservationSlots = _context.Reservations
                .AsNoTracking()
                .Select(x => x.ReservationSlot.Id)
                .Distinct()
                .ToList();

            return _context.ReservationSlots
                .Where(x => !usedReservationSlots.Any(y => y == x.Id))
                .ToList();
        }
    }
}
