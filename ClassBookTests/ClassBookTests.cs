using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassBookTests
{
    [TestClass]
    public class ClassBookTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }


        public struct Topic       // Struct pentru numele materiilor si notele pentru fiecare(materie)
        {
            public string subjects;
            public int[] grades;

            public Topic(string subjects, int[] grades)
            {
                this.subjects = subjects;
                this.grades = grades;
            }
        }

        public struct Student     // Struct pentru array de materii si note pentru fiecare student 
        {
            public Topic[] student;
            public string name;
            public decimal generalAverage;

            public Student(Topic[] student, string name, decimal generalAverage)
            {
                this.student = student;
                this.name = name;
                this.generalAverage = generalAverage;
            }
        }

        Student[] ClassBookOrdering(Student[] givenList) // pentru ordonarea alfabetica a elevilor
        {
            Array.Sort(givenList);
            return givenList;
        }

        Student[] ClassBookOverallAverage(Student[] givenList) // pentru calcularea mediei generale
        {
            var classBookSubjectAverage = new Student[givenList.Length];
            for (int i = 0; i < givenList.Length; i++) // se parcurge lista cu numele studentilor
            {
                var average = 0;
                var indexAverage = 0;
                for (int j = 0; j < givenList[i].student.Length; j++) // se parcurge lista cu materiile pentru fiecare student
                {
                    var sum = 0;
                    var indexSum = 0;
                    for (int k = 0; k < givenList[i].student[j].grades.Length; k++) // se parcurge lista cu notele pentru fiecare materie
                    {
                        sum += givenList[i].student[j].grades[k];
                        indexSum += 1;
                    }
                    average += sum / indexSum; // se adauga media pentru fiecare materie pe prima pozitie in array-ul de note
                    indexAverage += 1;
                }
                givenList[i].generalAverage = average / indexAverage; // calculul mediei generale pentru fiecare student
            }
            SelectionSorting(givenList);
            return givenList;
        }

        private static void SelectionSorting(Student[] givenList)
        {
            var index = 0;
            var indexFinal = 0;
            var max = givenList[0].generalAverage;
            var aux = 0m;
            var auxString = "";
            var auxStudent = givenList[0].student;
            while (index != givenList.Length)
            {
                for (int i = 1; i < givenList.Length; i++)
                {
                    if (givenList[i].generalAverage > max)
                    {
                        max = givenList[i].generalAverage;
                        index = i;
                    }
                }
                aux = givenList[indexFinal].generalAverage; //Extract method !!!!
                auxString = givenList[indexFinal].name;
                auxStudent = givenList[indexFinal].student;
                givenList[indexFinal].generalAverage = givenList[index].generalAverage;
                givenList[indexFinal].name = givenList[index].name;
                givenList[indexFinal].student = givenList[index].student;
                givenList[index].generalAverage = aux;
                givenList[index].name = auxString;
                givenList[index].student = auxStudent;
                indexFinal += 1;
            }
        }

        //string ClassBookOverallStudents(Student[] givenList)
        //{
        //    var averageList = ClassBookOverallAverage(Student[] givenList);
        //}
    }
}
