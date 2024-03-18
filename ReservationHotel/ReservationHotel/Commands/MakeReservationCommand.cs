using ReservationHotel.Models;
using ReservationHotel.Services;
using ReservationHotel.ViewModels;
using System.Windows;

namespace ReservationHotel.Commands
{
    public sealed class MakeReservationCommand : CommandBase
    {
        private readonly MakeReservationViewModel _makeReservationViewModel;
        private readonly Hotel _hotel;
        private readonly NavigationService _reservationNavigateionService;

        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, Hotel hotel, NavigationService reservationNavigateionService)
        {
            _makeReservationViewModel = makeReservationViewModel;
            _hotel = hotel;
            _reservationNavigateionService = reservationNavigateionService;
            _makeReservationViewModel.PropertyChanged += _makeReservationViewModel_PropertyChanged;
        }

        private void _makeReservationViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(MakeReservationViewModel.UserName))
            {
                OnCanExecuteChanged();
            }
        }

        public override void Execute(object? parameter)
        {
            var reservation = new Reservation(new RoomID(_makeReservationViewModel.FloorNumber, _makeReservationViewModel.RoomNumber),
                _makeReservationViewModel.UserName, _makeReservationViewModel.StartDate, _makeReservationViewModel.EndDate);

            _hotel.MakeReservation(reservation);

            MessageBox.Show("Reservation succeded!");

            _reservationNavigateionService.Navigate();
        }

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_makeReservationViewModel.UserName) && base.CanExecute(parameter);
        }
    }
}
