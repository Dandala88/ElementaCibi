using System.ComponentModel.DataAnnotations;

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
    }
}
