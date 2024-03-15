using ReservationHotel.Models;
using ReservationHotel.ViewModels;

namespace ReservationHotel.Commands
{
    public sealed class MakeReservationCommand : CommandBase
    {
        private readonly MakeReservationViewModel _makeReservationViewModel;
        private readonly Hotel _hotel;

        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, Hotel hotel)
        {
            _makeReservationViewModel = makeReservationViewModel;
            _hotel = hotel;
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
        }

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_makeReservationViewModel.UserName) && base.CanExecute(parameter);
        }
    }
}
