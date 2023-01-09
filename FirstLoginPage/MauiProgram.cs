using FirstLoginPage.ViewModel;
using FirstLoginPage.Views;

namespace FirstLoginPage;

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

		builder.Services.AddSingleton<HomePage>();
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<ContactPage>();
        builder.Services.AddSingleton<AboutPage>();

        builder.Services.AddSingleton<LoginPageViewModel>();

        return builder.Build();
	}
}
