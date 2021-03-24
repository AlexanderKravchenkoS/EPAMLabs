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
            Console.WriteLine("Enter your natural number in the decimal system ");
            Converter converter = new Converter(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Your Number in decimal Representation -> {converter.InitialNumber} \nYour Number in Binary Representation -> {converter.BinaryRepresentation}");
        }
    }
}
