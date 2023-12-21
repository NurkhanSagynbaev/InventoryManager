using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Класс для управления инвентарем товаров.
class InventoryManager
{
    private List<InventoryItem> inventoryItems = new List<InventoryItem>();

    // Метод для добавления нового товара в инвентарь.
    public void AddItem()
    {
        Console.Write("Введите название товара: ");
        string name = Console.ReadLine();

        Console.Write("Введите цену товара: ");
        decimal price = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Введите количество товара: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        // Создаем новый товар и добавляем его в инвентарь.
        InventoryItem newItem = new InventoryItem(name, price, quantity);
        inventoryItems.Add(newItem);

        Console.WriteLine($"Товар {newItem.Name} добавлен с ID {newItem.ID}.\n");
    }

    // Метод для вывода всех товаров в инвентаре.
    public void ShowAllItems()
    {
        Console.WriteLine("Список товаров в инвентаре:");

        foreach (var item in inventoryItems)
        {
            Console.WriteLine($"ID: {item.ID}, Название: {item.Name}, Цена: {item.Price}, Количество: {item.Quantity}");
        }

        Console.WriteLine();
    }

    // Метод для редактирования информации о товаре по ID.
    public void EditItem(int itemID)
    {
        // Находим товар по ID.
        InventoryItem itemToEdit = inventoryItems.Find(i => i.ID == itemID);

        if (itemToEdit != null)
        {
            Console.WriteLine($"Редактирование товара с ID {itemID}.");

            Console.Write("Введите новое название товара: ");
            itemToEdit.Name = Console.ReadLine();

            Console.Write("Введите новую цену товара: ");
            itemToEdit.Price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Введите новое количество товара: ");
            itemToEdit.Quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Товар с ID {itemID} отредактирован.\n");
        }
        else
        {
            Console.WriteLine($"Товар с ID {itemID} не найден.\n");
        }
    }

    // Метод для удаления товара по ID.
    public void DeleteItem(int itemID)
    {
        // Находим индекс товара по ID.
        int index = inventoryItems.FindIndex(i => i.ID == itemID);

        if (index != -1)
        {
            Console.WriteLine($"Удаление товара с ID {itemID}.");
            inventoryItems.RemoveAt(index);
            Console.WriteLine($"Товар с ID {itemID} удален.\n");
        }
        else
        {
            Console.WriteLine($"Товар с ID {itemID} не найден.\n");
        }
    }
}
