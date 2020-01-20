using System;

namespace ReservationAPI.Database.Entities
{
    public class ReservationSlot
    {
        public int Id { get; set; }
        public string Resource { get; set; }
        public DateTime ReservationDate { get; set; }
    }
}
