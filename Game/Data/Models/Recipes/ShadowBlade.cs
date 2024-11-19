using Game.Data.Models.Resources;

namespace Game.Data.Models.Recipes;

public class ShadowBlade : Recipe
{
    public ShadowBlade()
    {
        Name = "Shadow Blade";
        Ingredients = [new ShadowOre(), new ShadowOre(), new ShadowOre()];
    }
}
