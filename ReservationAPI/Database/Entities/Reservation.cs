namespace ReservationAPI.Database.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public virtual ReservationSlot ReservationSlot { get; set; }
        public string Username { get; set; }
    }
}
