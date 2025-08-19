using hovan_ibehcrossplat.Pages;

using hovan_ibehcrossplat.ViewModels;

using Microsoft.Maui.Controls;

namespace hovan_ibehcrossplat;

public static class MauiProgram

{

    public static MauiApp CreateMauiApp()

    {

        var builder = MauiApp.CreateBuilder();

        builder

            .UseMauiApp<App>()

            .ConfigureFonts(fonts =>

            {

                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");

            });

        // Register ViewModels

        builder.Services.AddSingleton<GameViewModel>();

        builder.Services.AddSingleton<HistoryViewModel>();

        builder.Services.AddSingleton<SettingsViewModel>();

        // Register Pages

        builder.Services.AddSingleton<GamePage>();

        builder.Services.AddSingleton<HistoryPage>();

        builder.Services.AddSingleton<SettingsPage>();

        return builder.Build();

    }

}
