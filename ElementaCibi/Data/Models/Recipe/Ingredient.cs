using ElementaCibi.Data.FdcModels.Foods;
using ElementaCibi.Shared.Components;
using System.Text.Json.Serialization;

namespace ElementaCibi.Data.Models.Recipe
{
    public class Ingredient
    {
        public Guid Id { get; set; }
        public Food Food { get; set; } = new Food();
        public Portion Portion { get; set; } = new Portion();
        public float Quantity { get; set; }

        public float Calories
        {
            get
            {
                if (Food.Calories != null)
                {
                    //If grams are equal to 0 then the food is likely a branded food and we want the ratio to then be 1 since there are no portion sizes for branded foods
                    var grams = Portion.Grams == 0 ? 100 : Portion.Grams;
                    var caloriesPerHundredGrams = Food.Calories.Amount;
                    var ratio = grams / 100f;
                    return caloriesPerHundredGrams * ratio * Quantity;
                }
                return 0;
            }
        }

        public float Fiber
        {
            get
            {
                if (Food.Fiber != null)
                {
                    //If grams are equal to 0 then the food is likely a branded food and we want the ratio to then be 1 since there are no portion sizes for branded foods
                    var grams = Portion.Grams == 0 ? 100 : Portion.Grams;
                    var caloriesPerHundredGrams = Food.Fiber.Amount;
                    var ratio = grams / 100f;
                    return caloriesPerHundredGrams * ratio * Quantity;
                }
                return 0;
            }
        }

        [JsonNumberHandling(JsonNumberHandling.AllowNamedFloatingPointLiterals)]
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
