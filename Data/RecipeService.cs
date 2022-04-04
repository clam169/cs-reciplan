using RecipeApp.Models;
namespace RecipeApp.Data
{
  public class RecipeService
  {
    ApplicationDbContext _context;
    public RecipeService(ApplicationDbContext context)
    {
      _context = context;
    }

    public async Task<List<Recipe>> GetRecipesAsync()
    {
      var result = _context.Recipes;
      return await Task.FromResult(result.ToList());
    }

    public async Task<Recipe> GetRecipeByIdAsync(int id)
    {
      return await _context.Recipes.FindAsync(id);
    }

    public async Task<Recipe> InsertRecipeAsync(Recipe recipe)
    {
      if (String.IsNullOrEmpty(recipe.Image))
      {
        recipe.Image = "https://www.kindpng.com/picc/m/79-798754_hoteles-y-centros-vacacionales-dish-placeholder-hd-png.png";
      }
      Console.WriteLine(recipe.Id);
      _context.Recipes.Add(recipe);
      await _context.SaveChangesAsync();

      return recipe;
    }

    public async Task<Recipe> UpdateRecipeAsync(int id, Recipe r)
    {
      var recipe = await _context.Recipes.FindAsync(id);

      if (recipe == null)
        return null;

      recipe.Title = r.Title;
      recipe.Ingredients = r.Ingredients;
      recipe.Description = r.Description;
      recipe.Image = r.Image;
      recipe.Steps = r.Steps;

      _context.Recipes.Update(recipe);
      await _context.SaveChangesAsync();

      return recipe;
    }

    public async Task<Recipe> DeleteRecipeAsync(int id)
    {
      var recipe = await _context.Recipes.FindAsync(id);

      if (recipe == null)
        return null;

      _context.Recipes.Remove(recipe);
      await _context.SaveChangesAsync();

      return recipe;
    }

    private bool RecipeExists(int id)
    {
      return _context.Recipes.Any(e => e.RecipeId == id);
    }
  }
}