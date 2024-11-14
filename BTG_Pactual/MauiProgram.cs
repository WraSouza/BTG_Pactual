using BTG_Pactual.Repository;
using BTG_Pactual.View;
using BTG_Pactual.ViewModel;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace BTG_Pactual
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<FirstViewModel>();
            builder.Services.AddSingleton<AddClientViewModel>();
            builder.Services.AddSingleton<EditClientViewModel>();

            builder.Services.AddSingleton<IClientRepository, ClientRepository>();


            builder.Services.AddSingleton<FirstView>();
            builder.Services.AddSingleton<AddClientView>();
            builder.Services.AddSingleton<EditClientView>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
