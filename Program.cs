// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Assessment;
//using System.Diagnostics;
//using System.Reflection;

//var em1 = new Employee()
//{
//    EmployeeName = "Liz",
//    Department = "ESS",
//    Designtion = "Trainee",
//    Salary = 2000
//};
//var em2 = new Employee()
//{
//    EmployeeName = "Jain",
//    Department = "ESS",
//    Designtion = "Manager",
//    Salary = 30000
//};
//var em3 = new Employee()
//{
//    EmployeeName = "Vismaya",
//    Department = "ESS",
//    Designtion = "Senior Developer",
//    Salary = 30000
//};

//em1.ShowData();
//em2.ShowData();
//em3.ShowData();
//---------------------------------------------------------

//var mob1 = new Mobile();
//mob1.ReadData();

//var mob2 = new Mobile();
//Console.WriteLine();
//Console.Write("Name : ");
//var mn = Console.ReadLine();
//Console.Write("Model : ");
//var mod = Console.ReadLine();
//Console.Write("Price : ");
//var pr = int.Parse(Console.ReadLine());
//Console.Write("Company : ");
//var com = Console.ReadLine();
//mob2.ReadData(mn, mod, pr, com);

//var mob3 = new Mobile();
//mob3.ReadData(mn, mod, pr);

//mob1.Showdata();
//mob2.Showdata();
//mob3.Showdata();

//--------------------------------------------------------

//var an1 = new Animal()
//{
//    Name = "Dog",
//    MaxLifeTime = "20 Years",
//    Food = "Pedigree"
//};

//Console.WriteLine($"Name         : {an1.Name}");
//Console.WriteLine($"Max Life span: {an1.MaxLifeTime}");
//Console.WriteLine($"Food         : {an1.Food}");

//-------------------------------------------------------------

//var fur1 = new Furniture("Chair", "Thekk", 2000);
//var fur2 = new Furniture();
//fur1.ShowData();
//fur2.ShowData();

//-------------------------------------------------------------

var fd1 = new Food()
{
    Name = "Ice Cream",
    Price = 200
};

fd1.CalculatePrize();