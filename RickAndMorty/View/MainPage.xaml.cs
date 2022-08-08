using RickAndMorty.ViewModel;

namespace RickAndMorty.View;

public partial class MainPage : ContentPage
{


    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }


}

