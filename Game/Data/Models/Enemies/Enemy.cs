namespace Game.Data.Models.Enemies;

public class Enemy
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public EnemyType EnemyType { get; set; }
}
