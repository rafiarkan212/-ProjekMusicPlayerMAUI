namespace MusicPlayerMAUI.Models;


public class Song
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Artist { get; set; }
    public string Cover { get; set; } // filename in Resources/Images
    public double Duration { get; set; } // seconds
    public string FilePath { get; set; } // local or remote uri
}