namespace DungeonGame.Inventory.Items;

public interface IEquipment : IItem
{
    bool IsBroken { get; set; }

    int Durability { get; set; }
}