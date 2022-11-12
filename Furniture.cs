using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assessment;

internal class Furniture
{
    public string Type { get; set; }
    public string Wood { get; set; }

    public int Price { get; set; }

    public Furniture(string type, string wood, int price)
    {
        Type = type;
        Wood = wood;
        Price = price;
    }
    public Furniture()
    {
        Console.WriteLine();
        Console.Write("Type : ");
        Type = Console.ReadLine();
        Console.Write("Wood : ");
        Wood = Console.ReadLine();
        Console.Write("Price : ");
        Price = int.Parse(Console.ReadLine());
    }
    public void ShowData()
    {
        Console.WriteLine();
        Console.WriteLine($"Type   : {Type}");
        Console.WriteLine($"Wood   : {Wood}");
        Console.WriteLine($"Price  : {Price}");
    }
}
