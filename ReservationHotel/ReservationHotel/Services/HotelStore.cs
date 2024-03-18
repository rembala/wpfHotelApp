using ReservationHotel.Models;

namespace ReservationHotel.Services
{
    public class HotelStore
    {
        private readonly List<Reservation> _reservations;
        private readonly Hotel _hotel;

        public IEnumerable<Reservation> Reservations => _reservations;

        public HotelStore(Hotel hotel)
        {
            _reservations = new List<Reservation>();
            _hotel = hotel;
        }

        public async Task Load() {
             var reservations = await Task.FromResult(_hotel.GetReservations());
            _reservations.Clear();
            _reservations.AddRange(reservations);
        }
    }
}
 