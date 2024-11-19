using Game.Data.Models.Resources;

namespace Game.Data.Models.Recipes
{
    public class Recipe : Item
    {
        public string Name { get; set; }
        public int GoldValue { get; set; }
        public List<Resource> Ingredients { get; set; } = [];
        public int CostToCraft { get; set; }
    }
}
