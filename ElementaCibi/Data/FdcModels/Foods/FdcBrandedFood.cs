using System.Text.Json.Serialization;

namespace ElementaCibi.Data.FdcModels.Foods
{
    public class FdcBrandedFood: FdcFood
    {
        [JsonPropertyName("discontinuedDate")]
        public string DiscontinuedDate { get; set; } = string.Empty;

        [JsonPropertyName("modifiedDate")]
        public string ModifiedDate { get; set; } = string.Empty;

        [JsonPropertyName("availableDate")]
        public string AvailableDate { get; set; } = string.Empty;

        [JsonPropertyName("brandOwner")]
        public string BrandOwner { get; set; } = string.Empty;

        [JsonPropertyName("brandName")]
        public string BrandName { get; set; } = string.Empty;

        [JsonPropertyName("dataSource")]
        public string DataSource { get; set; } = string.Empty;

        [JsonPropertyName("brandedFoodCategory")]
        public string BrandedFoodCategory { get; set; } = string.Empty;

        [JsonPropertyName("gtinUpc")]
        public string GtinUpc { get; set; } = string.Empty;

        [JsonPropertyName("ingredients")]
        public string Ingredients { get; set; } = string.Empty;

        [JsonPropertyName("marketCountry")]
        public string MarketCountry { get; set; } = string.Empty;

        [JsonPropertyName("servingSize")]
        public float ServingSize { get; set; }

        [JsonPropertyName("servingSizeUnit")]
        public string ServingSizeUnit { get; set; } = string.Empty;

        [JsonPropertyName("foodUpdateLog")]
        public List<FoodUpdateLog> FoodUpdateLog { get; set; } = new List<FoodUpdateLog>();

        [JsonPropertyName("labelNutrients")]
        public LabelNutrients? LabelNutrients { get; set; }
    }

    public class FoodUpdateLog
    {
        [JsonPropertyName("discontinuedDate")]
        public string DiscontinuedDate { get; set; } = string.Empty;

        [JsonPropertyName("foodAttributes")]
        public List<FoodAttribute>? FoodAttributes { get; set; }

        [JsonPropertyName("fdcId")]
        public int FdcId { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("publicationDate")]
        public string PublicationDate { get; set; } = string.Empty;

        [JsonPropertyName("dataType")]
        public string DataType { get; set; } = string.Empty;

        [JsonPropertyName("foodClass")]
        public string FoodClass { get; set; } = string.Empty;

        [JsonPropertyName("modifiedDate")]
        public string ModifiedDate { get; set; } = string.Empty;

        [JsonPropertyName("availableDate")]
        public string AvailableDate { get; set; } = string.Empty;

        [JsonPropertyName("brandOwner")]
        public string BrandOwner { get; set; } = string.Empty;

        [JsonPropertyName("brandName")]
        public string BrandName { get; set; } = string.Empty;

        [JsonPropertyName("dataSource")]
        public string DataSource { get; set; } = string.Empty;

        [JsonPropertyName("brandedFoodCategory")]
        public string BrandedFoodCategory { get; set; } = string.Empty;

        [JsonPropertyName("gtinUpc")]
        public string GtinUpc { get; set; } = string.Empty;

        [JsonPropertyName("ingredients")]
        public string Ingredients { get; set; } = string.Empty;

        [JsonPropertyName("marketCountry")]
        public string MarketCountry { get; set; } = string.Empty;

        [JsonPropertyName("servingSize")]
        public float ServingSize { get; set; }

        [JsonPropertyName("servingSizeUnit")]
        public string ServingSizeUnit { get; set; } = string.Empty;

        [JsonPropertyName("subbrandName")]
        public string SubbrandName { get; set; } = string.Empty;

        [JsonPropertyName("packageWeight")]
        public string PackageWeight { get; set; } = string.Empty;

        [JsonPropertyName("notaSignificantSourceOf")]
        public string NotaSignificantSourceOf { get; set; } = string.Empty;
    }

    public class LabelNutrients
    {
        [JsonPropertyName("fat")]
        public Fat? Fat { get; set; }

        [JsonPropertyName("saturatedFat")]
        public SaturatedFat? SaturatedFat { get; set; }

        [JsonPropertyName("transFat")]
        public TransFat? TransFat { get; set; }

        [JsonPropertyName("cholesterol")]
        public Cholesterol? Cholesterol { get; set; }

        [JsonPropertyName("sodium")]
        public Sodium? Sodium { get; set; }

        [JsonPropertyName("carbohydrates")]
        public Carbohydrates? Carbohydrates { get; set; }

        [JsonPropertyName("fiber")]
        public Fiber? Fiber { get; set; }

        [JsonPropertyName("sugars")]
        public Sugars? Sugars { get; set; }

        [JsonPropertyName("protein")]
        public Protein? Protein { get; set; }

        [JsonPropertyName("calcium")]
        public Calcium? Calcium { get; set; }

        [JsonPropertyName("iron")]
        public Iron? Iron { get; set; }

        [JsonPropertyName("potassium")]
        public Potassium? Potassium { get; set; }

        [JsonPropertyName("calories")]
        public Calories? Calories { get; set; }
    }

    public class Potassium
    {
        [JsonPropertyName("value")]
        public float Value { get; set; }
    }

    public class Protein
    {
        [JsonPropertyName("value")]
        public float Value { get; set; }
    }

    public class SaturatedFat
    {
        [JsonPropertyName("value")]
        public float Value { get; set; }
    }

    public class Sodium
    {
        [JsonPropertyName("value")]
        public float Value { get; set; }
    }

    public class Sugars
    {
        [JsonPropertyName("value")]
        public float Value { get; set; }
    }

    public class TransFat
    {
        [JsonPropertyName("value")]
        public float Value { get; set; }
    }

    public class Iron
    {
        [JsonPropertyName("value")]
        public float Value { get; set; }
    }

    public class Calcium
    {
        [JsonPropertyName("value")]
        public float Value { get; set; }
    }

    public class Calories
    {
        [JsonPropertyName("value")]
        public float Value { get; set; }
    }

    public class Carbohydrates
    {
        [JsonPropertyName("value")]
        public float Value { get; set; }
    }

    public class Cholesterol
    {
        [JsonPropertyName("value")]
        public float Value { get; set; }
    }

    public class Fat
    {
        [JsonPropertyName("value")]
        public float Value { get; set; }
    }

    public class Fiber
    {
        [JsonPropertyName("value")]
        public float Value { get; set; }
    }
}
