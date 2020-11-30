using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studGrades = new int[] { 49, 60, 79, 46, 58, 75, 94, 44, 67, 86 };

            foreach (int grade in studGrades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
