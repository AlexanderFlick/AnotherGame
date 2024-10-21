namespace Game.Data.Models.Resources;

public class Resource
{
    public string Name { get; set; }
    public int Value { get; set; }
    public int QuantityPerClick { get; set; } = 1;
    public List<Resource> CostToCraft { get; set; } = [];
}
