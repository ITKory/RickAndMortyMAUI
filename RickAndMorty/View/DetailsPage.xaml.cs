using RickAndMorty.ViewModel;

namespace RickAndMorty.View;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(CharacterDetailsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
	}
}