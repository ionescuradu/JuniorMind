using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassBook_OOP_
{
    [TestClass]
    public class ClassBookOOP

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
                var andreea = new Student("Andreea", andreeaGrades);
                var radu = new Student("Radu", raduGrades);
                ClassBook classBook = new ClassBook (new Student[2] { radu, andreea });
                CollectionAssert.AreEqual(new Student[2] { andreea, radu }, classBook.OrderingByName());
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
                var andreea = new Student("Andreea", andreeaGrades);
                var radu = new Student("Radu", raduGrades);
                var antonia = new Student("Antonia", antoniaGrades);
                ClassBook classBook = new ClassBook(new Student[3] { radu, andreea, antonia });
                CollectionAssert.AreEqual(new Student[3] { andreea, antonia, radu }, classBook.OrderingByName());
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
                var andreea = new Student("Andreea", andreeaGrades);
                var radu = new Student("Radu", raduGrades);
                ClassBook classBook = new ClassBook(new Student[2] { radu, andreea });
                CollectionAssert.AreEqual(new Student[2] { andreea, radu }, classBook.OverallAverage());
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
                var andreea = new Student("Andreea", andreeaGrades);
                var radu = new Student("Radu", raduGrades);
                var antonia = new Student("Antonia", antoniaGrades);
                ClassBook classBook = new ClassBook(new Student[3] { radu, andreea, antonia });
                CollectionAssert.AreEqual(new Student[3] { andreea, radu, antonia }, classBook.OverallAverage());
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
                var andreea = new Student("Andreea", andreeaGrades);
                var radu = new Student("Radu", raduGrades);
                ClassBook classBook = new ClassBook(new Student[2] { radu, andreea });
                CollectionAssert.AreEqual(new Student[1] { andreea }, classBook.SpecificAverage(9.75m));
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
                var andreea = new Student("Andreea", andreeaGrades);
                var radu = new Student("Radu", raduGrades);
                var antonia = new Student("Antonia", antoniaGrades);
                ClassBook classBook = new ClassBook(new Student[3] { radu, andreea, antonia });
                CollectionAssert.AreEqual(new Student[2] { radu, antonia }, classBook.SpecificAverage(9m));
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
                var andreea = new Student("Andreea", andreeaGrades);
                var radu = new Student("Radu", raduGrades);
                ClassBook classBook = new ClassBook(new Student[2] { radu, andreea });
                CollectionAssert.AreEqual(new Student[1] { andreea }, classBook.BestStudents());
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
                var andreea = new Student("Andreea", andreeaGrades);
                var radu = new Student("Radu", raduGrades);
                var antonia = new Student("Antonia", antoniaGrades);
                ClassBook classBook = new ClassBook(new Student[3] { radu, andreea, antonia });
                CollectionAssert.AreEqual(new Student[2] { andreea, antonia }, classBook.BestStudents());
            }

            [TestMethod]
            public void ClassBookNinthTest()
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
                var andreea = new Student("Andreea", andreeaGrades);
                var radu = new Student("Radu", raduGrades);
                ClassBook classBook = new ClassBook(new Student[2] { radu, andreea });
                CollectionAssert.AreEqual(new Student[1] { radu }, classBook.WeakestStudents());
            }

            [TestMethod]
            public void ClassBookTenthTest()
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
              new Topic("Chemistry", new int[2] { 10, 9 }),
              new Topic("Math", new int[2] { 10, 7 })
                };
                var andreea = new Student("Andreea", andreeaGrades);
                var radu = new Student("Radu", raduGrades);
                var antonia = new Student("Antonia", antoniaGrades);
                ClassBook classBook = new ClassBook(new Student[3] { radu, andreea, antonia });
                CollectionAssert.AreEqual(new Student[2] { radu, antonia }, classBook.WeakestStudents());
            }
        }
    }

}

