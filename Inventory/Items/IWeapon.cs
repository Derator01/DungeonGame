namespace DungeonGame.Inventory.Items;

public interface IWeapon : IEquipment
{
    int Damage { get; set; }
}