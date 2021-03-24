using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Task2
    {
        public static void Logic()
        {
            Console.WriteLine("Enter size of array ");
            bool isArraySizeANumber = int.TryParse(Console.ReadLine(), out int arraySize);
            if (isArraySizeANumber)
            {
                if (arraySize > 0)
                {
                    float[] initialArray;
                    ArrayInput(arraySize, out initialArray);
                    if (arraySize > 1)
                    {
                        Array.Reverse(initialArray);
                        Console.Clear();
                        Console.WriteLine("New vector:");
                        ArrayOutput(initialArray);
                    }
                    else
                    {
                        Console.WriteLine($"You have only one element in array -> {initialArray[0]}");
                    }
                }
                else
                {
                    Console.WriteLine("Size of array must be greater than 0");
                }
            }
            else
            {
                Console.WriteLine("Size of array must be a number");
            }
        }
        private static void ArrayInput(int arraySize, out float[] newArray)
        {
            newArray = new float[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"Enter {i + 1} element -> ");
                bool isElementANumber = float.TryParse(Console.ReadLine(), out float element);
                if (isElementANumber)
                    newArray[i] = element;
                else
                {
                    Console.WriteLine("It's not a float number.Try again");
                    i--;
                }
            }
        }

        private static void ArrayOutput(float[] arrayForOutput)
        {
            foreach (float element in arrayForOutput)
            {
                Console.WriteLine(element);
            }
        }
    }
}
