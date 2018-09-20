using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Grades;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook gradeBook = new GradeBook();

            Console.WriteLine("Enter Grade, 0 to stop");
            string answer = Console.ReadLine();

            while (answer != "0")
            {
                try
                {
                    gradeBook.AddGrade(float.Parse(answer));
                }
                catch (Exception errorException)
                {
                    Console.WriteLine(errorException);
                }

                Console.WriteLine("Enter Grade, 0 to stop");
                answer = Console.ReadLine();
            }


            Console.WriteLine("Max: " + gradeBook.GetMax());
            Console.WriteLine("Min: " + gradeBook.GetMin());

            Console.WriteLine("Average: " + gradeBook.GetAverage());
            Console.ReadKey();
        }
    }
}
