using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            questionFour();
            
        }


        static void questionFour()
        {
            double distance = Math.Ceiling(double.Parse(Console.ReadLine()) * 10) / 10;
            if (distance <= 0.5)
            {
                Console.WriteLine("Cost is $2.4");
            }
            else if (distance > 0.5 && distance <= 9)
            {
                Console.WriteLine($"Cost is {2.4 + (distance - 0.5) * 0.4}");
            }
            else
            {
                Console.WriteLine($"Cost is {2.4 + 8.5 * 0.4 + (distance - 9) * 0.5}");
            }

        }
    }
}
