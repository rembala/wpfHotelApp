using ReservationHotel.Exceptions;

namespace ReservationHotel.Models
{
    public class ReservationBook
    {
        private List<Reservation> _reservations;

        public ReservationBook()
        {
            _reservations = new List<Reservation>();
        }

        public IEnumerable<Reservation> GetReservationsForUser() {
            return _reservations;
        }

        public void AddReservation(Reservation reservation) {
            foreach (var existingReservation in _reservations)
            {
                if (existingReservation.Conflicts(reservation))
                {
                    throw new ReservationConflictException(existingReservation, reservation);
                }
            }

            _reservations.Add(reservation);
        }
    }
}
