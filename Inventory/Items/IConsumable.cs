using DungeonGame.Buffs;

namespace DungeonGame.Inventory.Items;

public interface IConsumable : IItem
{
    int Count { get; set; }

    IBuff Buff { get; }

    void Use();
}