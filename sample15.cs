using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class sample15
    {
        public static void Main()
        {
            Console.WriteLine("Enter Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number % 2 == 0)
            {
                Console.WriteLine("The Number Is Even");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The Number Is Odd");
                Console.ReadKey();
            }
        }
    }
}
