using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ReservationAPI.Database;
using ReservationAPI.Database.Entities;
using ReservationAPI.Interfaces;

namespace ReservationAPI.Controllers
{
    [Route("api/[controller]")]
    public class ReservationsController : Controller
    {
        private readonly IReservationSlotRepository _reservationSlotRepository;
        private readonly IReservationRepository _reservationRepository;


        public ReservationsController(IReservationSlotRepository reservationSlotRepository, IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
            _reservationSlotRepository = reservationSlotRepository;
        }

        [HttpGet]
        public string Get()
        {
            return "Reservation API";
        }

        [HttpGet("available-slots")]
        public IEnumerable<ReservationSlot> GetAvailableSlots()
        {
            return _reservationSlotRepository.GetAvailableReservationSlots();
        }

        [HttpPost]
        public IActionResult Post([FromBody]Reservation reservation)
        {
            if (reservation == null)
            {
                return BadRequest();
            }

            _reservationRepository.MakeReservation(reservation);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if(id > 0)
            {
                _reservationRepository.CancelReservation(id);
                return Ok();
            }

            return BadRequest();
        }
    }
}
