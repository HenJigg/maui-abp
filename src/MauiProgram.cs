namespace AppFramework;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder.UsePrismApp<App>(prism => prism
                .RegisterTypes(services => services.ConfigureServices())
                .ConfigureServices(services =>
                {
                    services.AddAutoMapper(config =>
                    {
                        config.AddProfile<AppMapper>(); 
                    });
                })
                .OnAppStart(navigationService => navigationService.CreateBuilder()
                .AddNavigationSegment<SplashViewModel>()
                .Navigate(HandleNavigationError)))
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Montserrat-Bold.ttf", "Montserrat-Bold");
                fonts.AddFont("Montserrat-Medium.ttf", "Montserrat-Medium");
                fonts.AddFont("Montserrat-Regular.ttf", "Montserrat-Regular");
                fonts.AddFont("Montserrat-SemiBold.ttf", "Montserrat-SemiBold");
                fonts.AddFont("UIFontIcons.ttf", "FontIcons");
                fonts.AddFont("iconfont.ttf", "iconfont");
            });

        return builder.Build();
    }

    private static void HandleNavigationError(Exception ex)
    {
        Console.WriteLine(ex);
        System.Diagnostics.Debugger.Break();
    }
}