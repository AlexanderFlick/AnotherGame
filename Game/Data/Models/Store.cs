using Game.Data.Models.Recipes;

namespace Game.Data.Models
{
    public class Store
    {
        public Store()
        {
            Recipes = [new TranslucentCape()];
        }
        public List<Recipe> Recipes { get; set; } = [];
    }
}
