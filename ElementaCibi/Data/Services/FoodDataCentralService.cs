using ElementaCibi.Data.Models;
using System.Text.Json;
using ElementaCibi.Data.FdcModels.Search;
using ElementaCibi.Data.FdcModels.Foods;
using ElementaCibi.Data.FdcModels.Constants;

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

        public async Task<Food?> GetFoodByIdAsync(string fdcId)
        {
            var food = new Food();
            var response = await _fdcApiClient.GetAsync($"fdc/v1/food/{fdcId}?api_key={_fdcApiKey}");
            var content = await response.Content.ReadAsStringAsync();
            var foodSearchResult = JsonSerializer.Deserialize<FdcFood>(content);
            if (foodSearchResult != null)
            {
                switch (foodSearchResult.DataType)
                {
                    case FdcDataType.Branded:
                        var fdcBrandedFood = JsonSerializer.Deserialize<FdcBrandedFood>(content);
                        if (fdcBrandedFood != null)
                        {
                            food.FdcBrandedFoodToFood(fdcBrandedFood);
                            return food;
                        }
                        break;
                    case FdcDataType.Foundation:
                        var fdcFoundationFood = JsonSerializer.Deserialize<FdcFoundationFood>(content);
                        if (fdcFoundationFood != null)
                        {
                            food.FdcFoundationFoodToFood(fdcFoundationFood);
                            return food;
                        }
                        break;
                    case FdcDataType.Legacy:
                        var fdcLegacyFood = JsonSerializer.Deserialize<FdcLegacyFood>(content);
                        if (fdcLegacyFood != null)
                        {
                            food.FdcLegacyFoodToFood(fdcLegacyFood);
                            return food;
                        }
                        break;
                    case FdcDataType.Survey:
                        var fdcSurveyFood = JsonSerializer.Deserialize<FdcSurveyFood>(content);
                        if (fdcSurveyFood != null)
                        {
                            food.FdcSurveyFoodToFood(fdcSurveyFood);
                            return food;
                        }
                        break;
                }
            }

            return null;
        }
    }
}
