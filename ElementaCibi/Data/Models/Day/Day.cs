namespace ElementaCibi.Data.Models.Day
{
    using Recipe;
    public class Day
    {
        public Guid Id { get; set; }
        public List<Meal> Meals { get; set; } = new List<Meal>();
        public string Date { get; set; } = string.Empty;

        public float Calories
        {
            get
            {
                var calories =  Meals.Sum(m => m.Recipe?.Calories);
                if(calories.HasValue)
                    return calories.Value;
                return 0;
            }
        }

        public float Fiber
        {
            get
            {
                var fiber = Meals.Sum(m => m.Recipe?.Fiber);
                if (fiber.HasValue)
                    return fiber.Value;
                return 0;
            }
        }
    }
}
