using doxc_maui_enqapp.Pages;
using doxc_maui_enqapp.Services;
using doxc_maui_enqapp.ViewModels;
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
			})
			.RegisterViewModels()
            .RegisterViews();

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

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}

	public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
	{
		mauiAppBuilder.Services.AddSingleton<ProfileMgmt>();
        mauiAppBuilder.Services.AddSingleton<MainPage>();
        return mauiAppBuilder;
	}

    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<CompanyProfileViewModel>();
        return mauiAppBuilder;
    }
}
