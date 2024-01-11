using System.Text.Json.Serialization;

namespace ElementaCibi.Data.FdcModels
{
    public class FdcBrandedFoodResult: FdcFoodResult
    {

        [JsonPropertyName("brandOwner")]
        public string? BrandOwner { get; set; }

        [JsonPropertyName("brandName")]
        public string? BrandName { get; set; }

        [JsonPropertyName("brandedFoodCategory")]
        public string? BrandedFoodCategory { get; set; }

        [JsonPropertyName("gtinUpc")]
        public string? GtinUpc { get; set; }

        [JsonPropertyName("householdServingFullText")]
        public string? HouseholdServingFullText { get; set; }

        [JsonPropertyName("ingredients")]
        public string? Ingredients { get; set; }

        [JsonPropertyName("marketCountry")]
        public string? MarketCountry { get; set; }

        [JsonPropertyName("servingSize")]
        public double? ServingSize { get; set; }

        [JsonPropertyName("servingSizeUnit")]
        public string? ServingSizeUnit { get; set; }

        [JsonPropertyName("packageWeight")]
        public string? PackageWeight { get; set; }

        [JsonPropertyName("notaSignificantSourceOf")]
        public string? NotaSignificantSourceOf { get; set; }

        [JsonPropertyName("foodUpdateLog")]
        public List<FoodUpdateLog>? FoodUpdateLog { get; set; }

        [JsonPropertyName("labelNutrients")]
        public LabelNutrients? LabelNutrients { get; set; }
    }


    public class AddedSugar
    {
        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }

    public class Carbohydrates
    {
        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }

    public class Fat
    {
        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }

    public class FoodUpdateLog
    {
        [JsonPropertyName("discontinuedDate")]
        public string? DiscontinuedDate { get; set; }

        [JsonPropertyName("foodAttributes")]
        public List<object>? FoodAttributes { get; set; }

        [JsonPropertyName("fdcId")]
        public int? FdcId { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("publicationDate")]
        public string? PublicationDate { get; set; }

        [JsonPropertyName("dataType")]
        public string? DataType { get; set; }

        [JsonPropertyName("foodClass")]
        public string? FoodClass { get; set; }

        [JsonPropertyName("shortDescription")]
        public string? ShortDescription { get; set; }

        [JsonPropertyName("modifiedDate")]
        public string? ModifiedDate { get; set; }

        [JsonPropertyName("availableDate")]
        public string? AvailableDate { get; set; }

        [JsonPropertyName("brandOwner")]
        public string? BrandOwner { get; set; }

        [JsonPropertyName("brandName")]
        public string? BrandName { get; set; }

        [JsonPropertyName("dataSource")]
        public string? DataSource { get; set; }

        [JsonPropertyName("brandedFoodCategory")]
        public string? BrandedFoodCategory { get; set; }

        [JsonPropertyName("gtinUpc")]
        public string? GtinUpc { get; set; }

        [JsonPropertyName("householdServingFullText")]
        public string? HouseholdServingFullText { get; set; }

        [JsonPropertyName("ingredients")]
        public string? Ingredients { get; set; }

        [JsonPropertyName("marketCountry")]
        public string? MarketCountry { get; set; }

        [JsonPropertyName("servingSize")]
        public double? ServingSize { get; set; }

        [JsonPropertyName("servingSizeUnit")]
        public string? ServingSizeUnit { get; set; }

        [JsonPropertyName("packageWeight")]
        public string? PackageWeight { get; set; }

        [JsonPropertyName("notaSignificantSourceOf")]
        public string? NotaSignificantSourceOf { get; set; }
    }

    public class LabelNutrients
    {
        [JsonPropertyName("fat")]
        public Fat? Fat { get; set; }

        [JsonPropertyName("sodium")]
        public Sodium? Sodium { get; set; }

        [JsonPropertyName("carbohydrates")]
        public Carbohydrates? Carbohydrates { get; set; }

        [JsonPropertyName("sugars")]
        public Sugars? Sugars { get; set; }

        [JsonPropertyName("protein")]
        public Protein? Protein { get; set; }

        [JsonPropertyName("addedSugar")]
        public AddedSugar? AddedSugar { get; set; }
    }

    public class Protein
    {
        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }

    public class Sodium
    {
        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }

    public class Sugars
    {
        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }
}
