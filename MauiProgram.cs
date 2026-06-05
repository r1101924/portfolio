using Microsoft.Extensions.Logging;

namespace Tussentijdsexamen
{
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
#endif

            builder.Services.AddSingleton<HomeViewModel>();
            builder.Services.AddSingleton<HomePage>();
            builder.Services.AddSingleton<StudentViewModel>();
            builder.Services.AddSingleton<DetailsStudentPage>();
            builder.Services.AddSingleton<DocentViewModel>();
            builder.Services.AddSingleton<DetailsDocentPage>();

            builder.Services.AddSingleton<IDocentRepository, DocentRepository>();
            builder.Services.AddSingleton<IStudentRepository, StudentRepository>();
            return builder.Build();
        }
    }
}
