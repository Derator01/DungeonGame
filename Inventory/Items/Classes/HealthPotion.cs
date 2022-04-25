using DungeonGame.Buffs;
using DungeonGame.Buffs.Classes;

namespace DungeonGame.Inventory.Items.Classes;

public class HealthPotion : IConsumable
{
    private readonly int _itemID = 0;
    public int ItemID { get => _itemID; }

    private readonly string _name = "Health Potion";
    public string Name { get => _name; }

    public int Count { get; set; }

    public IBuff Buff { get => _buff; }

    private readonly IBuff _buff = new InstantHp();

    public HealthPotion()
    {
    }

    public void Use()
    {
        throw new NotImplementedException();
    }
}