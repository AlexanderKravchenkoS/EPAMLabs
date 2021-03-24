using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Task3
    {
        public static void Logic()
        {
            Console.WriteLine("Enter number of stings of matrix -> ");
            bool isStringsANumber = int.TryParse(Console.ReadLine(), out int n);
            if (isStringsANumber)
            {
                if (n > 0)
                {
                    Console.WriteLine("Enter number of column of matrix -> ");
                    bool isColumnANumber = int.TryParse(Console.ReadLine(), out int m);
                    if (isColumnANumber)
                    {
                        if (m > 0)
                        {
                            float[,] initialMatrix;
                            MatrixInput(n, m, out initialMatrix);
                            int maxSimilar = 1;
                            int maxSimilarColumn = 0;
                            SearchStreakOfSimilar(initialMatrix, ref maxSimilar, ref maxSimilarColumn);
                            if (maxSimilar > 1)
                            {
                                Console.WriteLine($"Column with maximum streak of similar items -> {maxSimilarColumn}");
                            }
                            else
                            {
                                Console.WriteLine("There is no streak of similar items in your matrix");
                            }
                        }

                        else
                        {
                            Console.WriteLine("Number of columns must be greater than 0");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Number of columns must be number");
                    }
                }
                else
                {
                    Console.WriteLine("Number of strings must be greater than 0");
                }

            }
            else
            {
                Console.WriteLine("Number of strings must be number");
            }

        }

        private static void MatrixInput(int n, int m, out float[,] initialMatrix)
        {
            initialMatrix = new float[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Enter element[{i + 1},{j + 1}] -> ");
                    bool isElementANumber = float.TryParse(Console.ReadLine(), out float element);
                    if (isElementANumber)
                        initialMatrix[i, j] = element;
                    else
                    {
                        Console.WriteLine("It's not a float number.Try again");
                        j--;
                    }
                }
            }
        }
        
        private static void SearchStreakOfSimilar(float[,] initialMatrix, ref int maxSimilar, ref int maxSimilarColumn)
        {
            for (int j = 0; j < initialMatrix.GetLength(1); j++)
            {
                int tmpMaxSimilar = 1;
                for (int i = 0; i < initialMatrix.GetLength(0) - 1; i++)
                {
                    if (initialMatrix[i, j] == initialMatrix[i + 1, j])
                    {
                        tmpMaxSimilar++;
                    }
                    else
                    {
                        if (tmpMaxSimilar > maxSimilar)
                        {
                            maxSimilar = tmpMaxSimilar;
                            maxSimilarColumn = j;
                            tmpMaxSimilar = 1;
                        }
                    }
                }
            }
        }
    }
}
