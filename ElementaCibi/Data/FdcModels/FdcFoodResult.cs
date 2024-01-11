using System.Text.Json.Serialization;

namespace ElementaCibi.Data.FdcModels
{
    public class FdcFoodResult
    {
        [JsonPropertyName("foodClass")]
        public string? FoodClass { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("foodNutrients")]
        public List<FoodNutrient>? FoodNutrients { get; set; }

        [JsonPropertyName("foodAttributes")]
        public List<FoodAttribute>? FoodAttributes { get; set; }

        [JsonPropertyName("foodCode")]
        public string? FoodCode { get; set; }

        [JsonPropertyName("startDate")]
        public string? StartDate { get; set; }

        [JsonPropertyName("endDate")]
        public string? EndDate { get; set; }

        [JsonPropertyName("wweiaFoodCategory")]
        public WweiaFoodCategory? WweiaFoodCategory { get; set; }

        [JsonPropertyName("fdcId")]
        public int? FdcId { get; set; }

        [JsonPropertyName("dataType")]
        public string? DataType { get; set; }

        [JsonPropertyName("publicationDate")]
        public string? PublicationDate { get; set; }

        [JsonPropertyName("inputFoods")]
        public List<InputFood>? InputFoods { get; set; }
    }

    public class FoodAttribute
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("foodAttributeType")]
        public FoodAttributeType? FoodAttributeType { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("rank")]
        public int? Rank { get; set; }
    }

    public class FoodAttributeType
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }

    public class FoodNutrient
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("nutrient")]
        public Nutrient? Nutrient { get; set; }

        [JsonPropertyName("amount")]
        public double? Amount { get; set; }
    }

    public class Nutrient
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("number")]
        public string? Number { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("rank")]
        public int? Rank { get; set; }

        [JsonPropertyName("unitName")]
        public string? UnitName { get; set; }
    }

    public class WweiaFoodCategory
    {
        [JsonPropertyName("wweiaFoodCategoryCode")]
        public int? WweiaFoodCategoryCode { get; set; }

        [JsonPropertyName("wweiaFoodCategoryDescription")]
        public string? WweiaFoodCategoryDescription { get; set; }
    }

    public class InputFood
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("unit")]
        public string? Unit { get; set; }

        [JsonPropertyName("portionDescription")]
        public string? PortionDescription { get; set; }

        [JsonPropertyName("portionCode")]
        public string? PortionCode { get; set; }

        [JsonPropertyName("foodDescription")]
        public string? FoodDescription { get; set; }

        [JsonPropertyName("amount")]
        public double? Amount { get; set; }

        [JsonPropertyName("ingredientCode")]
        public int? IngredientCode { get; set; }

        [JsonPropertyName("ingredientDescription")]
        public string? IngredientDescription { get; set; }

        [JsonPropertyName("ingredientWeight")]
        public double? IngredientWeight { get; set; }

        [JsonPropertyName("sequenceNumber")]
        public int? SequenceNumber { get; set; }
    }
}
