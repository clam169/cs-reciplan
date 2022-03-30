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

        // private static Recipe GetRecipe() {

        // }
    }
}