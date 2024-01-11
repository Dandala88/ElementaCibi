using System.Text.Json.Serialization;

namespace ElementaCibi.Data.FdcModels
{
    public class FdcWholeFoodResult: FdcFoodResult
    {
        [JsonPropertyName("foodPortions")]
        public List<FoodPortion>? FoodPortions { get; set; }
    }

    public class FoodPortion
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("measureUnit")]
        public MeasureUnit? MeasureUnit { get; set; }

        [JsonPropertyName("modifier")]
        public string? Modifier { get; set; }

        [JsonPropertyName("gramWeight")]
        public double? GramWeight { get; set; }

        [JsonPropertyName("portionDescription")]
        public string? PortionDescription { get; set; }

        [JsonPropertyName("sequenceNumber")]
        public int? SequenceNumber { get; set; }
    }

    public class MeasureUnit
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("abbreviation")]
        public string? Abbreviation { get; set; }
    }
}
