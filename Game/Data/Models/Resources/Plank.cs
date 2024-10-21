namespace Game.Data.Models.Resources;

public class Plank : Resource
{
    public Plank()
    {
        Name = "Plank";
        Value = 6;
        CostToCraft = [new Wood(), new Wood(), new Wood(), new Wood()];
    }
}
