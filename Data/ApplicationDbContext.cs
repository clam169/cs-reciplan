using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Models;

namespace RecipeApp.Data
{
  public class ApplicationDbContext : IdentityDbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<DayPlan>? DayPlans { get; set; }
    public DbSet<Recipe>? Recipes { get; set; }
    public DbSet<WeekPlan>? WeekPlans { get; set; }

    //   protected override void OnModelCreating(ModelBuilder modelBuilder)
    //   {
    //     modelBuilder
    // .Entity<WeekPlan>()
    // .HasMany(p => p.Days)
    // .WithMany(p => p.WeekPlans)
    // .UsingEntity(j => j.ToTable("WeekPlanRecipes"));





    //     // modelBuilder.Entity<WeekPlan>()
    //     //     .HasMany(p => p.Recipes)
    //     //     .WithMany(p => p.WeekPlans)
    //     //     .UsingEntity<PostTag>(
    //     //         j => j
    //     //             .HasOne(pt => pt.Tag)
    //     //             .WithMany(t => t.PostTags)
    //     //             .HasForeignKey(pt => pt.TagId),
    //     //         j => j
    //     //             .HasOne(pt => pt.WeekPlans)
    //     //             .WithMany(p => p.PostTags)
    //     //             .HasForeignKey(pt => pt.WeekPlansId),
    //     //         j =>
    //     //         {
    //     //             j.Property(pt => pt.PublicationDate).HasDefaultValueSql("CURRENT_TIMESTAMP");
    //     //             j.HasKey(t => new { t.PostId, t.TagId });
    //     //         });
    //   }

  }
}