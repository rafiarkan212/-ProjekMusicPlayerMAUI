using System.ComponentModel;
using System.Windows.Input;


namespace MusicPlayerMAUI.ViewModels;

public class SettingsViewModels : INotifyPropertyChanged
{
    bool _darkModeEnabled;
    public bool DarkModeEnabled { get => _darkModeEnabled; set { _darkModeEnabled = value; OnPropertyChanged(nameof(DarkModeEnabled)); } }


    bool _notificationsEnabled;
    public bool NotificationsEnabled { get => _notificationsEnabled; set { _notificationsEnabled = value; OnPropertyChanged(nameof(NotificationsEnabled)); } }


    public ICommand ClearCacheCommand { get; }


    public SettingsViewModels()
    {
        ClearCacheCommand = new Command(() => {
            // implement cache clearing
        });
    }


    public event PropertyChangedEventHandler? PropertyChanged;
    void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}