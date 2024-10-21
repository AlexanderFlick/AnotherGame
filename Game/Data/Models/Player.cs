using Game.Data.Models.Resources;
using System.ComponentModel;

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
        UnlockedResources.Add(new Wood());
        Chest = new Chest();
    }

    public string Name { get; set; }
    public Chest Chest { get; set; }
    public List<Resource> UnlockedResources { get; set; } = [];
}
