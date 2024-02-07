namespace ElementaCibi.Data.Models.Day
{
    using Recipe;
    public class Meal
    {
        public Guid Id { get; set; }
        public Recipe? Recipe { get; set; }
    }
}
