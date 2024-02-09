using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class student
    {
        int rollNo; string stdName;
        int sub1, sub2, sub3;

        public void GetStudentData()
        {
            Console.WriteLine("Enter Student Details: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            stdName = Console.ReadLine();
            sub1 = Convert.ToInt32(Console.ReadLine());
            sub2 = Convert.ToInt32(Console.ReadLine());
            sub3 = Convert.ToInt32(Console.ReadLine());
        }

        public string Result()
        {
            int total = sub1 + sub2 + sub3;
            int avg = total / 3;
            if (avg > 35)
            {
                return "Pass";
            }
            else
            {
                return "Fail";
            }
        }

        public void Display()
        {
            Console.WriteLine($"Student Name is: {stdName}\nSub1: {sub1}\nSub2: {sub2}\nSub3: {sub3}\n");
        }
    }
}
class stu
{
    public static void Main()
    {
        
      
       
    }
}
