using ElementaCibi.Data.FdcModels;
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

        public void FdcSearchToFood(SearchResultFood fdcSearchResult)
        {
            FdcId = fdcSearchResult.FdcId;
            Description = fdcSearchResult.Description ?? string.Empty;
            DataType = fdcSearchResult.DataType ?? string.Empty;
            Brand = fdcSearchResult.BrandOwner ?? string.Empty;

            if (fdcSearchResult?.FoodNutrients != null)
            {
                var calories = fdcSearchResult.FoodNutrients.Where(n => n.NutrientId == NutrientCode.Calorie.Id)?.FirstOrDefault();

                if (calories?.Value != null)
                {
                    Calories = new Nutrient
                    {
                        Amount = calories.Value ?? 0.0,
                        Unit = calories.UnitName ?? string.Empty,
                    };
                }

                var fiber = fdcSearchResult.FoodNutrients.Where(n => n.NutrientId == NutrientCode.Fiber.Id)?.FirstOrDefault();

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

        public void FdcFoodToFood(FdcFoodResult fdcFoodResult)
        {
            if(fdcFoodResult.GetType() == typeof(FdcWholeFoodResult))
            {
                fdcFoodResult = (FdcWholeFoodResult)fdcFoodResult;
            }
            else
            {
                var fdcBrandedFoodResult = (FdcBrandedFoodResult)fdcFoodResult;
                Brand = fdcBrandedFoodResult.BrandOwner ?? string.Empty;
            }

            FdcId = fdcFoodResult.FdcId;
            Description = fdcFoodResult.Description ?? string.Empty;
            DataType = fdcFoodResult.DataType ?? string.Empty;

            if (fdcFoodResult?.FoodNutrients != null)
            {
                var calories = fdcFoodResult.FoodNutrients.Where(n => n.Nutrient?.Id == NutrientCode.Calorie.Id)?.FirstOrDefault();

                if (calories?.Amount != null)
                {
                    Calories = new Nutrient
                    {
                        Amount = calories.Amount ?? 0.0,
                        Unit = calories.Nutrient?.UnitName ?? string.Empty,
                    };
                }

                var fiber = fdcFoodResult.FoodNutrients.Where(n => n.Nutrient?.Id == NutrientCode.Fiber.Id)?.FirstOrDefault();

                if (fiber?.Amount != null)
                {
                    Fiber = new Nutrient
                    {
                        Amount = fiber.Amount ?? 0.0,
                        Unit = fiber.Nutrient?.UnitName ?? string.Empty,
                    };
                }
            }
        }
    }
}
