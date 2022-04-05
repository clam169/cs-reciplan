using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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


    public async Task<WeekPlan> GetWeekPlanByIdAsync(string id)
    {
      return await _context.WeekPlans.FindAsync(id);
    }

    public async Task<List<WeekPlan>> GetWeekPlansAsync(string id)
    {
      // *****
      var result = _context.WeekPlans;
      return await Task.FromResult(result.ToList());

    }
    public async Task<WeekPlan> InsertWeekPlanAsync(WeekPlan weekplan)
    {
      _context.WeekPlans.Add(weekplan);
      await _context.SaveChangesAsync();

      return weekplan;
    }

    public async Task<DayPlan> AddToDayPlanAsync(DayPlan dayplan)
    {
      Console.WriteLine("CALLING ADD TO DAY PLAN ASYNC");
      _context.DayPlans.Add(dayplan);
      await _context.SaveChangesAsync();
      return dayplan;
    }

    public async Task<DayPlan> GetDayPlansByUserAndDay(string id, string dayName)
    {
      Console.WriteLine("CALLING GET DAY PLAN BY USER AND DAY");
      var userId = id;
      var dayplan = _context.DayPlans.Include(dayplan => dayplan.Recipes).Where(d => d.Id == userId && d.Weekday == dayName).FirstOrDefault<DayPlan>();
      // var dayplan = _context.DayPlans.Include("Recipes").Where(d => d.Id == userId && d.Weekday == dayName).FirstOrDefault<DayPlan>();
      return dayplan;
    }

    public async Task<List<Recipe>> GetRecipesByDay(string id, string dayName)
    {
      List<Recipe> recipeList = new List<Recipe> { };
      var dayplans = _context.DayPlans.Include(dayplan => dayplan.Recipes).Where(d => d.Id == id && d.Weekday == dayName);
      foreach (DayPlan d in dayplans)
      {
        foreach (Recipe r in d.Recipes)
        {
          Console.WriteLine(r.Title);
          recipeList.Add(r);
        }
      }
      return recipeList;
    }
    public async Task<DayPlan> AddRecipToExistingDayPlan(string id, string dayName, Recipe recipe)
    {
      var userId = id;
      var dayplan = _context.DayPlans.Include(dayplan => dayplan.Recipes).Where(d => d.Id == userId && d.Weekday == dayName).FirstOrDefault<DayPlan>();

      ICollection<Recipe> recipes = dayplan.Recipes;
      dayplan.Recipes.Add(recipe);
      await _context.SaveChangesAsync();

      return dayplan;

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
      return _context.WeekPlans.Any(e => e.WeekPlansId == id);
    }
  }
}