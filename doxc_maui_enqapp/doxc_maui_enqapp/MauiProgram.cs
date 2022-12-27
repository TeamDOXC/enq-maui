using doxc_maui_enqapp.Pages;
using doxc_maui_enqapp.Services;
using doxc_maui_enqapp.ViewModels;
using EnqApp.OpenAPI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace doxc_maui_enqapp;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        HttpClient _client;
#if DEBUG
        HttpMessageHandler handler = new HttpsClientHandlerService().GetPlatformMessageHandler();
        if (handler != null)
            _client = new HttpClient(handler);
        else
            _client = new HttpClient();
#else
            _client = new HttpClient();
#endif

        builder.Services.AddSingleton<IEnqAppOpenAPIClient>(new EnqAppOpenAPIClient(_client));

		builder.Services.AddTransient<MainPage>();
		builder.Services.AddTransient<ProfileMgmt>();


		builder.Services.AddTransient<CompanyProfileViewModel>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
