using System.Text.Json.Serialization;

namespace ElementaCibi.Data.FdcModels.Foods
{
    public class FdcSurveyFood: FdcFood
    {
        [JsonPropertyName("foodCode")]
        public string FoodCode { get; set; } = string.Empty;

        [JsonPropertyName("startDate")]
        public string StartDate { get; set; } = string.Empty;

        [JsonPropertyName("endDate")]
        public string EndDate { get; set; } = string.Empty;

        [JsonPropertyName("wweiaFoodCategory")]
        public WweiaFoodCategory? WweiaFoodCategory { get; set; }

        [JsonPropertyName("inputFoods")]
        public List<InputFoodSurvey> InputFoods { get; set; } = new List<InputFoodSurvey>();
    }
}
