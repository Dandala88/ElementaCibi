using System.Text.Json.Serialization;

namespace ElementaCibi.Data.FdcModels.Foods
{
    public class FdcLegacyFood: FdcFood
    {

        [JsonPropertyName("scientificName")]
        public string ScientificName { get; set; } = string.Empty;

        [JsonPropertyName("nutrientConversionFactors")]
        public List<NutrientConversionFactor> NutrientConversionFactors { get; set; } = new List<NutrientConversionFactor>();

        [JsonPropertyName("inputFoods")]
        public List<InputFoodSurvey> InputFoods { get; set; } = new List<InputFoodSurvey>();

        [JsonPropertyName("ndbNumber")]
        public int NdbNumber { get; set; }

        [JsonPropertyName("isHistoricalReference")]
        public bool? IsHistoricalReference { get; set; }

        [JsonPropertyName("foodCategory")]
        public FoodCategory? FoodCategory { get; set; }
    }
}
