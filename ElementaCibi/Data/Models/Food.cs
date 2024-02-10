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

            SetSearchFoodNutrients(fdcSearchResult.FoodNutrients);
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

            SetNutrients(fdcBrandedFood.FoodNutrients);
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

            SetNutrients(fdcFoundationFood?.FoodNutrients);
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

            SetNutrients(fdcLegacyFood.FoodNutrients);
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

            SetNutrients(fdcSurveyFood.FoodNutrients);
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

            SetNutrients(fdcExperimentalFood.FoodNutrients);
        }

        private void SetNutrients(List<FdcModels.Foods.FoodNutrient>? foodNutrients)
        {
            if (foodNutrients != null)
            {
                var calories = foodNutrients.Where(n => n.Nutrient?.Id == NutrientCode.Calorie.Id)?.FirstOrDefault();

                if (calories?.Nutrient != null)
                {
                    Calories = new Nutrient
                    {
                        Amount = calories.Amount,
                        Unit = calories.Nutrient.UnitName,
                    };
                }

                var fiber = foodNutrients.Where(n => n.Nutrient?.Id == NutrientCode.Fiber.Id)?.FirstOrDefault();

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

        //This is just for the food search list, probably get this down to only include food label nutrients to prevent a noisy food search interface
        private void SetSearchFoodNutrients(List<FdcModels.Search.FoodNutrient>? foodNutrients)
        {
            if (foodNutrients != null)
            {
                var calories = foodNutrients.Where(n => n.NutrientId == NutrientCode.Calorie.Id)?.FirstOrDefault();

                if (calories?.Value != null)
                {
                    Calories = new Nutrient
                    {
                        Amount = calories.Value,
                        Unit = calories.UnitName,
                    };
                }

                var fiber = foodNutrients.Where(n => n.NutrientId == NutrientCode.Fiber.Id)?.FirstOrDefault();

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
    }
}
