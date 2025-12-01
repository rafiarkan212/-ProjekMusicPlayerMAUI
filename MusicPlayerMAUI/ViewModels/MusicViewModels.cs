using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using MusicPlayerMAUI.Models;
using MusicPlayerMAUI.Services;


namespace MusicPlayerMAUI.ViewModels;

public class MusicViewModels : INotifyPropertyChanged
{
    readonly AudioService _audio;


    public ObservableCollection<Song> Songs { get; }


    Song _currentSong;
    public Song CurrentSong
    {
        get => _currentSong;
        set { _currentSong = value; OnPropertyChanged(nameof(CurrentSong)); }
    }


    double _position;
    public double Position
    {
        get => _position; set { _position = value; OnPropertyChanged(nameof(Position)); }
    }

    public ICommand PlayPauseCommand { get; }
    public ICommand NextCommand { get; }
    public ICommand PreviousCommand { get; }


    public MusicViewModels(AudioService audio)
    {
        _audio = audio;


        Songs = new ObservableCollection<Song>
{
new Song{ Id="1", Title="Song A", Artist="Artist A", Cover="cover1.jpg", Duration=240, FilePath=string.Empty},
new Song{ Id="2", Title="Song B", Artist="Artist B", Cover="cover2.jpg", Duration=200, FilePath=string.Empty}
};

        CurrentSong = Songs[0];

        PlayPauseCommand = new Command(async () =>
        {
            if (_audio.IsPlaying)
            {
                await _audio.Pause();
            }
            else
            {
                await _audio.Play(CurrentSong);
            }
            OnPropertyChanged(nameof(IsPlaying));
        });

        NextCommand = new Command(() =>
        {
            var idx = Songs.IndexOf(CurrentSong);
            if (idx < Songs.Count - 1) CurrentSong = Songs[idx + 1];
        });

        PreviousCommand = new Command(() =>
        {
            var idx = Songs.IndexOf(CurrentSong);
            if (idx > 0) CurrentSong = Songs[idx - 1];
        });
    }

    public bool IsPlaying => _audio.IsPlaying;


    public event PropertyChangedEventHandler? PropertyChanged;
    void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}