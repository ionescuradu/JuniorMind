using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBook_OOP_
{
    public struct ClassBook
    {
        private Student[] classBook;
        public ClassBook(Student[] classBook)
        {
            this.classBook = classBook;
        }

        public Student[] OrderingByName()
        {
            bool nrMoves = false;
            while (nrMoves == false)
            {
                nrMoves = true;
                for (int i = 1; i < classBook.Length; i++)
                {
                    if (classBook[i].OrderingByName(classBook[i - 1]) == -1)
                    {
                        nrMoves = false;
                        var aux = classBook[i];
                        classBook[i] = classBook[i - 1];
                        classBook[i - 1] = aux;
                    }
                }
            }
            return classBook;

        }

        public Student[] OverallAverage()
        {
            var index = 0;
            var indexFinal = 0;
            var max = classBook[0].TotalSubjectAverage();
            while (indexFinal != classBook.Length - 1)
            {
                for (int i = indexFinal + 1; i < classBook.Length; i++)
                {
                    if (classBook[i].SelectionSorting(classBook[0]) == 1)
                    {
                        max = classBook[i].TotalSubjectAverage();
                        index = i;
                    }
                }
                var aux = classBook[indexFinal];
                classBook[indexFinal] = classBook[index];
                classBook[index] = aux;
                indexFinal += 1;
            }
            return classBook;
        }

        public Student[] SpecificAverage(decimal givenAverage)
        {
            var index = 0;
            for (int i = 0; i < classBook.Length; i++)
            {
                if (classBook[i].TotalSubjectAverage() == givenAverage)
                {
                    index += 1;
                }
            }
            var specificStudents = new Student[index];
            var aux = 0;
            for (int i = 0; i < classBook.Length; i++)
            {
                if (classBook[i].TotalSubjectAverage() == givenAverage)
                {
                    specificStudents[aux] = classBook[i];
                    aux += 1;
                }
            }
            return specificStudents;
        }

        public Student[] BestStudents()
        {
            var max = classBook[0].CountGradesOf10PerStudent();
            for (int i = 0; i < classBook.Length; i++)
            {
                if (max < classBook[i].CountGradesOf10PerStudent())
                {
                    max = classBook[i].CountGradesOf10PerStudent();
                }
            }
            var index = 0;
            for (int i = 0; i < classBook.Length; i++)
            {
                if (max == classBook[i].CountGradesOf10PerStudent())
                {
                    index += 1;
                }
            }
            var bestStudents = new Student[index];
            index = 0;
            for (int i = 0; i < classBook.Length; i++)
            {
                if (max == classBook[i].CountGradesOf10PerStudent())
                {
                    bestStudents[index] = classBook[i];
                    index += 1;
                }
            }
            return bestStudents;
        }

        public Student[] WeakestStudents()
        {
            var min = classBook[0].TotalSubjectAverage();
            for (int i = 1; i < classBook.Length; i++)
            {
                if (min > classBook[i].TotalSubjectAverage())
                {
                    min = classBook[i].TotalSubjectAverage();
                }
            }
            var index = 0;
            for (int i = 0; i < classBook.Length; i++)
            {
                if (min == classBook[i].TotalSubjectAverage())
                {
                    index += 1;
                }
            }
            var weakestStudents = new Student[index];
            index = 0;
            for (int i = 0; i < classBook.Length; i++)
            {
                if (min == classBook[i].TotalSubjectAverage())
                {
                    weakestStudents[index] = classBook[i];
                    index += 1;
                }
            }
            return weakestStudents;
        }
    }

}
