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

    public async Task<DayPlan> InitializeWeekPlan(String userId)
    {

      // List<DayPlan> dayplans = new List<DayPlan>() {
      //     new DayPlan() {
      //         Weekday = "Monday",
      //                 Id = userId,
      //         WeekPlans = null
      //     },
      //     new DayPlan() {
      //         Weekday = "Tuesday",
      //                 Id = userId,
      //         WeekPlans = null,
      //     },
      //               new DayPlan() {
      //         Weekday = "Wednesday",
      //                 Id = userId,
      //         WeekPlans = null,
      //     },
      //               new DayPlan() {
      //         Weekday = "Thursday",
      //                 Id = userId,
      //         WeekPlans = null,
      //     },
      //               new DayPlan() {
      //         Weekday = "Friday",
      //                 Id = userId,
      //         WeekPlans = null,
      //     },
      //               new DayPlan() {
      //         Weekday = "Saturday",
      //                 Id = userId,
      //         WeekPlans = null,
      //     },
      //               new DayPlan() {
      //         Weekday = "Sunday",
      //                 Id = userId,
      //         WeekPlans = null,
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
        WeekPlans = Array.Empty<WeekPlan>()
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