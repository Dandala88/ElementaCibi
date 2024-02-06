using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ElementaCibi.Data.Models.Recipe
{
    public class Recipe
    {
        public Guid Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public float Calories 
        { 
            get
            {
                return Ingredients.Sum(i => i.Calories);
            }
        }

        public float Fiber
        {
            get
            {
                return Ingredients.Sum(i => i.Fiber);
            }
        }

        public float Ratio
        {
            get
            {
                return Fiber / Calories;
            }
        }

        [JsonNumberHandling(JsonNumberHandling.AllowNamedFloatingPointLiterals)]
        public float Hundred
        {
            get
            {
                return 100 / (Fiber / Calories);
            }
        }
    }
}
