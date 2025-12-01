using MusicPlayerMAUI.ViewModels;   

namespace MusicPlayerMAUI.Views;

    public partial class PlaylistPage : ContentPage
    {
        public PlaylistPage(MusicViewModels vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }

