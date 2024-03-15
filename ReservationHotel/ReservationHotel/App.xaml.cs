using ReservationHotel.Models;
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

        public App()
        {
            _hotel = new Hotel("Singletonsaeen Suites");    
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_hotel)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
