namespace RecipeApp.Models
{
    public class Ingredient
    {
        public int id { get; set; }
        public string? image { get; set; }
        public string? name { get; set; }
        public float? amount { get; set; }
        public string? unit { get; set; }
    }
}