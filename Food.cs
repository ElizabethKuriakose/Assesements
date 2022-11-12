using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment;

internal class Food
{
    public string Name { get; set; }
    public int Price { get; set; }

    public int Discount { get; set; }
    //private int _discount;

    //public int Discount
    //{
    //    get { return _discount; }
    //    set { 
    //        if(Price > 150)
    //        {
    //            value = 10;
    //            return;
    //        }
    //        _discount = value; }
    //}

    public void CalculatePrize()
    {
        if (Price > 150)
        {
            Discount = 10;
        }
        var dis = (Price * Discount)/100;
        Price -= dis;
        Console.WriteLine($"Total Price = {Price}");
    }
}
