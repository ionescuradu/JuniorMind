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

        [TestMethod]
        public void ClassBookSeventhTest()
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
            CollectionAssert.AreEqual(new Student[1] { andreea }, ClassBookBestStudets(new Student[] { radu, andreea }));
        }

        [TestMethod]
        public void ClassBookEighthTest()
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
              new Topic("Chemistry", new int[2] { 10, 10 }),
              new Topic("Math", new int[2] { 10, 8 })
            };
            var andreeaAverage = new Student("Andreea", andreeaGrades, 9.75m);
            var raduAverage = new Student("Radu", raduGrades, 9m);
            var antoniaAverage = new Student("Antonia", antoniaGrades, 9m);
            var andreea = new Student("Andreea", andreeaGrades, 0m);
            var radu = new Student("Radu", raduGrades, 0m);
            var antonia = new Student("Antonia", antoniaGrades, 0m);
            CollectionAssert.AreEqual(new Student[2] { andreea, antonia }, ClassBookBestStudets(new Student[] { radu, andreea, antonia }));
        }



        public struct Topic       
        {
            public string subject;
            public int[] grades;

            public Topic(string subject, int[] grades)
            {
                this.subject = subject;
                this.grades = grades;
            }
            
            public int CountGradesOf10()
            {
                var count = 0;
                for (int i = 0; i < grades.Length; i++)
                {
                    if (grades[i] == 10)
                    {
                        count += 1;
                    }
                }
                return count;
            }

            public decimal SubjectAverage()
            {
                var average = 0m;
                var index = 0;
                for (int i = 0; i < grades.Length; i++)
                {
                    average += grades[i];
                    index += 1;
                }
                return average / index;
            }
        }

        public struct Student     
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
                var index = 0;
                for (int i = 0; i < pupil.Length; i++)
                {
                    average += pupil[i].SubjectAverage();
                    index += 1;
                }
                return average / index;
            }
        }

        Student[] ClassBookOrdering(Student[] givenList) // pentru ordonarea alfabetica a elevilor
        {
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
            var max = givenList[0].CountGradesOf10PerStudent();
            for (int i = 0; i < givenList.Length; i++)
            {
                if (max < givenList[i].CountGradesOf10PerStudent())
                {
                    max = givenList[i].CountGradesOf10PerStudent();
                }
            }
            var index = 0;
            for (int i = 0; i < givenList.Length; i++)
            {
                if (max == givenList[i].CountGradesOf10PerStudent())
                {
                    index += 1;
                }
            }
            var bestStudents = new Student[index];
            var aux = 0;
            for (int i = 0; i < givenList.Length; i++)
            {
                if (max == givenList[i].CountGradesOf10PerStudent())
                {
                    bestStudents[aux] = givenList[i];
                    aux += 1;
                }
            }
            return bestStudents;
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
