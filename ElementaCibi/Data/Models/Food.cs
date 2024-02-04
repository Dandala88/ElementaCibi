using ElementaCibi.Data.FdcModels.Constants;
using ElementaCibi.Data.FdcModels.Foods;
using ElementaCibi.Data.FdcModels.Search;
using System.Text.Json.Serialization;

namespace ElementaCibi.Data.Models
{
    public class Food
    {
        public int FdcId { get; set; }
        public string Description { get; set; } = string.Empty;
        public string DataType { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public List<Portion> Portions { get; set; } = new List<Portion>();
        public Nutrient? Calories { get; set; }
        public Nutrient? Fiber { get; set; }
        public float Ratio 
        { 
            get
            {
                if(Fiber?.Amount != null && Calories?.Amount != null)
                    return Fiber.Amount / Calories.Amount;
                else
                    return 0f;
            }
        }
        [JsonNumberHandling(JsonNumberHandling.AllowNamedFloatingPointLiterals)]
        public float Hundred 
        {
            get 
            {
                if (Fiber?.Amount != null && Calories?.Amount != null)
                    return 100 / (Fiber.Amount / Calories.Amount);
                else
                    return float.PositiveInfinity;
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
                        Amount = calories.Value,
                        Unit = calories.UnitName,
                    };
                }

                var fiber = fdcSearchResult.FoodNutrients.Where(n => n.NutrientId == NutrientCode.Fiber.Id)?.FirstOrDefault();

                if (fiber?.Value != null)
                {
                    Fiber = new Nutrient
                    {
                        Amount = fiber.Value,
                        Unit = fiber.UnitName,
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

            Portions.Add(new Portion
            {
                Description = $"{fdcBrandedFood.ServingSize} {fdcBrandedFood.ServingSizeUnit}",
            });

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
            Portions.Add(new Portion
            {
                Grams = 100,
                Description = "100 G"
            });
            foreach (var p in fdcFoundationFood.FoodPortions)
            {
                var portion = new Portion
                {
                    Grams = p.GramWeight,
                    Description = $"{p.Amount} {p.MeasureUnit?.Name ?? p.MeasureUnit?.Abbreviation ?? string.Empty}",
                };
                Portions.Add(portion);
            }

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
            Portions.Add(new Portion
            {
                Grams = 100,
                Description = "100 G"
            });
            foreach (var p in fdcLegacyFood.FoodPortions)
            {
                var portion = new Portion
                {
                    Grams = p.GramWeight,
                    Description = $"{p.Amount} {p.Modifier ?? string.Empty}",
                };
                Portions.Add(portion);
            }

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
            Portions.Add(new Portion
            {
                Grams = 100,
                Description = "100 G"
            });
            foreach (var p in fdcSurveyFood.FoodPortions)
            {
                if (p.PortionDescription != "Quantity not specified")
                {
                    var portion = new Portion
                    {
                        Grams = p.GramWeight,
                        Description = p.PortionDescription,
                    };
                    Portions.Add(portion);
                }
                else
                {
                    var portion = new Portion
                    {
                        Grams = p.GramWeight,
                        Description = $"{p.GramWeight} G",
                    };
                    Portions.Add(portion);
                }
            }

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

        public void FdcExperimentalFoodToFood(FdcExperimentalFood fdcExperimentalFood)
        {
            FdcId = fdcExperimentalFood.FdcId;
            Description = fdcExperimentalFood.Description;
            DataType = fdcExperimentalFood.DataType;
            Portions.Add(new Portion
            {
                Grams = 100,
                Description = "100 G"
            });

            if (fdcExperimentalFood?.FoodNutrients != null)
            {
                var calories = fdcExperimentalFood.FoodNutrients.Where(n => n.Nutrient?.Id == NutrientCode.Calorie.Id)?.FirstOrDefault();

                if (calories?.Nutrient != null)
                {
                    Calories = new Nutrient
                    {
                        Amount = calories.Amount,
                        Unit = calories.Nutrient.UnitName,
                    };
                }

                var fiber = fdcExperimentalFood.FoodNutrients.Where(n => n.Nutrient?.Id == NutrientCode.Fiber.Id)?.FirstOrDefault();

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
