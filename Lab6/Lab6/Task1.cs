using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Task1
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
                    int counterOfPositiveElements = 0;
                    PositiveElementCount(initialArray, ref counterOfPositiveElements);
                    if (counterOfPositiveElements > 0)
                    {
                        Console.WriteLine($"Sum of Positive elements -> {counterOfPositiveElements}");
                    }
                    else
                    {
                        Console.WriteLine("There is no Positive elments");
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

        private static void PositiveElementCount(float[] arrray, ref int counter)
        {
            
            counter = arrray.Where(element => element > 0).ToList().Count;
        }
    }
}
