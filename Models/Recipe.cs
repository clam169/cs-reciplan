namespace RecipeApp.Models
{
    public class Recipe
    {
        public int id { get; set; }
        public string? title { get; set; }
        public string? image { get; set; }
        public string? imageType { get; set; }
        public float? servings { get; set; }
        public int? readyInMinutes { get; set; }
        public string? license { get; set; }
        public string? sourceName { get; set; }
        public string? sourceUrl { get; set; }
        public string? spoonacularSourceUrl { get; set; }
        public float? aggregateLikes { get; set; }
        public float? healthScore { get; set; }
        public float? spoonacularScore { get; set; }
        public float? pricePerServing { get; set; }
        public string? instructions { get; set; }
        public bool? cheap { get; set; }
        public string? creditsText { get; set; }
        public string? summary { get; set; }
        public List<Ingredient>? extendedIngredients { get; set; }
    }
}