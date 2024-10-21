using Game.Data.Models.Resources;

namespace Game.Data.Models.Areas;

public class Area
{
    public string Name { get; set; }
    public List<Resource> AvailableResources { get; set; }
}
