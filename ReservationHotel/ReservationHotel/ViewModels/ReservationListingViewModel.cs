using ReservationHotel.Commands;
using ReservationHotel.Models;
using ReservationHotel.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ReservationHotel.ViewModels
{
    public sealed class ReservationListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations = new ObservableCollection<ReservationViewModel>();
        private readonly Hotel _hotel;

        public ObservableCollection<ReservationViewModel> Reservations { get => _reservations; }
        
        public ICommand MakeReservationCommand {get; }

        public ReservationListingViewModel(Hotel hotel, NavigationService makeReservationService)
        {
            MakeReservationCommand = new NavigateCommand(makeReservationService);

            _hotel = hotel;
            UpdateReservations();
        }

        private void UpdateReservations()
        {
            _reservations.Clear();

            foreach (var item in _hotel.GetReservations())
            {
                var reser = new ReservationViewModel(item);
                _reservations.Add(reser);
            }
        }
    }
}
