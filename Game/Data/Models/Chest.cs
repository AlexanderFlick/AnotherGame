using Game.Data.Models.Resources;

namespace Game.Data.Models;

public class Chest
{
    public Chest()
    {
        ResourceCap = 50;
    }

    public int ResourceCap { get; set; }
    public List<Item> Resources { get; set; } = [];
}
