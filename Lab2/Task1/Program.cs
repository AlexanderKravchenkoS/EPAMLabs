using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number -> ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter The Degree -> ");
            int degree = int.Parse(Console.ReadLine());

            RootCalculation rootCalculation = new RootCalculation(number, degree);

            Console.WriteLine($"Your Result is : {rootCalculation.NewtonRoot}");
            Console.WriteLine($"Result by Math Pow {rootCalculation.PowRoot}");
            Console.WriteLine($"The difference is aroud : {rootCalculation.DifferenceBetweenRoots.ToString("F7")}");
        }
    }
}
