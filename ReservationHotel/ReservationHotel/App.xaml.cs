using ReservationHotel.Models;
using ReservationHotel.Services;
using ReservationHotel.Stores;
using ReservationHotel.ViewModels;
using System.Windows;

namespace ReservationHotel
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Hotel _hotel;
        private readonly NavigationStore _navigationStore;

        public App()
        {
            _hotel = new Hotel("Singletonsaeen Suites");  
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = CreateReservationViewMOdel();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }

        private MakeReservationViewModel CreateMakeReservationViewMOdel() {
            return new MakeReservationViewModel(_hotel, new NavigationService(_navigationStore, CreateReservationViewMOdel));
        }

        private ReservationListingViewModel CreateReservationViewMOdel()
        {
            return new ReservationListingViewModel(_hotel, new NavigationService(_navigationStore, CreateMakeReservationViewMOdel));
        }
    }
}
