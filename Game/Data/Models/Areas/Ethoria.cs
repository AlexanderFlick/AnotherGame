using Game.Data.Models.Resources;

namespace Game.Data.Models.Areas;

public class Ethoria : Area
{
    public Ethoria()
    {
        Name = "Fields Of Ethoria";
        AvailableResources = [new Wood(), new Stone()];
        CostToTravel = [new Plank(), new Plank()];
    }
}
