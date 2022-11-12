using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assessment;

internal class Company
{
    public string CName { get; set; }
    public string Type { get; set; }
}
class Employees : Company
{
    public string EmployeeName { get; set; }
    public string Designation { get; set; }
    public void ReadData()
    {
        Console.WriteLine();
        Console.Write("Company Name   :  ");
        CName = Console.ReadLine();
        Console.Write("Type   :  ");
        Type = Console.ReadLine();
        Console.Write("Employee Name   :  ");
        EmployeeName = Console.ReadLine();
        Console.Write("Designation   :  ");
        Designation = Console.ReadLine();
    }
    public void ShowData()
    {
        Console.WriteLine();
        Console.WriteLine($"Company Name         : {CName}");
        Console.WriteLine($"Type                 : {Type}");
        Console.WriteLine($"Employee Name        : {EmployeeName}");
        Console.WriteLine($"Designation          : {Designation}");
    }
}
