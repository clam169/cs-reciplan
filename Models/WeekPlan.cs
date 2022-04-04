using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeApp.Models
{
  public class WeekPlan
  {
    public int WeekPlanId { get; set; }
    [ForeignKey("ApplicationUser")]
    public string? Id { get; set; }

    public ICollection<DayPlan>? Days { get; set; }


  }
}