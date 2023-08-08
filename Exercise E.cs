using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ExerciseE
    {

        static void Main(string[] args)
        {

            questionSix();
        }


        static void questionOneA() {
            int number = 3;
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }

        static void questionOneB()
        {
            int number = 3;
            int factorial = 1;
            for (int i = number; i >= 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }


        static void questionTwo() {
            double inverse, squarert, square;
            Console.WriteLine(String.Format("{0,3} {1,12} {2,12} {3,12}", "NO", "INVERSE", "SQUARE ROOT", "SQUARE"));
            Console.WriteLine("-----------------------------------------");
            for (double i = 1.0; i <= 10; i++) {
                inverse = Math.Round(1 / i,3);
                squarert = Math.Round(Math.Sqrt(i),3);
                square = Math.Round(Math.Pow(i, 2),3);
                Console.WriteLine(String.Format("{0,3} {1,12} {2,12} {3,12}", i, inverse, squarert, square));

            }
        }


        static void questionThree() {
            int input = int.Parse(Console.ReadLine());

            if (input <= 1)
            {
                Console.WriteLine("Number is not a prime");
            }

            else if (input <= 3)
            {
                Console.WriteLine("Number is a prime");
            }

            else {
                string isPrime = "Prime";
                
                for (int i = 2; i <= Math.Sqrt(input); i++) {
                    if (input % i == 0) {
                        isPrime = "Not prime";
                    }
                }
                Console.WriteLine(isPrime);
            
            }
        
        }


        static void questionFour() {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= number/2; i++)
            {
                if (number % i ==0) {
                    sum += i;
                }
            }

            if (sum == number) {
                Console.WriteLine("Perfect");
            }
            else
            {
                Console.WriteLine("Not Perfect");
            }

        }

        static void questionFive()
        {
            for (int j = 5; j <= 100; j++)
            {
                {
                    bool isPrime = true;

                    for (int i = 2; i <= Math.Sqrt(j); i++)
                    {
                        if (j % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        Console.WriteLine(j);
                    }

                }
            }

        }


        static void questionSix()
        {
            for (int j = 1; j <= 1000; j++)
            {
                int number = j;
                int sum = 0;
                for (int i = 1; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        sum += i;
                    }
                }

                if (sum == number)
                {
                    Console.WriteLine(number);
                }



            }
        }
    }
        
}
