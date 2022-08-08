﻿using RickAndMorty.Services;
using RickAndMorty.View;
using RickAndMorty.ViewModel;

namespace RickAndMorty;

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


		builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);

		builder.Services.AddSingleton<CharacterService>();

		builder.Services.AddSingleton<MainViewModel>();
		builder.Services.AddTransient<CharacterDetailsViewModel>();


		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddTransient<DetailsPage>();

		return builder.Build();
	}
}
