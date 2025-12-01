using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Extensions.DependencyInjection;
using CommunityToolkit.Maui;


namespace MusicPlayerMAUI;


public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
        .UseMauiApp<App>()
        .UseMauiCommunityToolkit()
        .UseMauiCommunityToolkitMediaElement()
        .ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
        });


        // register viewmodels & services
        builder.Services.AddSingleton<ViewModels.MusicViewModels>();
        builder.Services.AddSingleton<ViewModels.SettingsViewModels>();
        builder.Services.AddSingleton<Services.AudioService>();


        return builder.Build();
    }
}