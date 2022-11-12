using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assessment;

internal class School
{
    public string SchoolName { get; set; }
    public int MonthFee { get; set; }

    public School(string schoolName, int monthFee)
    {
        SchoolName = schoolName;
        MonthFee = monthFee;
    }   
}
class Student : School

{
    public Student(string schoolName, int monthFee) : base(schoolName, monthFee)
    {
    }

    public string StudentName { get; set; }
    public int Class { get; set; }
    public int Age { get; set; }
}
class Sports : Student


{
    public Sports(string schoolName, int monthFee) : base(schoolName, monthFee)
    {
        SchoolName = schoolName;
    }

    public string Item1 { get; set; }
    public string Item2 { get; set; }
    public string Item3 { get; set; }
    public string Item4 { get; set; }

    public void ReadData()
    {
        Console.WriteLine();
        Console.Write("Student Name   :  ");
        StudentName = Console.ReadLine();
        Console.Write("Class   : ");
        Class = int.Parse(Console.ReadLine());
        Console.Write("Age   :  ");
        Age = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Item 1   :  ");
        Item1 = Console.ReadLine();
        Console.Write("Item 2   : ");
        Item2 = Console.ReadLine();
        if (Age > 12) {
            Console.Write("Item 3   :  ");
            Item3 = Console.ReadLine();
            Console.Write("Item 4   :  ");
            Item4 = Console.ReadLine();
        }
        
    }
    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"School Name        : {SchoolName}");
        Console.WriteLine($"Student Name       : {StudentName}");
        Console.WriteLine($"Age                : {Age}");
        Console.WriteLine($"Class              : {Class}");
        Console.WriteLine();
        Console.WriteLine($"Item 1             : {Item1}");
        Console.WriteLine($"Item 2             : {Item2}");
        if (Age > 12)
        {
            Console.WriteLine($"Item 3             : {Item3}");
            Console.WriteLine($"Item 4             : {Item4}");
        }
    }
}
