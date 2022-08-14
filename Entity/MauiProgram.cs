using Microsoft.AspNetCore.Components.WebView.Maui;
using Entity.Data;

namespace Entity;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
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

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
        builder.Services
            .AddBlazorise(options =>
            {
                options.Immediate = true;
            })
            .AddBootstrapProviders()
            .AddFontAwesomeIcons();
        builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}
}
