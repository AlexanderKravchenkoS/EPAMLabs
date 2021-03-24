using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Task4
    {
        Magister[] magisters = new Magister[]
        {
            new Magister("Lorens", "Math", 12, 8, 6, 9),
            new Magister("Woren", "Biology", 24, 5, 7, 6),
            new Magister("Adams", "Law", 41, 9, 5, 7),
            new Magister("Smith", "Phisics", 31, 8, 9, 9),
            new Magister("Figg", "Chemistry", 11, 7, 6, 8)
        };
        public static void Logic()
        {
            Task4 program = new Task4();
            Console.WriteLine("Enter Second Name of magiter -> ");
            string inputSecondName = Console.ReadLine();
            bool isMagisterExists = program.FindMagister(inputSecondName);
            if (isMagisterExists)
            {
                Magister requiredMagister = program.PickMagister(inputSecondName);
                Console.WriteLine("Enter Last Mark -> ");
                int inputLastMark = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Group Number -> ");
                int inputGroupNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter year of admission -> ");
                int inputYearOfAdmission = int.Parse(Console.ReadLine());
                program.GenerateFinalCortage(requiredMagister, inputLastMark, inputGroupNumber, inputYearOfAdmission);
            }
            else
            {
                Console.WriteLine("Such Magister isn't exists");
            }
        }

        private bool FindMagister(string inputSecondName)
        {
            foreach (var item in magisters.Where(item => item.SecondName == inputSecondName))
            {
                return true;
            }
            return false;
        }
        
        private Magister PickMagister(string inputSecondName)
        {
            return magisters.First(item => item.SecondName == inputSecondName);
        }

        private void GenerateFinalCortage(Magister requiredMagister,int inputLastMark, int inputGroupNumber, int inputYearOfAdmission)
        {
            Console.Clear();
            Console.WriteLine($"Second Name -> {requiredMagister.SecondName}");
            Console.WriteLine($"Faculty -> {requiredMagister.Faculty}");
            Console.WriteLine($"Student number -> {requiredMagister.SpecialtyCode}{inputGroupNumber}");
            Console.WriteLine($"Average mark -> {(requiredMagister.FirstMark + requiredMagister.SecondMark + requiredMagister.ThirdMark + inputLastMark) /4}");
            Console.WriteLine($"Course -> {DateTime.Today.Year - inputYearOfAdmission}");
        }
    }
}
