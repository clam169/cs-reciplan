using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeApp.Models
{
  public class Recipe
  {
    [Key]
    public int RecipeId { get; set; }
    [ForeignKey("ApplicationUser")]
    public string? Id { get; set; }
    [Required]
    [Display(Name = "Recipe Title")]
    public string? Title { get; set; }
    [Required]
    public string? Description { get; set; }
    [Display(Name = "Image URL")]
    public string? Image { get; set; }
    [Required]
    public string? Steps { get; set; }
    [Required]
    public string? Ingredients { get; set; }
    public ICollection<DayPlan> DayPlans { get; set; }
  }
}