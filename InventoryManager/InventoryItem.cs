using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Класс, представляющий товар в инвентаре.
class InventoryItem
{
    public static int CurrentID = 1;

    public int ID { get; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    // Конструктор для создания нового товара.
    public InventoryItem(string name, decimal price, int quantity)
    {
        ID = CurrentID++;
        Name = name;
        Price = price;
        Quantity = quantity;
    }
}
