using DungeonGame.Inventory.Items;

namespace DungeonGame.Inventory.Extensions;

internal static class ListExtensions
{
    public static void AddClass(this List<IConsumable> list, IConsumable consumable)
    {
        IConsumable? foundItem = list.ContainsClass(consumable);

        if (foundItem != null)
            foundItem.Count++;
        else
            list.Add(consumable);
    }

    public static IConsumable? ContainsClass(this List<IConsumable> list, IConsumable consumable)
    {
        foreach (IConsumable item in list)
        {
            if (consumable.GetType() == item.GetType())
            {
                return consumable;
            }
        }
        return null;
    }
}