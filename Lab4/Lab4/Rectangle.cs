using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Rectangle
    {
        private Point _startPoint;
        private double _height;
        private double _width;
        private double _perimetr;
        private double _square;

        public double Perimetr => _perimetr;

        public double Square => _square;

        public Rectangle(Point startPoint, double height, double width)
        {
            if (height != 0 && width !=0)
            {
                _startPoint = startPoint;
                _height = height;
                _width = width;
                _perimetr = CalculatePrimetr();
                _square = CalculateSquare();
            }
        }

        public Rectangle()
        {
            throw new Exception("You can't built rectagle without Start Point, width and height");
        }

        private double CalculatePrimetr()
        {
            return (Math.Abs(_height)+Math.Abs(_width))*2;
        }
        private double CalculateSquare()
        {
            return Math.Abs(_width * _height);
        }

        public void ShowAllInformation()
        {
            Console.WriteLine("We have a Rectangle with :");
            Console.WriteLine($"Main point -> ( {_startPoint.X.ToString("F5")} ; {_startPoint.Y.ToString("F5")} )");
            Console.WriteLine($"Widgth -> {_width.ToString("F5")}");
            Console.WriteLine($"Height -> {_height.ToString("F5")}");
            Console.WriteLine($"Point A -> ( {_startPoint.X.ToString("F5")} ; {(_startPoint.Y + _height).ToString("F5")} )");
            Console.WriteLine($"Point B -> ( {(_startPoint.X + _width).ToString("F5")} ; {(_startPoint.Y + _height).ToString("F5")} )");
            Console.WriteLine($"Point C -> ( {(_startPoint.X + _width).ToString("F5")} ; {_startPoint.Y.ToString("F5")} )");
            Console.WriteLine($"Point D -> ( {_startPoint.X.ToString("F5")} ; {_startPoint.Y.ToString("F5")} )");
        }

        public void Move()
        {
            Console.WriteLine("Enter X and Y to move your rectanagle");
            Console.WriteLine("X -> ");
            double diffX = int.Parse(Console.ReadLine());
            Console.WriteLine("Y -> ");
            double diffY = int.Parse(Console.ReadLine());
            _startPoint = new Point(_startPoint.X + diffX, _startPoint.Y + diffY);
        }

        public void Resize()
        {
            Console.WriteLine("Enter new width and height for your rectangle");
            Console.WriteLine("Width -> ");
            _width = double.Parse(Console.ReadLine());
            Console.WriteLine("Height -> ");
            _height = double.Parse(Console.ReadLine());
        }
    }
}
