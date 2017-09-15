using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBook_OOP_
{
        public struct Topic
        {
            private string subject;
            private int[] grades;

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
    }
