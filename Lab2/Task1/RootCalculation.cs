using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class RootCalculation
    {
        public double PowRoot { get; private set; }
        public double NewtonRoot { get; private set; }
        public double DifferenceBetweenRoots { get; private set; }

        public RootCalculation(int number, int degree)
        {
            NewtonRoot = NewtonRootCalculation(number, degree);
            PowRoot = Math.Pow(number, (double)1 / degree);
            DifferenceBetweenRoots = FindDifferenceBetweenTwoWaysOfCalculations(NewtonRoot, PowRoot);
        }

        public double NewtonRootCalculation(int number, int degree)
        {
            int nearestNumberWithRoot = FindNearestIntegerRoot(number, degree);
            double dividedNumber = (double)number / Math.Exp(Math.Log(nearestNumberWithRoot) * (degree - 1));
            double result = ((degree - 1) * nearestNumberWithRoot + dividedNumber) / (double)degree;
            return result;
        }

        private double FindDifferenceBetweenTwoWaysOfCalculations(double firstResult, double secondResult)
        {

            return Math.Abs(firstResult - secondResult);
        }

        private int FindNearestIntegerRoot(int number, int degree)
        {

            double newtonroot = Math.Exp(Math.Log(number) / degree);
            return (int)Math.Round(newtonroot);
        }
    }
}
