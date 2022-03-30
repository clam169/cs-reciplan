using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeApp.Models
{
  public class WeekPlan
  {
    public int WeekPlanId { get; set; }
    [ForeignKey("ApplicationUser")]
    public string? Id { get; set; }
    public List<Recipe>? Monday { get; set; }
    public List<Recipe>? Tuesday { get; set; }
    public List<Recipe>? Wednesday { get; set; }
    public List<Recipe>? Thursday { get; set; }
    public List<Recipe>? Friday { get; set; }
    public List<Recipe>? Saturday { get; set; }
    public List<Recipe>? Sunday { get; set; }

  }
}