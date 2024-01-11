using System.ComponentModel.DataAnnotations;

namespace ElementaCibi.Data.Models
{
    public class FoodSearch
    {
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Term { get; set; } = string.Empty;
    }
}
