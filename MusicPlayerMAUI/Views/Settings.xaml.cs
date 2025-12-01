using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace MusicPlayerMAUI
{
    internal partial class Settings : ContentPage
    {
        public Settings()
        {
            InitializeComponent();
        }

        // Add this method to resolve CS0103 if the XAML compiler did not generate it.
        // If your project does not use XAML for this page, you can remove the call to InitializeComponent().
        private void InitializeComponent()
        {
            // This method should be auto-generated if you have a corresponding Settings.xaml file.
            // If not, leave it empty or remove the call in the constructor.
        }
    }
}
