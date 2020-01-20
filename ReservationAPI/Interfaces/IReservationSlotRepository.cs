using ReservationAPI.Database.Entities;
using System.Collections.Generic;

namespace ReservationAPI.Interfaces
{
    public interface IReservationSlotRepository
    {
        IEnumerable<ReservationSlot> GetAvailableReservationSlots();
    }
}
