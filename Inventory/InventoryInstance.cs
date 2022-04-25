using DungeonGame.Inventory.Items;
using System.Text;

namespace DungeonGame.Inventory;

internal sealed class InventoryInstance
{
    public List<IEquipment> Equipment = new();
    public List<IConsumable> Consumables = new();

    public override string ToString()
    {
        StringBuilder outString = new();

        foreach (var item in Equipment)
        {
            if (item.Durability == -1)
            {
                outString.Append($"{item.Name} can not be Broken.\n");
            }
            else
            {
                if (item.IsBroken)
                    outString.Append($"{item.Name} is Broken.\n");
                else
                    outString.Append($"{item.Name} is not Broken, it has {item.Durability} Durability Points.\n");
            }
        }

        foreach (var item in Consumables)
        {
            if (item.Count == 1)
                outString.Append($"{item.Name} and its effect is {item.Buff}\n");
            else
                outString.Append($"{item.Count} {item.Name}s and their effect is {item.Buff}\n");
        }

        return outString.ToString();
    }
}