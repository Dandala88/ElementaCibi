using ElementaCibi.Data.Models;
using System.Text.Json;
using ElementaCibi.Data.FdcModels.Search;
using ElementaCibi.Data.FdcModels;

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

        public async Task<FdcSearchResult?> GetFoodBySearchTerm(FoodSearch foodSearch)
        {
            var response = await _fdcApiClient.GetAsync($"fdc/v1/foods/search?query={foodSearch.Term}&api_key={_fdcApiKey}");
            var content = await response.Content.ReadAsStringAsync();
            var foodSearchResult = JsonSerializer.Deserialize<FdcSearchResult>(content);

            return foodSearchResult;
        }

        public async Task<FdcWholeFoodResult?> GetWholeFoodById(string id)
        {
            var response = await _fdcApiClient.GetAsync($"fdc/v1/food/{id}?api_key={_fdcApiKey}");
            var content = await response.Content.ReadAsStringAsync();
            var foodSearchResult = JsonSerializer.Deserialize<FdcWholeFoodResult>(content);

            return foodSearchResult;
        }

        public async Task<FdcBrandedFoodResult?> GetBrandedFoodById(string id)
        {
            var response = await _fdcApiClient.GetAsync($"fdc/v1/food/{id}?api_key={_fdcApiKey}");
            var content = await response.Content.ReadAsStringAsync();
            var foodSearchResult = JsonSerializer.Deserialize<FdcBrandedFoodResult>(content);

            return foodSearchResult;
        }
    }
}
