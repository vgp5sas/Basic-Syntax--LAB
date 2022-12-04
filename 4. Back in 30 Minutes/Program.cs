using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = 0;
            if (hour >= 0 && hour <= 23 )
            {
                minutes = int.Parse(Console.ReadLine());
            }
            int minutesCorr = minutes + 30;
            if (minutesCorr > 59 )
            {
                if (hour+1 > 23)
                {
                    
                    Console.WriteLine($"{ hour+1 - 24}:{minutesCorr - 60:D2}");
                }
                else
                {
                    Console.WriteLine($"{ hour + 1}:{minutesCorr - 60:D2}");
                }
            }
            else
            {
                Console.WriteLine($"{hour}:{minutesCorr:d2}");
            }
        }
    }
}
