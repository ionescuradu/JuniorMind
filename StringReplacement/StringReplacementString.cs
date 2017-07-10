using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringReplacement
{
    [TestClass]
    public class StringReplacementString
    {
        [TestMethod]
        public void StringReplacementFirstTest()
        {
            Assert.AreEqual("RIONESCUDU", ConcatenateTwoStrings("RADU", "IONESCU", 1));
        }

        string ConcatenateTwoStrings(string first, string second, int insertionPoint)
        {
            string result = "";
            var bufferString = first;
            for (int i = 0; i < insertionPoint; i++)
            {
                result += first[i];
            }
            int counter = - 1;
            Concatenate(ref result, second, counter);
            result += first.Substring(insertionPoint + 1, first.Length - insertionPoint - 1);
            return result;
        }

        private string Concatenate( ref string result, string second, int counter)
        {
            if (counter < second.Length - 1)
            {
                counter += 1;
                result += second[counter];
                return Concatenate(ref result, second, counter);
            }
            else return result;
        }
    }
}
