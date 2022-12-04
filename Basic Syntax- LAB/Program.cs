using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Syntax__LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            string studenName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {studenName}, Age: {age}, Grade: {grade:f2}");
        }
    }
}
