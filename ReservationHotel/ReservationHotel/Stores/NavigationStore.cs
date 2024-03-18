using ReservationHotel.ViewModels;

namespace ReservationHotel.Stores
{
    public class NavigationStore
    {
        public ViewModelBase _currentViewModel { get; set; }

        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;

            set { _currentViewModel = value;
                OnCurrentViewModeChanged();
            }
        }

        public event Action CurrentViewModelChanged;
            
        private void OnCurrentViewModeChanged() {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
