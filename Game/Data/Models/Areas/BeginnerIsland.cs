using Game.Data.Models.Resources;

namespace Game.Data.Models.Areas;

public class BeginnerIsland : Area
{
    public BeginnerIsland()
    {
        Name = "Beginner Island";
        AvailableResources = [new Wood()];
    }
}
