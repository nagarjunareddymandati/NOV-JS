using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class sample6
    {
        public static void Main()
        {
            Console.WriteLine("Enter Any Number");
            int No =int.Parse(Console.ReadLine());
            if (No % 2 == 0) 
            {
                Console.WriteLine("Even");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Odd");
                Console.ReadKey();
            }
        }
       
    }
}
