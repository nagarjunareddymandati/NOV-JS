using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class sample3
    {
        public static void Main()
        {
            Console.WriteLine("Enter Employee Details:");
            int empid = int.Parse(Console.ReadLine());
            string empName = Console.ReadLine();
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Increment");
            int inc = int.Parse(Console.ReadLine());
            int total = (int)(salary + inc);

            Console.WriteLine("Employee ID:" + empid + ", Employee Name is:" + empName + " and salary is: " + total);
            Console.WriteLine("Emp Id:{0},EmpName:{1},EmpSalary:{2}",empid,empName,total);
            Console.WriteLine($"EmpId:{empid},EmpName:{empName},EmpTotal:{total}");
            Console.ReadKey();
        }
    }
}
