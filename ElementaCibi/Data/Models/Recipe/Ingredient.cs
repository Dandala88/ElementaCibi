namespace ElementaCibi.Data.Models.Recipe
{
    public class Ingredient
    {
        public Guid Id { get; set; }
        public Food Food { get; set; } = new Food();
        public Portion Portion { get; set; } = new Portion();
        public float Quantity { get; set; }
    }
}
