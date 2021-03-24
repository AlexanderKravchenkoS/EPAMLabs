using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Logic
    {
        private readonly double _initialX;
        private readonly double _eventualX;
        private readonly double _dx;
        private readonly double _accuracy;
        private int _sizeOfTable;

        public int SizeOfTable => _sizeOfTable;

        public double[] Arguments { get; private set; }
        public double[] FunctionValuesWithRaws { get; private set; }
        public int[] Steps { get; private set; }
        public double[] FunctionValues { get; private set; }


        public Logic(double _initialX, double _eventualX, double _dx, double _accuracy)
        {
            this._initialX = _initialX;
            this._eventualX = _eventualX;
            this._dx = _dx;
            this._accuracy = _accuracy;

            _sizeOfTable = (int)(Math.Round((Math.Round(_eventualX - _initialX, 6)) / _dx, 6)) + 1;

            Arguments = new double[_sizeOfTable];
            FunctionValuesWithRaws = new double[_sizeOfTable];
            Steps = new int[_sizeOfTable];
            FunctionValues = new double[_sizeOfTable];

            CalculateTablesValue();
        }
        private void CalculateTablesValue()
        {
            int counter = 0;
            double y;
            double currentMember;
            int n;
            for (double i = _initialX; Math.Round(i, 6) <= (float)_eventualX; i += (float)_dx)
            {

                y = 0;
                currentMember = 1;
                for (n = 0; Math.Abs(currentMember) >= _accuracy; n++)
                {
                    currentMember = (Math.Pow(-1, (double)n) * Math.Pow(i, (double)(n + 1))) / (n + 1);
                    y += currentMember;
                }
                Arguments[counter] = i;
                FunctionValuesWithRaws[counter] = y;
                Steps[counter] = n;
                FunctionValues[counter] = Math.Log(i + 1);
                counter++;
            }
        }
    }
}
