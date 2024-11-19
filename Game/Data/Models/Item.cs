namespace Game.Data.Models;

public interface Item
{
    string Name { get; set; }
    int GoldValue { get; set; }
    public int CostToCraft { get; set; }
}
