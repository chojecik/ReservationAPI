using ReservationAPI.Database.Entities;

namespace ReservationAPI.Interfaces
{
    public interface IReservationRepository
    {
        void MakeReservation(Reservation reservation);
        void CancelReservation(int id);

    }
}
