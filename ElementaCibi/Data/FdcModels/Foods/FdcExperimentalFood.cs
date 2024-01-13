using System.Text.Json.Serialization;

namespace ElementaCibi.Data.FdcModels.Foods
{
    public class FdcExperimentalFood: FdcFood
    {
        [JsonPropertyName("abstract")]
        public string Abstract { get; set; } = string.Empty;

        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("doiNumber")]
        public string DoiNumber { get; set; } = string.Empty;

        [JsonPropertyName("doiUrl")]
        public string DoiUrl { get; set; } = string.Empty;

        [JsonPropertyName("studyDesign")]
        public string StudyDesign { get; set; } = string.Empty;

        [JsonPropertyName("results")]
        public string Results { get; set; } = string.Empty;

        [JsonPropertyName("authors")]
        public List<Author> Authors { get; set; } = new List<Author>();

        [JsonPropertyName("affiliations")]
        public List<Affiliation> Affiliations { get; set; } = new List<Affiliation>();
    }

    public class Affiliation
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("id")]
        public int Id { get; set; }
    }

    public class Author
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("rank")]
        public int? Rank { get; set; }
    }
}
