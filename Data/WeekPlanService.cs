using RecipeApp.Models;
namespace RecipeApp.Data
{
  public class WeekPlanService
  {
    ApplicationDbContext _context;
    public WeekPlanService(ApplicationDbContext context)
    {
      _context = context;
    }

    public async Task<List<WeekPlan>> GetRecipesAsync()
    {
      var result = _context.WeekPlans;
      return await Task.FromResult(result.ToList());
    }

    public async Task<WeekPlan> GetRecipeByIdAsync(string id)
    {
      return await _context.WeekPlans.FindAsync(id);
    }

    public async Task<WeekPlan> InsertRecipeAsync(WeekPlan weekplan)
    {
      _context.WeekPlans.Add(weekplan);
      await _context.SaveChangesAsync();

      return weekplan;
    }

    public async Task<WeekPlan> UpdateWeekPlanAsync(string id, WeekPlan wp)
    {
      var weekplan = await _context.WeekPlans.FindAsync(id);

      if (weekplan == null)
        return null;

      weekplan.Monday = wp.Monday;
      weekplan.Tuesday = wp.Tuesday;
      weekplan.Wednesday = wp.Wednesday;
      weekplan.Thursday = wp.Thursday;
      weekplan.Friday = wp.Friday;

      _context.WeekPlans.Update(weekplan);
      await _context.SaveChangesAsync();

      return weekplan;
    }

    public async Task<WeekPlan> DeleteWeekPlanAsync(string id)
    {
      var weekplan = await _context.WeekPlans.FindAsync(id);

      if (weekplan == null)
        return null;

      _context.WeekPlans.Remove(weekplan);
      await _context.SaveChangesAsync();

      return weekplan;
    }

    private bool WeekPlanExists(int id)
    {
      return _context.WeekPlans.Any(e => e.WeekPlanId == id);
    }
  }
}