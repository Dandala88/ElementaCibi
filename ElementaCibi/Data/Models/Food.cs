using ElementaCibi.Data.FdcModels.Constants;
using ElementaCibi.Data.FdcModels.Foods;
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
        public double Ratio 
        { 
            get
            {
                if(Fiber?.Amount != null && Calories?.Amount != null)
                    return Fiber.Amount / Calories.Amount;
                else
                    return 0.0;
            }
        }
        public double Hundred 
        {
            get 
            {
                if (Fiber?.Amount != null && Calories?.Amount != null)
                    return 100 / (Fiber.Amount / Calories.Amount);
                else
                    return double.PositiveInfinity;
            }
        }

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

        public void FdcBrandedFoodToFood(FdcBrandedFood fdcBrandedFood)
        {
            FdcId = fdcBrandedFood.FdcId;
            Description = fdcBrandedFood.Description;
            DataType = fdcBrandedFood.DataType;
            Brand = fdcBrandedFood.BrandOwner;

            if (fdcBrandedFood?.FoodNutrients != null)
            {
                var calories = fdcBrandedFood.FoodNutrients.Where(n => n.Nutrient?.Id == NutrientCode.Calorie.Id)?.FirstOrDefault();

                if (calories?.Nutrient != null)
                {
                    Calories = new Nutrient
                    {
                        Amount = calories.Amount,
                        Unit = calories.Nutrient.UnitName,
                    };
                }

                var fiber = fdcBrandedFood.FoodNutrients.Where(n => n.Nutrient?.Id == NutrientCode.Fiber.Id)?.FirstOrDefault();

                if (fiber?.Nutrient != null)
                {
                    Fiber = new Nutrient
                    {
                        Amount = fiber.Amount,
                        Unit = fiber.Nutrient.UnitName,
                    };
                }
            }
        }

        public void FdcFoundationFoodToFood(FdcFoundationFood fdcFoundationFood)
        {
            FdcId = fdcFoundationFood.FdcId;
            Description = fdcFoundationFood.Description;
            DataType = fdcFoundationFood.DataType;

            if (fdcFoundationFood?.FoodNutrients != null)
            {
                var calories = fdcFoundationFood.FoodNutrients.Where(n => n.Nutrient?.Id == NutrientCode.Calorie.Id)?.FirstOrDefault();

                if (calories?.Nutrient != null)
                {
                    Calories = new Nutrient
                    {
                        Amount = calories.Amount,
                        Unit = calories.Nutrient.UnitName,
                    };
                }

                var fiber = fdcFoundationFood.FoodNutrients.Where(n => n.Nutrient?.Id == NutrientCode.Fiber.Id)?.FirstOrDefault();

                if (fiber?.Nutrient != null)
                {
                    Fiber = new Nutrient
                    {
                        Amount = fiber.Amount,
                        Unit = fiber.Nutrient.UnitName,
                    };
                }
            }
        }

        public void FdcLegacyFoodToFood(FdcLegacyFood fdcLegacyFood)
        {
            FdcId = fdcLegacyFood.FdcId;
            Description = fdcLegacyFood.Description;
            DataType = fdcLegacyFood.DataType;

            if (fdcLegacyFood?.FoodNutrients != null)
            {
                var calories = fdcLegacyFood.FoodNutrients.Where(n => n.Nutrient?.Id == NutrientCode.Calorie.Id)?.FirstOrDefault();

                if (calories?.Nutrient != null)
                {
                    Calories = new Nutrient
                    {
                        Amount = calories.Amount,
                        Unit = calories.Nutrient.UnitName,
                    };
                }

                var fiber = fdcLegacyFood.FoodNutrients.Where(n => n.Nutrient?.Id == NutrientCode.Fiber.Id)?.FirstOrDefault();

                if (fiber?.Nutrient != null)
                {
                    Fiber = new Nutrient
                    {
                        Amount = fiber.Amount,
                        Unit = fiber.Nutrient.UnitName,
                    };
                }
            }
        }

        public void FdcSurveyFoodToFood(FdcSurveyFood fdcSurveyFood)
        {
            FdcId = fdcSurveyFood.FdcId;
            Description = fdcSurveyFood.Description;
            DataType = fdcSurveyFood.DataType;

            if (fdcSurveyFood?.FoodNutrients != null)
            {
                var calories = fdcSurveyFood.FoodNutrients.Where(n => n.Nutrient?.Id == NutrientCode.Calorie.Id)?.FirstOrDefault();

                if (calories?.Nutrient != null)
                {
                    Calories = new Nutrient
                    {
                        Amount = calories.Amount,
                        Unit = calories.Nutrient.UnitName,
                    };
                }

                var fiber = fdcSurveyFood.FoodNutrients.Where(n => n.Nutrient?.Id == NutrientCode.Fiber.Id)?.FirstOrDefault();

                if (fiber?.Nutrient != null)
                {
                    Fiber = new Nutrient
                    {
                        Amount = fiber.Amount,
                        Unit = fiber.Nutrient.UnitName,
                    };
                }
            }
        }
    }
}
