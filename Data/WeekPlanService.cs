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

    public async Task<DayPlan> InitializeWeekPlan(String userId)
    {

      // List<DayPlan> dayplans = new List<DayPlan>() {
      //     new DayPlan() {
      //         Weekday = "Monday",
      //                 Id = userId,
      //         Recipes = null
      //     },
      //     new DayPlan() {
      //         Weekday = "Tuesday",
      //                 Id = userId,
      //         Recipes = null,
      //     },
      //               new DayPlan() {
      //         Weekday = "Wednesday",
      //                 Id = userId,
      //         Recipes = null,
      //     },
      //               new DayPlan() {
      //         Weekday = "Thursday",
      //                 Id = userId,
      //         Recipes = null,
      //     },
      //               new DayPlan() {
      //         Weekday = "Friday",
      //                 Id = userId,
      //         Recipes = null,
      //     },
      //               new DayPlan() {
      //         Weekday = "Saturday",
      //                 Id = userId,
      //         Recipes = null,
      //     },
      //               new DayPlan() {
      //         Weekday = "Sunday",
      //                 Id = userId,
      //         Recipes = null,
      //     }
      //  };
      // foreach (var dayplan in dayplans)
      // {
      //   _context.DayPlans.Add(dayplan);
      //   await _context.SaveChangesAsync();
      // }
      // WeekPlan w = new WeekPlan()
      // {
      //   Id = userId,
      //   Days = dayplans,
      // };

      // _context.WeekPlans.Add(w);
      // await _context.SaveChangesAsync();


      var dayplan = new DayPlan()
      {
        Weekday = "Monday",
        Id = userId,
        Recipes = Array.Empty<Recipe>()
      };
      _context.DayPlans.Add(dayplan);
      await _context.SaveChangesAsync();
      return dayplan;
    }

    // public async Task<WeekPlan> UpdateWeekPlanAsync(string id, WeekPlan wp)
    // {
    //   var weekplan = await _context.WeekPlans.FindAsync(id);

    //   if (weekplan == null)
    //     return null;

    //   weekplan.Monday = wp.Monday;
    //   weekplan.Tuesday = wp.Tuesday;
    //   weekplan.Wednesday = wp.Wednesday;
    //   weekplan.Thursday = wp.Thursday;
    //   weekplan.Friday = wp.Friday;

    //   _context.WeekPlans.Update(weekplan);
    //   await _context.SaveChangesAsync();

    //   return weekplan;
    // }

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