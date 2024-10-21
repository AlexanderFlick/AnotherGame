using Game.Data.Models.Resources;

namespace Game.Data.Models;

public class NewGame
{
    public Player Player { get; set; } = new Player();
    public Action OnStateChanged { get; set; }
}

public class Player
{
    public Player()
    {
        Resources.Add(new Wood());
        Chest = new Chest();
        Town = new Town { Population = 1 };
        Recipes.Add(new Plank());
    }

    public string Name { get; set; }
    public int Gold { get; set; }
    public Chest Chest { get; set; }
    public Town Town { get; set; }
    public List<Resource> Resources { get; set; } = [];
    public List<Resource> Recipes { get; set; } = [];
}
