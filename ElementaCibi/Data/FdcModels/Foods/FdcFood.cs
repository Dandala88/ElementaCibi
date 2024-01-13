using System.Text.Json.Serialization;

namespace ElementaCibi.Data.FdcModels.Foods
{
    public class FdcFood
    {
        [JsonPropertyName("fdcId")]
        public int FdcId { get; set; }

        [JsonPropertyName("foodClass")]
        public string FoodClass { get; set; } = string.Empty;

        [JsonPropertyName("dataType")]
        public string DataType { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("publicationDate")]
        public string PublicationDate { get; set; } = string.Empty;

        [JsonPropertyName("foodNutrients")]
        public List<FoodNutrient> FoodNutrients { get; set; } = new List<FoodNutrient>();

        //Commenting this out for now as food attribute values can be a string or float, causing deserialization issues
        //[JsonPropertyName("foodAttributes")]
        //public List<FoodAttribute> FoodAttributes { get; set; } = new List<FoodAttribute>();

        [JsonPropertyName("foodComponents")]
        public List<FoodComponent> FoodComponents { get; set; } = new List<FoodComponent>();

        [JsonPropertyName("foodPortions")]
        public List<FoodPortion> FoodPortions { get; set; } = new List<FoodPortion>();

    }

    public class FoodNutrient
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty ;

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nutrient")]
        public Nutrient? Nutrient { get; set; }

        [JsonPropertyName("amount")]
        public float Amount { get; set; }
    }

    public class FoodNutrientDerivation
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        public FoodNutrientSource? FoodNutrientSource { get; set; }
    }

    public class FoodNutrientSource
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
    }

    public class Nutrient
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("unitName")]
        public string UnitName { get; set; } = string.Empty;
    }

    public class FoodPortion
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("dataPoints")]
        public int DataPoints { get; set; }

        [JsonPropertyName("gramWeight")]
        public float GramWeight { get; set; }

        [JsonPropertyName("sequenceNumber")]
        public int? SequenceNumber { get; set; }

        //Amount is nullable because the survey data type has its amount data in InputFood
        [JsonPropertyName("amount")]
        public float? Amount { get; set; }

        [JsonPropertyName("modifier")]
        public string Modifier { get; set; } = string.Empty;

        [JsonPropertyName("minDateAcquired")]
        public string? MinDateAcquired { get; set; }

        [JsonPropertyName("measureUnit")]
        public MeasureUnit? MeasureUnit { get; set; }

        [JsonPropertyName("minYearAcquired")]
        public int? MinYearAcquired { get; set; }
    }

    public class MeasureUnit
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("abbreviation")]
        public string Abbreviation { get; set; } = string.Empty;
    }

    public class FoodAttribute
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("value")]
        public float Value { get; set; }

        [JsonPropertyName("foodAttributeType")]
        public FoodAttributeType? FoodAttributeType { get; set; }
    }

    public class FoodAttributeType
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
    }

    public class FoodComponent
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("dataPoints")]
        public int DataPoints { get; set; }

        [JsonPropertyName("gramWeight")]
        public float GramWeight { get; set; }

        [JsonPropertyName("isRefuse")]
        public bool IsRefuse { get; set; }

        [JsonPropertyName("minYearAcquired")]
        public int MinYearAcquired { get; set; }

        [JsonPropertyName("percentWeight")]
        public float PercentWeight { get; set; }
    }
    
    public class NutrientConversionFactor
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("proteinValue")]
        public float? ProteinValue { get; set; }

        [JsonPropertyName("fatValue")]
        public float? FatValue { get; set; }

        [JsonPropertyName("carbohydrateValue")]
        public float? CarbohydrateValue { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("value")]
        public float? Value { get; set; }
    }

    public class FoodCategory
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
    }

    public class InputFoodSurvey
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; } = string.Empty;

        [JsonPropertyName("portionDescription")]
        public string PortionDescription { get; set; } = string.Empty;

        [JsonPropertyName("portionCode")]
        public string PortionCode { get; set; } = string.Empty;

        [JsonPropertyName("foodDescription")]
        public string FoodDescription { get; set; } = string.Empty;

        [JsonPropertyName("amount")]
        public float Amount { get; set; }

        [JsonPropertyName("ingredientCode")]
        public int IngredientCode { get; set; }

        [JsonPropertyName("ingredientDescription")]
        public string IngredientDescription { get; set; } = string.Empty;

        [JsonPropertyName("ingredientWeight")]
        public float IngredientWeight { get; set; }

        [JsonPropertyName("sequenceNumber")]
        public int SequenceNumber { get; set; }
    }

    public class SurveyFoodItem
    {
        [JsonPropertyName("fdcId")]
        public int FdcId { get; set; }

        [JsonPropertyName("dataType")]
        public string DataType { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty; 
        
        [JsonPropertyName("endDate")]
        public string EndDate { get; set; } = string.Empty;

        [JsonPropertyName("foodClass")]
        public string FoodClass { get; set; } = string.Empty;

        [JsonPropertyName("foodCode")]
        public string FoodCode { get; set; } = string.Empty;

        [JsonPropertyName("publicationDate")]
        public string PublicationDate { get; set; } = string.Empty;

        [JsonPropertyName("startDate")]
        public string startDate { get; set; } = string.Empty;

        [JsonPropertyName("foodAttributeTypes")]
        public List<FoodAttribute> FoodAttributeTypes { get; set; } = new List<FoodAttribute>();

        [JsonPropertyName("foodPortions")]
        public List<FoodPortion> FoodPortions { get; set; } = new List<FoodPortion>();

        [JsonPropertyName("totalRefuse")]
        public int TotalRefuse { get; set; }

        [JsonPropertyName("wweiaFoodCategory")]
        public WweiaFoodCategory? WweiaFoodCategory { get; set; }
    }

    public class WweiaFoodCategory
    {
        [JsonPropertyName("wweiaFoodCategoryDescription")]
        public string WweiaFoodCategoryDescription { get; set; } = string.Empty;

        [JsonPropertyName("wweiaFoodCategoryCode")]
        public int WweiaFoodCategoryCode { get; set; }
    }
}
