using Microsoft.AspNetCore.Identity;
using RecipeApp.Models;

namespace RecipeApp.Data
{
  public class IdentitySeedData
  {
    public static async Task Initialize(ApplicationDbContext context,
    UserManager<IdentityUser> userManager)
    {
      context.Database.EnsureCreated();

      string password4all = "P@$$w0rd";

      if (await userManager.FindByNameAsync("aa@aa.aa") == null)
      {
        var user = new IdentityUser
        {
          UserName = "aa@aa.aa",
          Email = "aa@aa.aa",
          PhoneNumber = "6902341234",
          EmailConfirmed = true
        };
        var result = await userManager.CreateAsync(user);
        if (result.Succeeded)
        {
          await userManager.AddPasswordAsync(user, password4all);

        }
      }
      if (await userManager.FindByNameAsync("bb@bb.bb") == null)
      {
        var user = new IdentityUser
        {
          UserName = "bb@bb.bb",
          Email = "bb@bb.bb",
          PhoneNumber = "7788951456",
          EmailConfirmed = true
        };
        var result = await userManager.CreateAsync(user);
        if (result.Succeeded)
        {
          await userManager.AddPasswordAsync(user, password4all);
        }
      }
      if (await userManager.FindByNameAsync("mm@mm.mm") == null)
      {
        var user = new IdentityUser
        {
          UserName = "mm@mm.mm",
          Email = "mm@mm.mm",
          PhoneNumber = "6572136821",
          EmailConfirmed = true
        };
        var result = await userManager.CreateAsync(user);
        if (result.Succeeded)
        {
          await userManager.AddPasswordAsync(user, password4all);
        }
      }
      if (await userManager.FindByNameAsync("dd@dd.dd") == null)
      {
        var user = new IdentityUser
        {
          UserName = "dd@dd.dd",
          Email = "dd@dd.dd",
          PhoneNumber = "6041234567",
          EmailConfirmed = true
        };
        var result = await userManager.CreateAsync(user);
        if (result.Succeeded)
        {
          await userManager.AddPasswordAsync(user, password4all);
        }
      }

      // var data = getIngredients().ToArray();
      // context.Ingredients!.AddRange(data);
      // check if recipes exist
      if (context.WeekPlans != null && context.WeekPlans.Any())
      {
        context.SaveChanges();
        return;
      }

      var recipes = GetRecipes().ToArray();
      context.Recipes!.AddRange(recipes);
      context.SaveChanges();

      var days = GetDayPlans(context).ToArray();
      context.DayPlans!.AddRange(days);
      context.SaveChanges();


      var weekPlans = GetWeekPlans(context).ToArray();
      context.WeekPlans!.AddRange(weekPlans);

      context.SaveChanges();
    }

    private static List<Ingredient> getIngredients()
    {
      List<Ingredient> data = new List<Ingredient>() {
            new Ingredient() {
                id=1,
                image="https://someimage.com/picture.jpg",
                name="salt",
                amount=3,
                unit="teaspoon"
            },
            new Ingredient() {
                id=2,
                image="https://someimage.com/picture2.jpg",
                name="sugar",
                amount=2,
                unit="teaspoon"
            },
        };

      return data;
    }

    private static List<Recipe> GetRecipes()
    {
      List<Recipe> recipes = new List<Recipe>() {
        new Recipe() {
      Id = "string",
      Title = "Pizza",
      Description = "I am a pizza",
      Image = "",
      Steps = "step 1, step 2, done!",
      Ingredients = "chicken"
          },
      new Recipe() {
      Id = "string",
      Title = "Pasta",
      Description = "I am a pasta",
      Image = "",
      Steps = "step 1, step 2, done!",
      Ingredients = "chicken, pasta"
          },
                new Recipe() {
      Id = "string",
      Title = "nachos",
      Description = "more cheese and flour",
      Image = "",
      Steps = "step 1, step 2, done!",
      Ingredients = "cheese, chips, happiness"
          },
    };
      return recipes;
    }

    private static List<DayPlan>? GetDayPlans(ApplicationDbContext db)
    {
      List<DayPlan> dayplans = new List<DayPlan>() {
          new DayPlan() {
              Weekday = "Monday",
              Recipes = new List<Recipe>(db.Recipes.Take(2)),
          },
          new DayPlan() {
              Weekday = "Tuesday",
              Recipes = new List<Recipe>(db.Recipes.Take(2)),
          }
       };
      return dayplans;
    }

    private static List<WeekPlan>? GetWeekPlans(ApplicationDbContext db)
    {
      List<WeekPlan> weekplans = new List<WeekPlan>() {
          new WeekPlan() {
              Id = "string",
              Days = new List<DayPlan>(db.DayPlans.Take(2)),
          }
       };
      return weekplans;
    }
  }
}