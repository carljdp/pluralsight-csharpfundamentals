using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        private List<float> grades;

        public GradeBook()
        {
            grades = new List<float>();
        }
        
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public float GetAverage()
        {
            return grades.Average();
        }

        public float GetMax()
        {
            return grades.Max();
        }

        public float GetMin()
        {
            return grades.Min();
        }
    }
}
