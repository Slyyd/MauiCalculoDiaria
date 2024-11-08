﻿using Microsoft.Extensions.Logging;

namespace MauiCalculoDiaria
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
                    fonts.AddFont("Exo-Italic-VariableFont_wght.ttf", "ExoItalic");
                    fonts.AddFont("Exo-VariableFont_wght.ttf", "Exo");
                    fonts.AddFont("VinaSans-Regular.ttf", "VinaSans");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
