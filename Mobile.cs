using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assessment;

internal class Mobile
{
    public string MobName { get; set; }
    public string Model { get; set; }
    public int Price { get; set; }
    public string Company { get; set; }

    public void ReadData()
    {
        Console.WriteLine();
        Console.Write("Name : ");
        MobName = Console.ReadLine();
        Console.Write("Model : ");
        Model = Console.ReadLine();
        Console.Write("Price : ");
        Price = int.Parse(Console.ReadLine());
        Console.Write("Company : ");
        Company = Console.ReadLine();
    }
    
    public void ReadData(string name,string model,int price,string com)
    {
        MobName = name;
        Model = model;
        Price = price;
        Company = com;
    }
    public void ReadData(string name, string model, int price)
    {
        MobName = name;
        Model = model;
        Price = price;
        Company = "Apple";
    }
    public void Showdata()
    {
        Console.WriteLine();
        Console.WriteLine($"Name   : {MobName}");
        Console.WriteLine($"Model  : { Model}");
        Console.WriteLine($"Price  : {Price}");
        Console.WriteLine($"Company: {Company}");
    }

}
