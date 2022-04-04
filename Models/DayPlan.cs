using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeApp.Models
{

  public class DayPlan
  {

    [Key]
    public int DayPlanId { get; set; }
    [ForeignKey("ApplicationUser")]
    public string? Id { get; set; }
    public string Weekday { get; set; } // name of the week
    public ICollection<Recipe> Recipes { get; set; }
    public ICollection<WeekPlan>? WeekPlans { get; set; }

  }
}