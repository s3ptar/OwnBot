using Microsoft.Maui.Controls;

namespace maui_app
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        // Add additional methods for BLE connectivity here
    }
}