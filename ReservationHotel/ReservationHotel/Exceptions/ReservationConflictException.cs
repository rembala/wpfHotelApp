using ReservationHotel.Models;

namespace ReservationHotel.Exceptions
{
    public class ReservationConflictException : Exception
    {
        public Reservation existingReservation { get; set; }
        public Reservation incomingReservation { get; set; }

        public ReservationConflictException()
        {
        }

        public ReservationConflictException(string? message, Reservation existingReservation, Reservation incomingReservation) : base(message)
        {
            this.existingReservation = existingReservation;
            this.incomingReservation = incomingReservation;
        }

        public ReservationConflictException(string? message, Exception? innerException, Reservation existingReservation, Reservation incomingReservation) : base(message, innerException)
        {
            this.existingReservation = existingReservation;
            this.incomingReservation = incomingReservation;
        }

        public ReservationConflictException(Reservation existingReservation, Reservation incomingReservation)
        {
            this.existingReservation = existingReservation;
            this.incomingReservation = incomingReservation;
        }
    }
}
