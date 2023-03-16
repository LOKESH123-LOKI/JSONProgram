using System;
namespace JSONProgram
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            InventoryOperation inventory = new InventoryOperation();
            inventory.ReadJsonFile(@"D:\BL excercise\JSONProgram\JSONProgram\InventaryDataManagement\Inventory.Json");
        }
    }
}