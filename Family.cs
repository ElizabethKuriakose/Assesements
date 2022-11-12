using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment;

internal class Parent
{
    public string FamilyName { get; set; }
}
class Child : Parent
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Occupation { get; set; }

    public void Set()
    {
        Console.WriteLine();
        Console.Write("Name   :  ");
        Name = Console.ReadLine();
        Console.Write("Family Name   :  ");
        FamilyName = Console.ReadLine();
        Console.Write("Age   :  ");
        Age = int.Parse(Console.ReadLine());
        Console.Write("Occupation   :  ");
        Occupation = Console.ReadLine();
    }
    public void ShowData()
    {
        Console.WriteLine();
        Console.WriteLine($"Name          : {Name}");
        Console.WriteLine($"Family Name   : {FamilyName}");
        Console.WriteLine($"Age           : {Age}");
        Console.WriteLine($"Occupation    : {Occupation}");
    }
}
