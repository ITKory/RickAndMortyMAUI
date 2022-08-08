using Newtonsoft.Json;

using RickAndMorty.Model;

namespace RickAndMorty.Services
{
    public class CharacterService
    {
        private HttpClient _httpClient;
        private CharacterModel? _model;
        public CharacterService()
        {
            _httpClient = new();
        }
        public async Task<List<Character>> GetCharacters(int count)
        {

            if (_model?.Characters.Count > 0)
            {
                var nextResponse = await _httpClient.GetAsync($"{_model.Info.Next}");
                var nextData = JsonConvert.DeserializeObject<CharacterModel>(nextResponse.Content.ReadAsStringAsync().Result);

                _model.Characters.AddRange(nextData.Characters);
                _model.Info.Next = nextData.Info.Next;
                return _model.Characters;
            }

            var response = await _httpClient.GetAsync($"https://rickandmortyapi.com/api/character/");
            _model = JsonConvert.DeserializeObject<CharacterModel>(response.Content.ReadAsStringAsync().Result);
            return _model.Characters;


        }
    }
}
