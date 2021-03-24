using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Initial X -> ");
            double initialX = double.Parse(Console.ReadLine());
            Console.Write(" Eventual X -> ");
            double eventualX = double.Parse(Console.ReadLine());
            Console.Write(" Step value -> ");
            double dx = double.Parse(Console.ReadLine());
            Console.Write(" Accuracy -> ");
            double accuracy = double.Parse(Console.ReadLine());
            if (ValidateData(initialX, eventualX, dx, accuracy))
            {
                Logic executer = new Logic(initialX, eventualX, dx, accuracy);
                DrawTable(executer);
            }
        }

        private static bool ValidateData(double initialX, double eventualX, double dx, double accurancy)
        {
            if (eventualX > initialX)
            {
                if (dx > 0)
                {
                    if (eventualX - initialX > dx)
                    {
                        if (initialX > -1 && eventualX > -1 && initialX < 1 && eventualX < 1)
                        {
                            if (accurancy > 0)
                            {
                                return true;
                            }
                            else
                            {
                                Console.WriteLine("Accurancy should be greater than zero");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Eventual X And Initial X  should be greater than 1 ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Difference between eventual and inial x should be greater than step");
                    }
                }
                else
                {
                    Console.WriteLine("Step should be greater than zero");
                }
            }
            else
            {
                Console.WriteLine("Eventual X should Be greater than initial X");
            }
            return false;
        }

        private static void DrawTable(Logic executer)
        {
            Console.WriteLine(" \n      |   Table of Calculations:   |      \n ");
            Console.WriteLine("|    X  ||    Y     ||Steps||  YByFunc  | ");
            for (int i = 0; i < executer.SizeOfTable; i++)
            {
                Console.WriteLine($"| {executer.Arguments[i].ToString("F3")} || {executer.FunctionValuesWithRaws[i].ToString("F6")} || {executer.Steps[i]} | | {executer.FunctionValues[i].ToString("F6")} |");
            }
        }
    }
}
