using Game.Data.Models.Resources;

namespace Game.Data.Models.Areas;

public class GlassOcean : Area
{
    public GlassOcean()
    {
        Name = "Glass Ocean";
        AvailableResources = [new Wood(), new Stone(), new PrismaticShard(), new TranslucentThread()];
    }
}
