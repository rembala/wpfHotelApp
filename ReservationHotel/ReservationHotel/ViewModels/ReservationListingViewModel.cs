using ReservationHotel.Commands;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ReservationHotel.ViewModels
{
    public sealed class ReservationListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations;

        public IEnumerable<ReservationViewModel> Reservations { get; set; }
        
        public ICommand MakeReservationCommand {get; }

        public ReservationListingViewModel()
        {
            _reservations =
            [
                new ReservationViewModel(new Models.Reservation(new Models.RoomID(1, 2), "SingletonSean", DateTime.Now, DateTime.Now + TimeSpan.FromDays(1))),
                new ReservationViewModel(new Models.Reservation(new Models.RoomID(3, 2), "Joe", DateTime.Now, DateTime.Now + TimeSpan.FromDays(1))),
                new ReservationViewModel(new Models.Reservation(new Models.RoomID(2, 4), "Mary", DateTime.Now, DateTime.Now + TimeSpan.FromDays(1))),
            ];

            MakeReservationCommand = new NavigateCommand();
        }
    }
}
