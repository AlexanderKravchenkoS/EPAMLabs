using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    struct Magister
    {
        public string SecondName { get; }
        public string Faculty { get; }
        public int SpecialtyCode { get; }
        public int FirstMark { get; }
        public int SecondMark { get; }
        public int ThirdMark { get; }
        public Magister(string secondName, string faculty, int specialtyCode, int firstMark, int secondMark, int thirdMark)
        {
            SecondName = secondName;
            Faculty = faculty;
            SpecialtyCode = specialtyCode;
            FirstMark = firstMark;
            SecondMark = secondMark;
            ThirdMark = thirdMark;
        }
    }
}
