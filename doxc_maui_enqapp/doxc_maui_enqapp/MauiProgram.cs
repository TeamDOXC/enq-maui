using doxc_maui_enqapp.Pages;
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

		builder.Services.AddSingleton<IEnqAppOpenAPIClient, EnqAppOpenAPIClient>();

		builder.Services.AddTransient<MainPage>();
		builder.Services.AddTransient<ProfileMgmt>();


		builder.Services.AddTransient<CompanyProfileViewModel>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
