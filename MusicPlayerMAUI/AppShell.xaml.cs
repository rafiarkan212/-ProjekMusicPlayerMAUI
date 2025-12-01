namespace MusicPlayerMAUI
{
    public partial class AppShell : Shell
    {
        public AppShell MainPage { get; }
        public AppShell()
        {
            InitializeComponent();
            MainPage = new AppShell();

        }
    }
}
