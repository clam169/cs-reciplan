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
      var dayplan = _context.DayPlans.Where(d => d.Id == userId && d.Weekday == dayName).FirstOrDefault();
      return dayplan;
    }
    public async Task<DayPlan> AddRecipToExistingDayPlan(string id, string dayName, Recipe recipe)
    {
      Console.WriteLine("CALLING ADD RECIPE TO EXISTING DAY PLANNNNNNNNNN");
      var userId = id;
      var dayplan = _context.DayPlans.Include(dayplan => dayplan.Recipes).Where(d => d.Id == userId && d.Weekday == dayName).FirstOrDefault<DayPlan>();
      var dayplanList = _context.DayPlans.Include(dayplan => dayplan.Recipes).Where(d => d.Id == userId && d.Weekday == dayName).ToList();
      Console.WriteLine("IM WRITELINING");
      Console.WriteLine(recipe.RecipeId);

      foreach (var plan in dayplanList)
      {
        Console.WriteLine("'GODAMMNNN FOR EACH RROOOP'");
        Console.WriteLine(plan.DayPlanId);

      }

      ICollection<Recipe> recipes = dayplan.Recipes;

      foreach (var recip in recipes)
      {
        Console.WriteLine("' recipe GODAMMNNN FOR EACH RROOOP'");
        Console.WriteLine(recip.Title);

      }
      Console.WriteLine(recipes.ToString());
      dayplan.Recipes.Add(recipe);
      foreach (var recip in recipes)
      {
        Console.WriteLine("' second recipe GODAMMNNN FOR EACH RROOOP'");
        Console.WriteLine(recip.Title);

      }
      // dayplan.Recipes = recipes;


      // _context.DayPlans.Update(dayplan);
      await _context.SaveChangesAsync();


      return dayplan;

    }
    private static void Dump(object o)
    {
      string json = JsonConvert.SerializeObject(o, Formatting.Indented);
      Console.WriteLine(json);
    }
    public void InitializeDayPlans(String userId)
    {
      List<DayPlan> dayplans = new List<DayPlan>() {
        new DayPlan(){
          Id = userId,
          Weekday = "Sunday",
          Recipes = new List<Recipe>() {}
        },
        new DayPlan(){
          Id = userId,
          Weekday = "Monday",
          Recipes = new List<Recipe>() {}
        },
        new DayPlan(){
          Id = userId,
          Weekday = "Tuesday",
          Recipes = new List<Recipe>() {}
        },
        new DayPlan(){
          Id = userId,
          Weekday = "Wednesday",
          Recipes = new List<Recipe>() {}
        },
        new DayPlan(){
          Id = userId,
          Weekday = "Thursday",
          Recipes = new List<Recipe>() {}
        },
        new DayPlan(){
          Id = userId,
          Weekday = "Friday",
          Recipes = new List<Recipe>() {}
        },
        new DayPlan(){
          Id = userId,
          Weekday = "Saturday",
          Recipes = new List<Recipe>() {}
        },
      };
      _context.DayPlans!.AddRange(dayplans.ToArray());
      _context.SaveChangesAsync();
      return;
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