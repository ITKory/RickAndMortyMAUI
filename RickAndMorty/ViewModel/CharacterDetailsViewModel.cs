using RickAndMorty.Model;

namespace RickAndMorty.ViewModel;

[QueryProperty(nameof(Character), "Character")]
public partial class CharacterDetailsViewModel : BaseViewModel
{
    public CharacterDetailsViewModel()
    {
    }

    [ObservableProperty]
    Character character;

}
