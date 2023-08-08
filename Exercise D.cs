using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ExerciseD
    {

        static void Main(string[] args)
        {

            questionThree();
        }


        static void questionOne()
        {
            int number = 0;

            while (number != 88) {
                number = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Lucky you...");
        }


        static void questionTwo() {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int large = Math.Max(a, b);
            int small = Math.Min(a, b);
            int temp;

            while (large != small) {
                large -= small;
                if (large < small) {
                    temp = large;
                    large = small;
                    small = temp;
                }
            }

            int HCF = a;
            int LCM = (a * b) / HCF;
            Console.WriteLine(HCF);
            Console.WriteLine(LCM);
        }


        static void questionThree() { 
            Random rnd = new Random();
            int machineNum = rnd.Next(9);
            int guess = -1;
            int count = 0;

            while (guess != machineNum) {
                guess = int.Parse(Console.ReadLine());
                Console.WriteLine("Try again");
                count++;
            }


            if (count <= 2)
            {
                Console.WriteLine("You are a Wizard!");
            }
            else if (count <= 5)
            {
                Console.WriteLine($"You are a good guess");
            }
            else {
                Console.WriteLine("You are lousy");
            }

        
        }
    }
}
