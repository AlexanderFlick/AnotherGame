using Game.Data.Models.Enemies;
using Game.Data.Models.Resources;

namespace Game.Data.Models.Areas;

public class Area
{
    public string Name { get; set; }
    public List<Resource> AvailableResources { get; set; } = [];
    public List<Resource> CostToTravel { get; set; } = [];
    public List<Enemy> Enemies { get; set; } = [];
    public bool Visiting { get; set; }
    public bool FirstTrip { get; set; }
}
