namespace ReservationHotel.Models
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;

        public string Name {get; }

        public Hotel(string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }

        public IEnumerable<Reservation> GetReservations() {
            return _reservationBook.GetReservationsForUser();
        }

        public void MakeReservation(Reservation reservation) {
            _reservationBook.AddReservation(reservation);
        }
    }
}
