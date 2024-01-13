using System.Text.Json.Serialization;

namespace ElementaCibi.Data.FdcModels.Foods
{
    public class FdcFoundationFood: FdcFood
    {
        [JsonPropertyName("inputFoods")]
        public List<InputFoodFoundation> InputFoods { get; set; } = new List<InputFoodFoundation>();

        [JsonPropertyName("nutrientConversionFactors")]
        public List<NutrientConversionFactor> NutrientConversionFactors { get; set; } = new List<NutrientConversionFactor>();

        [JsonPropertyName("ndbNumber")]
        public int NdbNumber { get; set; }

        [JsonPropertyName("isHistoricalReference")]
        public bool IsHistoricalReference { get; set; }

        [JsonPropertyName("foodCategory")]
        public FoodCategory? FoodCategory { get; set; }
    }

    public class FoodGroup
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
    }

    public class InputFoodFoundation
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("foodDescription")]
        public string FoodDescription { get; set; } = string.Empty;

        [JsonPropertyName("inputFood")]
        public SampleFoodItem? InputFood { get; set; }
    }

    public class SampleFoodItem
    {
        [JsonPropertyName("fdcId")]
        public int FdcId { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("publicationDate")]
        public string PublicationDate { get; set; } = string.Empty;

        [JsonPropertyName("foodAttributeTypes")]
        public List<FoodCategory> FoodAttributeTypes { get; set; } = new List<FoodCategory>();

        [JsonPropertyName("foodClass")]
        public string FoodClass { get; set; } = string.Empty;

        [JsonPropertyName("totalRefuse")]
        public int TotalRefuse { get; set; }

        [JsonPropertyName("dataType")]
        public string DataType { get; set; } = string.Empty;

        [JsonPropertyName("foodGroup")]
        public FoodGroup? FoodGroup { get; set; }
    }
}
