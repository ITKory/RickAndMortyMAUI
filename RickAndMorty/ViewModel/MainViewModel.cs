using RickAndMorty.Model;
using RickAndMorty.Services;
using RickAndMorty.View;

namespace RickAndMorty.ViewModel
{
    public partial class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Character> Characters { get; } = new();

        private CharacterService _characterService;
        private IConnectivity _connectivity;

        public MainViewModel(CharacterService characterService, IConnectivity connectivity)
        {
            Title = "Rick&Morty Characters";
            _characterService = characterService;
            _connectivity = connectivity;
        }


        [ObservableProperty]
        bool isRefreshing;

        [ObservableProperty]
        bool isDetailsVisible;

        [ObservableProperty]
        Character selectedCharacter;


        [RelayCommand]
        async Task GoToDetailsAsync(Character character)
        {
            if (character is null)
                return;
            else
            {
                SelectedCharacter = character;
                if (isDetailsVisible is false)
                    isDetailsVisible = true;
            }
            #if __MOBILE__
            await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true, new Dictionary<string, object>
            {
                {"Character",SelectedCharacter }
            });
            #endif

        }

        [RelayCommand]
        async Task GetCharactersAsync()
        {


            if (IsBusy)
                return;

            try
            {

                if (_connectivity.NetworkAccess != NetworkAccess.Internet)
                {
                    await Shell.Current.DisplayAlert("No connectivity", "Please check your network connection and try again.", "OK");
                    return;
                }

                IsBusy = true;
                var charactersList = await _characterService.GetCharacters(10);

                if (Characters.Count > 0)
                    Characters.Clear();

                foreach (var character in charactersList)
                    Characters.Add(character);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get monkeys: {ex.Message}");
                await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
                IsRefreshing = false;
            }

        }

    }
}
