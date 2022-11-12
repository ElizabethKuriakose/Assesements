using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment;

internal class FizzBuzz
{
    public FizzBuzz()
    {
        for(int i = 1; i <= 50; i++)
        {
            if(i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("fizzBuzz");
            }
            else if(i % 5 == 0)
            {
                Console.WriteLine("fizz");
            }
            else if(i % 3 == 0)
            {
                Console.WriteLine("bizz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
