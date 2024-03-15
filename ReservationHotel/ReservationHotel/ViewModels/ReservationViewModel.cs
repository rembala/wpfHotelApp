using ReservationHotel.Models;

namespace ReservationHotel.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {
        private readonly Reservation _reservation;

        public string RoomID => _reservation.RoomID?.ToString();

        public string UserName => _reservation.UserName;

        public string StartTime => _reservation.StartTime.Date.ToString("d");

        public string EndTime  => _reservation.EndTime.Date.ToString("d");

        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
    }
}
