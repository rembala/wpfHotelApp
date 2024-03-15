using ReservationHotel.Commands;
using ReservationHotel.Models;
using System.Windows.Input;

namespace ReservationHotel.ViewModels
{
    public class MakeReservationViewModel : ViewModelBase
    {
        private string _userName;

        public string UserName {
            get {
                return _userName;
            }

            set {
                _userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        private int _floorNumber = 1;

        public int FloorNumber
        {
            get
            {
                return _floorNumber;
            }

            set
            {
                _floorNumber = value;
                OnPropertyChanged(nameof(FloorNumber));
            }
        }

        private int _roomNumber = 16;
        public int RoomNumber
        {
            get
            {
                return _roomNumber;
            }

            set
            {
                _roomNumber = value;
                OnPropertyChanged(nameof(RoomNumber));
            }
        }

        private DateTime _startDate;
        public DateTime StartDate
        {
            get
            {
                return _startDate;
            }

            set
            {
                _startDate = value;
                OnPropertyChanged(nameof(StartDate));
            }
        }

        private DateTime _endDate;
        public DateTime EndDate
        {
            get
            {
                return _endDate;
            }

            set
            {
                _endDate = value;
                OnPropertyChanged(nameof(EndDate));
            }
        }

        public ICommand SubmitCommand {get; }
        public ICommand CancelCommand { get; }

        public MakeReservationViewModel(Hotel hotel)
        {
            SubmitCommand = new MakeReservationCommand(this, hotel);
        }
    }
}
