using EnqAppMAUI.Services.Identity;
using EnqAppMAUI.Services.MockService;
using EnqAppMAUI.Services.User;
using EnqAppMAUI.ViewModels;
using Microsoft.Extensions.Logging;

namespace EnqAppMAUI;

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

#if DEBUG
		builder.Logging.AddDebug();
		builder.RegisterAppMockService();
#endif
		builder.RegisterViewModels();
		builder.RegisterViews();
		return builder.Build();
	}

	public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
	{
        mauiAppBuilder.Services.AddSingleton<IAuthService, AuthService>();
		return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterAppMockService(this MauiAppBuilder mauiAppBuilder)
    {
		mauiAppBuilder.Services.AddTransient<IUserService, UserMockService>();
        return mauiAppBuilder;
    }
	public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
	{
		mauiAppBuilder.Services.AddTransient<MainPage>();
		return mauiAppBuilder;
	}

        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
	{
		mauiAppBuilder.Services.AddSingleton<MainViewModel>();
		return mauiAppBuilder;
	}
 }
