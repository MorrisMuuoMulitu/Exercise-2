using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, divisor = 5;
            Console.Write("Enter the number: ");
            if (int.TryParse(Console.ReadLine(),out number)&& number > 0 )
            {
            //number = int.Parse(Console.ReadLine());
            if (number%2==0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
            if (number%divisor==0)
            {
                Console.WriteLine("Divisible by " + divisor);
            }
            else
            {
                Console.WriteLine("Cannot divide by " + divisor);
            }
        }
            else
            {
                Console.WriteLine("Wrong data !");
            }
    }
    }

}

