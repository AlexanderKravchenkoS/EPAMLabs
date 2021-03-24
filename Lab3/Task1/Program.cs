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
            double x;
            double? y;
            Console.WriteLine("Enter Function's argument");
            x = double.Parse(Console.ReadLine());
            y = СalculateFunctionValue(x);
            OutputFunctionValue(y);
        }

        
        private static double? СalculateFunctionValue(double x)
        {
            double? y;

            if (x > -10 && x < 0)   
            {
                y = (- x / 2) - 3;
            }
            else if (x >= 0 && x <= 3)
            {
                const int radius = 3;
                y = -Math.Sqrt(Math.Pow(radius, 2) - Math.Pow(x, 2));
            } 
            else if(x>3 && x < 6)
            {
                const int radius = 3;
                y = Math.Sqrt(Math.Pow(radius, 2) - Math.Pow((x-6), 2));
            }
            else if (x >= 6 && x <= 8)
            {
                y = 0;
            }
            else
            {
                y = null;
            }

            return y;
        }
        private static void OutputFunctionValue(double? y)
        {
            if (y == null)
            {
                Console.WriteLine("Function is undefined");
            }
            else
            {
                Console.WriteLine($"Funtion's value = {y}");
            }
        }
    }
}
