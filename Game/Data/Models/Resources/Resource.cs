namespace Game.Data.Models.Resources;

public class Resource : Item
{
    public string Name { get; set; }
    public int Value { get; set; }
    public int QuantityPerClick { get; set; } = 1;
    public List<Resource> CostToCraft { get; set; } = [];
    public int GoldValue { get; set; }
}
