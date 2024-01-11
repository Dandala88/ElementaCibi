using ElementaCibi.Data.FdcModels.Search;

namespace ElementaCibi.Data.Models
{
    public class Food
    {
        public int? FdcId { get; set; }
        public string Description { get; set; } = string.Empty;
        public string DataType { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public Nutrient? Calories { get; set; }
        public Nutrient? Fiber { get; set; }

        public void FdcSearchToFood(SearchResultFood searchResultFood)
        {
            FdcId = searchResultFood.FdcId;
            Description = searchResultFood.Description ?? string.Empty;
            DataType = searchResultFood.DataType ?? string.Empty;
            Brand = searchResultFood.BrandOwner ?? string.Empty;

            if (searchResultFood?.FoodNutrients != null)
            {
                var calories = searchResultFood.FoodNutrients.Where(n => n.NutrientId == 1008)?.FirstOrDefault();

                if (calories?.Value != null)
                {
                    Calories = new Nutrient
                    {
                        Amount = calories.Value ?? 0.0,
                        Unit = calories.UnitName ?? string.Empty,
                    };
                }

                var fiber = searchResultFood.FoodNutrients.Where(n => n.NutrientId == 1079)?.FirstOrDefault();

                if (fiber?.Value != null)
                {
                    Fiber = new Nutrient
                    {
                        Amount = fiber.Value ?? 0.0,
                        Unit = fiber.UnitName ?? string.Empty,
                    };
                }
            }
        }
    }
}
