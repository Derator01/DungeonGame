using DungeonGame.Inventory;
using DungeonGame.Inventory.Items.Classes;
using DungeonGame.Inventory.Extensions;

namespace DungeonGame;

internal static class MainClass
{
    private static InventoryInstance _invetory = new();

    //  delegate void Update();

    private static void Main()
    {
        Console.WriteLine("Welcome to Game!");

        HealthPotion health = new HealthPotion();

        _invetory.Consumables.AddClass(new HealthPotion());

        _invetory.Consumables.AddClass(new HealthPotion());

        Console.WriteLine(_invetory.ToString());
    }
}