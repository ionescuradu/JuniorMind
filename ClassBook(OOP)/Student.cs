using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBook_OOP_
{ 
    public struct Student
    {
        private Topic[] pupil;
        private string name;

        public Student(string name, Topic[] pupil)
        {
            this.pupil = pupil;
            this.name = name;
        }

        public int CountGradesOf10PerStudent()
        {
            var count = 0;
            for (int i = 0; i < pupil.Length; i++)
            {
                count += pupil[i].CountGradesOf10();
            }
            return count;
        }

        public decimal TotalSubjectAverage()
        {
            var average = 0m;
            for (int i = 0; i < pupil.Length; i++)
            {
                average += pupil[i].SubjectAverage();
            }
            return average / pupil.Length;
        }

        public int OrderingByName(Student other)
        {
            return string.Compare(name, other.name);
        }

        public int SelectionSorting(Student other)
        {
            if (TotalSubjectAverage() == other.TotalSubjectAverage())
            {
                return 0;
            }
            else
            {
                return TotalSubjectAverage() < other.TotalSubjectAverage() ? -1 : 1; 
            }
        }

    }
}
