using Game.Data.Models.Resources;

namespace Game.Data.Models.Recipes;

public class Plank : Recipe, Item
{
    public Plank()
    {
        Name = "Plank";
        Ingredients = [new Wood(), new Wood(), new Wood(), new Wood()];
    }
}
