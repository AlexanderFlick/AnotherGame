using Game.Data.Models.Areas;
using Game.Data.Models.Recipes;
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
        Areas = SetAreas();
    }

    public string Name { get; set; }
    public int Gold { get; set; }
    public Chest Chest { get; set; }
    public Town Town { get; set; }
    public List<Resource> Resources { get; set; } = [];
    public List<Recipe> Recipes { get; set; } = [];
    public List<Area> Areas { get; set; } = [];

    public List<Area> SetAreas()
    {
        var areas = new List<Area>
        {
            new BeginnerIsland { Visiting = true },
            new Ethoria(),
            new GlassOcean(),
            new MawOfOblivion()
        };

        return areas;
    }
}
