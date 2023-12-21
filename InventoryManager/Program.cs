using System;

class Program
{
    static void Main()
    {
        InventoryManager inventoryManager = new InventoryManager();
        string choice;

        do
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Добавить товар");
            Console.WriteLine("2. Показать все товары");
            Console.WriteLine("3. Редактировать товар");
            Console.WriteLine("4. Удалить товар");
            Console.WriteLine("5. Выход");

            Console.Write("Выберите действие : ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    inventoryManager.AddItem();
                    break;
                case "2":
                    inventoryManager.ShowAllItems();
                    break;
                case "3":
                    Console.Write("Введите ID товара для редактирования: ");
                    int editID = Convert.ToInt32(Console.ReadLine());
                    inventoryManager.EditItem(editID);
                    break;
                case "4":
                    Console.Write("Введите ID товара для удаления: ");
                    int deleteID = Convert.ToInt32(Console.ReadLine());
                    inventoryManager.DeleteItem(deleteID);
                    break;
                case "5":
                    Console.WriteLine("Выход из программы.");
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.\n");
                    break;
            }
        } while (choice != "5");
    }
}

