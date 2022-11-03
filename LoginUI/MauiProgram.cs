using LoginUI.View.Dashboard;
using LoginUI.View.Startup;
using LoginUI.ViewModels.Dashboard;
using LoginUI.ViewModels.Startup;

namespace LoginUI;

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

		builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<LoginPageViewModel>();
		
		builder.Services.AddSingleton<LoadingPage>();
		builder.Services.AddSingleton<LoadingPageViewModel>();

        builder.Services.AddSingleton<DashboardPage>();
        builder.Services.AddSingleton<DashboardPageViewModel>();
        
		return builder.Build();
	}
}
