using Game.Data.Models.Resources;

namespace Game.Data.Models.Recipes;

public class TranslucentCape : Recipe
{
    public TranslucentCape()
    {
        Name = "Translucent Cape";
        Ingredients = [new TranslucentThread(), new TranslucentThread(), new TranslucentThread()];
    }
}
