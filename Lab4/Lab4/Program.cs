using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinates of rectangle main point, width and height");
            string userInput = "";
            while (userInput != "exit")
            {
                #region Enter initial Data
                Console.Write("Enter x -> ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Enter y -> ");
                double y = double.Parse(Console.ReadLine());
                Console.Write("Enter width -> ");
                double width = double.Parse(Console.ReadLine());
                Console.Write("Enter height -> ");
                double height = double.Parse(Console.ReadLine());
                #endregion
                Rectangle rectangle = new Rectangle(new Point(x, y), height, width);
                ShowMainProperites(rectangle);
                Console.WriteLine("\nIf you want to exit enter \'exit\'");
                Console.WriteLine("If you want to create new Rectangle enter any other symbol");
                userInput = Console.ReadLine();
                Console.Clear();
            }
        }

        private static void ShowMainProperites(Rectangle rectangle)
        {
            rectangle.ShowAllInformation();
            Console.WriteLine($"Perimetr -> {rectangle.Perimetr.ToString("F5")}");
            Console.WriteLine($"Square -> {rectangle.Square.ToString("F5")}");
            RectSelection(rectangle);
        }

        private static void RectSelection(Rectangle rectangle)
        {
            Console.WriteLine("What do you want to do with rectangle\n");
            Console.WriteLine("1 - Move it\n");
            Console.WriteLine("2 - Resize it\n");
            Console.WriteLine("3 - Nothing\n");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    rectangle.Move();
                    Console.Clear();
                    ShowMainProperites(rectangle);
                    break;
                case "2":
                    rectangle.Resize();
                    Console.Clear();
                    ShowMainProperites(rectangle);
                    break;
                case "3":
                    break;
                default:
                    Console.Clear();
                    ShowMainProperites(rectangle);
                    break;
            }
        }
    }
}
