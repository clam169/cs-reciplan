using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RecipeApp.Models
{
  public class WeekPlan
  {
    [Key]
    public int WeekPlansId { get; set; }
    [ForeignKey("ApplicationUser")]
    public string? Id { get; set; }

    public ICollection<DayPlan>? Days { get; set; }


  }
}