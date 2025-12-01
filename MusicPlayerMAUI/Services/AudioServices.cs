using System;
using System.Threading.Tasks;
using MusicPlayerMAUI.Models;


namespace MusicPlayerMAUI.Services;


// This is a minimal service — replace implementation with a proper audio library
public class AudioService
{
    public Song Current { get; private set; }
    public double Position { get; private set; }
    public bool IsPlaying { get; private set; }


    public event Action<double>? PositionChanged;
    public event Action? PlaybackEnded;


    public Task Play(Song song)
    {
        Current = song;
        IsPlaying = true;
        // TODO: hook into actual player
        return Task.CompletedTask;
    }


    public Task Pause()
    {
        IsPlaying = false;
        return Task.CompletedTask;
    }


    public Task Seek(double seconds)
    {
        Position = seconds;
        PositionChanged?.Invoke(Position);
        return Task.CompletedTask;
    }


    public Task Stop()
    {
        IsPlaying = false;
        Position = 0;
        return Task.CompletedTask;
    }
}