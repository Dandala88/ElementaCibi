using ElementaCibi.Data.Models;
using System.Text.Json;
using ElementaCibi.Data.FdcModels.Search;

namespace ElementaCibi.Data.Services
{
    public class FoodDataCentralService
    {
        private const string FdcUrl = "https://api.nal.usda.gov";
        private readonly HttpClient _fdcApiClient;
        private readonly string _fdcApiKey;

        public FoodDataCentralService(IConfiguration configuration)
        {
            _fdcApiClient = new HttpClient
            {
                BaseAddress = new Uri(FdcUrl),
            };

            _fdcApiKey = configuration.GetSection("FdcApiKey").Value;
        }

        public async Task<SearchResult?> GetFoodBySearchTerm(FoodSearch foodSearch)
        {
            var response = await _fdcApiClient.GetAsync($"fdc/v1/foods/search?query={foodSearch.Term}&api_key={_fdcApiKey}");
            var content = await response.Content.ReadAsStringAsync();
            var foodSearchResult = JsonSerializer.Deserialize<SearchResult>(content);

            return foodSearchResult;
        }
    }
}
