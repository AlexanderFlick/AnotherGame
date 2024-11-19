using Game.Data.Models.Enemies;
using Game.Data.Models.Resources;

namespace Game.Data.Models.Areas;

public class MawOfOblivion : Area
{
    public MawOfOblivion()
    {
        Name = "Maw of Oblivion";
        AvailableResources = [new Wraithwood(), new ShadowOre()];
        Enemies = [new Dragon()];
    }
}
