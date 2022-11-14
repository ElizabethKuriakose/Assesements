// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using CodingChallenge;


//var passenger = new string[5];

//Console.WriteLine("Enter passenger names:");
//for (int i = 0; i < passenger.Length; i++)
//{
//    passenger[i] = Console.ReadLine();
//}

////Assending order
////Array.Sort(passenger);
//var temp = "";
//for (int i = 0; i < passenger.Length; i++)
//{
//    for (int j = i + 1; j < passenger.Length; j++)
//    {
//        if ((passenger[i].ToLower())[0] > (passenger[j].ToLower())[0])
//        {
//            temp = passenger[i];
//            passenger[i] = passenger[j];
//            passenger[j] = temp;
//        }
//    }
//}
//Console.WriteLine("Ascending Order");
//foreach (var item in passenger)
//{
//    Console.Write($" {item}");
//}

////Descending Order
//var temp1 = "";
//for (int i = 0; i < passenger.Length; i++)
//{
//    for (int j = i + 1; j < passenger.Length; j++)
//    {
//        if ((passenger[i].ToLower())[0] < (passenger[j].ToLower())[0])
//        {
//            temp1 = passenger[i];
//            passenger[i] = passenger[j];
//            passenger[j] = temp1;
//        }
//    }
//}
//Console.WriteLine();
//Console.WriteLine("\nDescending Order");
//foreach (var item in passenger)
//{
//    Console.Write($" {item}");
//}


////Search for an item
//Console.WriteLine();
//Console.WriteLine("Enter name to search");
//var name = Console.ReadLine();
//bool flag = false;
//foreach (var item in passenger)
//{
//    if (item.ToLower() == name.ToLower())
//    { 
//        flag = true;
//        break;
//    } 
//}
//if(flag == true)
//    {
//        Console.WriteLine($"Found {name}");
//    }
//    else
//    {
//        Console.WriteLine($"Not Found {name}");
//    }

////length of name
//Console.WriteLine();
//int c=0;
//foreach (var item in passenger)
//{
//    for (int i = 0; i < item.Length; i++)
//    {
//        if (item[i] == ' ')
//        {
//            continue;
//        }
//        else
//        {
//            c++;
//        }
//    }
//    Console.WriteLine($"Length of {item} : {c}");
//    c = 0;
//}

////split the names at space

//foreach (var item in passenger)
//{
//    //FirstNames = item.Split(' ','\t');
//    for (int i = 0; i < item.Length; i++)
//    {
//        if (item[i] == ' ')
//        {
//            Console.WriteLine();
//            Console.Write("First Name:");
//            for (int j = 0; j < i; j++)
//            {

//                Console.Write($"{item[j]}");
//            }
//            Console.WriteLine();
//            Console.Write("Last Name:");
//            for (int kk = i+1; kk < item.Length; kk++)
//            {

//                Console.Write($"{item[kk]}");
//            }
//        }
//        //Console.WriteLine(FirstNames[i]);
//        //Console.WriteLine($"First Name:{FirstNames[i]} Last Name:{FirstNames[i+1]}");
//    }
//}

////duplicates
//var duplicate = new string[passenger.Length];
//int k = 0;
//foreach (var it in passenger)
//{
//    int count = 0;
//    foreach (var item in passenger)
//    {
//        if (it == item)
//            count++;
//    }
//    if (count >= 2)
//    {
//        bool hasFoundMatch = false;
//        foreach (var i in duplicate)
//        {
//            if (i == it)
//            {
//                hasFoundMatch = true;
//                break;
//            }
//        }
//        if (!hasFoundMatch)
//            duplicate[k++] = it;
//    }
//}
//Console.WriteLine();
//Console.WriteLine("Duplicates:");
//Console.WriteLine(String.Join(" ", duplicate));

//------------------------------------------------------------------------------

//var fl = new Flight();


//fl.GetMethod();

//------------------------------------------------------------------------------


//Flight2[] fl1 = new Flight2[5];

//for (int i = 0; i < 10; i++)
//{
//    fl1[i] = new Flight2();
//}

//-----------------------------------------------------------------------------

//int current_date = 22;
//int current_month = 11;
//int current_year = 2022;

//// birth dd// mm// yyyy
//int birth_date = 12;
//int birth_month = 2;
//int birth_year = 2000;

//// function call to print age

//var pa = new PassengerAge();
//pa.findAge(current_date, current_month,
//           current_year, birth_date,
//           birth_month, birth_year);



//-----------------------------------------------------------------

var fl2 = new Flight2();
fl2.SetData();
Console.WriteLine();
fl2.Ascending();
Console.WriteLine();
fl2.Descending();
Console.WriteLine();
fl2.Duplicate();
Console.WriteLine();
fl2.MaxMin();
Console.WriteLine();
fl2.Search();
Console.WriteLine();
fl2.GetData();



//-----------------------------------------------------------------

//var pa = new PassengerAge();

//pa.SetData();
//pa.GetData();
//pa.Details();

//-----------------------------------------------------------------