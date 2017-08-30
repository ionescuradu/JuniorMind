using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassBookTests
{
    [TestClass]
    public class ClassBookTests
    {
        [TestMethod]
        public void ClassBookFirstTest()
        {
            var andreeaGrades = new Topic[2]
            {
                new Topic("Literature", new int[2] { 10, 10 }),
                new Topic("Latin", new int[2] { 10, 9 })
            };
            var raduGrades = new Topic[2]
            {
              new Topic("Math", new int[2] { 10, 7 }),
              new Topic("Physics", new int[2] { 10, 9 })
            };
            var andreea = new Student("Andreea", andreeaGrades, 0m);
            var radu = new Student("Radu", raduGrades, 0m);
            CollectionAssert.AreEqual(new Student[2] { andreea, radu }, ClassBookOrdering (new Student[] { radu, andreea }));
        }

        [TestMethod]
        public void ClassBookSecondTest()
        {
            var andreeaGrades = new Topic[2]
            {
                new Topic("Literature", new int[2] { 10, 10 }),
                new Topic("Latin", new int[2] { 10, 9 })
            };
            var raduGrades = new Topic[2]
            {
              new Topic("Math", new int[2] { 10, 7 }),
              new Topic("Physics", new int[2] { 10, 9 })
            };
            var antoniaGrades = new Topic[2]
            {
              new Topic("Chemistry", new int[2] { 10, 8 }),
              new Topic("Math", new int[2] { 10, 6 })
            };

            var andreea = new Student("Andreea", andreeaGrades, 0m);
            var radu = new Student("Radu", raduGrades, 0m);
            var antonia = new Student("Antonia", antoniaGrades, 0m);
            CollectionAssert.AreEqual(new Student[3] { andreea, antonia, radu }, ClassBookOrdering(new Student[] { radu, andreea, antonia }));
        }

        [TestMethod]
        public void ClassBookThirdTest()
        {
            var andreeaGrades = new Topic[2]
            {
                new Topic("Literature", new int[2] { 10, 10 }),
                new Topic("Latin", new int[2] { 10, 9 })
            };
            var raduGrades = new Topic[2]
            {
              new Topic("Math", new int[2] { 10, 7 }),
              new Topic("Physics", new int[2] { 10, 9 })
            };
            var andreeaAverage = new Student("Andreea", andreeaGrades, 9.75m);
            var raduAverage = new Student("Radu", raduGrades, 9m);
            var andreea = new Student("Andreea", andreeaGrades, 0m);
            var radu = new Student("Radu", raduGrades, 0m);
            CollectionAssert.AreEqual(new Student[2] { andreeaAverage, raduAverage }, ClassBookOverallAverage(new Student[] { radu, andreea}));
        }

        [TestMethod]
        public void ClassBookFourthTest()
        {
            var andreeaGrades = new Topic[2]
            {
                new Topic("Literature", new int[2] { 10, 10 }),
                new Topic("Latin", new int[2] { 10, 9 })
            };
            var raduGrades = new Topic[2]
            {
              new Topic("Math", new int[2] { 10, 7 }),
              new Topic("Physics", new int[2] { 10, 9 })
            };
            var antoniaGrades = new Topic[2]
            {
              new Topic("Chemistry", new int[2] { 10, 8 }),
              new Topic("Math", new int[2] { 10, 6 })
            };
            var andreeaAverage = new Student("Andreea", andreeaGrades, 9.75m);
            var raduAverage = new Student("Radu", raduGrades, 9m);
            var antoniaAverage = new Student("Antonia", antoniaGrades, 8.5m);
            var andreea = new Student("Andreea", andreeaGrades, 0m);
            var radu = new Student("Radu", raduGrades, 0m);
            var antonia = new Student("Antonia", antoniaGrades, 0m);
            CollectionAssert.AreEqual(new Student[3] { andreeaAverage, raduAverage, antoniaAverage }, ClassBookOverallAverage(new Student[] { radu, andreea, antonia }));
        }

        [TestMethod]
        public void ClassBookFifthTest()
        {
            var andreeaGrades = new Topic[2]
            {
                new Topic("Literature", new int[2] { 10, 10 }),
                new Topic("Latin", new int[2] { 10, 9 })
            };
            var raduGrades = new Topic[2]
            {
              new Topic("Math", new int[2] { 10, 7 }),
              new Topic("Physics", new int[2] { 10, 9 })
            };
            var andreeaAverage = new Student("Andreea", andreeaGrades, 9.75m);
            var raduAverage = new Student("Radu", raduGrades, 9m);
            var andreea = new Student("Andreea", andreeaGrades, 0m);
            var radu = new Student("Radu", raduGrades, 0m);
            CollectionAssert.AreEqual(new Student[1] { andreeaAverage}, ClassBookSpecificAverage(new Student[] { radu, andreea }, 9.75m));
        }

        [TestMethod]
        public void ClassBookSixthTest()
        {
            var andreeaGrades = new Topic[2]
            {
                new Topic("Literature", new int[2] { 10, 10 }),
                new Topic("Latin", new int[2] { 10, 9 })
            };
            var raduGrades = new Topic[2]
            {
              new Topic("Math", new int[2] { 10, 7 }),
              new Topic("Physics", new int[2] { 10, 9 })
            };
            var antoniaGrades = new Topic[2]
            {
              new Topic("Chemistry", new int[2] { 10, 8 }),
              new Topic("Math", new int[2] { 10, 8 })
            };
            var andreeaAverage = new Student("Andreea", andreeaGrades, 9.75m);
            var raduAverage = new Student("Radu", raduGrades, 9m);
            var antoniaAverage = new Student("Antonia", antoniaGrades, 9m);
            var andreea = new Student("Andreea", andreeaGrades, 0m);
            var radu = new Student("Radu", raduGrades, 0m);
            var antonia = new Student("Antonia", antoniaGrades, 0m);
            CollectionAssert.AreEqual(new Student[2] {raduAverage, antoniaAverage }, ClassBookSpecificAverage(new Student[] { radu, andreea, antonia }, 9m));
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

            public Student(string name, Topic[] student, decimal generalAverage)
            {
                this.student = student;
                this.name = name;
                this.generalAverage = generalAverage;
            }
        }

        Student[] ClassBookOrdering(Student[] givenList) // pentru ordonarea alfabetica a elevilor
        {
            //Array.Sort(givenList, (x, y) => string.Compare(x.name, y.name));
            bool nrMoves = false;
            while (nrMoves == false) 
            {
                nrMoves = true;
                for (int i = 1; i < givenList.Length; i++)
                {
                    var firstLetter = 0;
                    while (givenList[i].name[firstLetter] == givenList[i - 1].name[firstLetter])
                    {
                        firstLetter += 1;
                    }
                    if (givenList[i].name[firstLetter] < givenList[i - 1].name[firstLetter])
                    {
                        nrMoves = false;
                        var auxName = givenList[i].name;
                        var auxGrades = givenList[i].student;
                        var auxAverage = givenList[i].generalAverage;
                        givenList[i].name = givenList[i - 1].name;
                        givenList[i].student = givenList[i - 1].student;
                        givenList[i].generalAverage = givenList[i - 1].generalAverage;
                        givenList[i - 1].name = auxName;
                        givenList[i - 1].student = auxGrades;
                        givenList[i - 1].generalAverage = auxAverage;
                    }
                }
            }
            return givenList;
        }

        Student[] ClassBookOverallAverage(Student[] givenList) 
        {
            AverageCalculation(givenList);
            SelectionSorting(givenList);
            return givenList;
        }

        Student[] ClassBookSpecificAverage(Student[] givenList, decimal givenAverage)
        {
            AverageCalculation(givenList);
            var index = 0;
            for (int i = 0; i < givenList.Length; i++)
            {
                if (givenList[i].generalAverage == givenAverage)
                {
                    index += 1;
                }
            }
            var specificStudents = new Student[index];
            var aux = 0;
            for (int i = 0; i < givenList.Length; i++)
            {
                if (givenList[i].generalAverage == givenAverage)
                {
                    specificStudents[aux].name = givenList[i].name;
                    specificStudents[aux].student = givenList[i].student;
                    specificStudents[aux].generalAverage = givenList[i].generalAverage;
                    aux += 1;
                }
            }
            return specificStudents;
        }

        private static void AverageCalculation(Student[] givenList)
        {
            for (int i = 0; i < givenList.Length; i++) 
            {
                var average = 0m;
                var indexAverage = 0;
                for (int j = 0; j < givenList[i].student.Length; j++) 
                {
                    var sum = 0m;
                    var indexSum = 0;
                    for (int k = 0; k < givenList[i].student[j].grades.Length; k++) 
                    {
                        sum += givenList[i].student[j].grades[k];
                        indexSum += 1;
                    }
                    average += sum / indexSum; 
                    indexAverage += 1;
                }
                givenList[i].generalAverage = average / indexAverage; 
            }
        }

        private static void SelectionSorting(Student[] givenList)
        {
            var index = 0;
            var indexFinal = 0;
            var max = givenList[0].generalAverage;
            while (indexFinal != givenList.Length - 1)
            {
                for (int i = indexFinal + 1; i < givenList.Length; i++)
                {
                    if (givenList[i].generalAverage > max)
                    {
                        max = givenList[i].generalAverage;
                        index = i;
                    }
                }
                var aux = givenList[indexFinal].generalAverage; 
                var auxString = givenList[indexFinal].name;
                var auxStudent = givenList[indexFinal].student;
                givenList[indexFinal].generalAverage = givenList[index].generalAverage;
                givenList[indexFinal].name = givenList[index].name;
                givenList[indexFinal].student = givenList[index].student;
                givenList[index].generalAverage = aux;
                givenList[index].name = auxString;
                givenList[index].student = auxStudent;
                indexFinal += 1;
            }
        }
    }
}
