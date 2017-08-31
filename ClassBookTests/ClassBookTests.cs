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
            public string subject;
            public int[] grades;

            public Topic(string subject, int[] grades)
            {
                this.subject = subject;
                this.grades = grades;
            }
        }

        public struct Student     // Struct pentru array de materii si note pentru fiecare student 
        {
            public Topic[] pupil;
            public string name;
            public decimal generalAverage;

            public Student(string name, Topic[] pupil, decimal generalAverage)
            {
                this.pupil = pupil;
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
                        var aux = givenList[i];
                        givenList[i] = givenList[i - 1];
                        givenList[i - 1] = aux;
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
                    specificStudents[aux] = givenList[i];
                    aux += 1;
                }
            }
            return specificStudents;
        }

        Student[] ClassBookBestStudets(Student[] givenList)
        {
            var sumOfTen= 0;
            for (int i = 0; i < givenList[0].pupil.Length; i++)
            {
                for (int j = 0; j < givenList[0].pupil[i].grades.Length; j++)
                {
                    if (givenList[0].pupil[i].grades[j] == 10)
                    {
                        sumOfTen += 10;
                    }
                }
            }
            for (int i = 0; i < givenList.Length; i++)
            {
                for (int j = 0; j < givenList[i].pupil.Length; j++)
                {
                    for (int k = 0; k < givenList[i].pupil[j].grades.Length; k++)
                    {
                        if (givenList[i].pupil[j].grades[k] == 10)
                        {
                            sumOfTen += 10;
                        }
                    }
                }
            }
            return givenList;
        }

        private static void AverageCalculation(Student[] givenList)
        {
            for (int i = 0; i < givenList.Length; i++) 
            {
                var average = 0m;
                var indexAverage = 0;
                for (int j = 0; j < givenList[i].pupil.Length; j++) 
                {
                    var sum = 0m;
                    var indexSum = 0;
                    for (int k = 0; k < givenList[i].pupil[j].grades.Length; k++) 
                    {
                        sum += givenList[i].pupil[j].grades[k];
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
                var aux = givenList[indexFinal]; 
                givenList[indexFinal] = givenList[index];
                givenList[index] = aux;
                indexFinal += 1;
            }
        }
    }
}
