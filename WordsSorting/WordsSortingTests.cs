using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordsSorting
{
    [TestClass]
    public class WordsSortingTests
    {
        [TestMethod]
        public void WordSortingFirst()
        {
            CollectionAssert.AreEqual(new string[4] { "mere", "mere", "Ana", "are" }, sortingSentence("Ana are mere mere"));
        }

        [TestMethod]
        public void WordSortingSecond()
        {
            CollectionAssert.AreEqual(new string[5] { "are", "are", "mere", "mere", "Ana" }, sortingSentence("Ana are mere mere are"));
        }

        public struct wordAppearance
        {
            public string word;
            public int appearance;

            public wordAppearance(string word, int appearance)
            {
                this.word = word;
                this.appearance = appearance;
            }
        }

        string[] sortingSentence(string sentence)
        {
            int index = 0;
            string word = "";
            for (int i = 0; i < sentence.Length; i++) // numara cuvintele
            {
                if (sentence[i].ToString() == " " || i == sentence.Length - 1)
                {
                    index += 1;
                }
            }
            string[] newSentence = new string[index];
            index = 0;
            for (int i = 0; i < sentence.Length; i++) // introduce cuvintele intr-un string in ordinea din text
            {
                if (sentence[i].ToString() != " ")
                {
                    word += sentence[i];
                    if ( i == sentence.Length - 1)
                    {
                        newSentence[index] = word;
                        word = "";
                    }
                }
                else
                {
                    newSentence[index] = word;
                    index += 1;
                    word = "";
                }

            }
            var wordsAppearance = new wordAppearance[newSentence.Length];
            index = 0;
            for (int i = 0; i < newSentence.Length; i++) // introduce toate cuvintele fara dubluri in struct
            {
                if (newSentence[i] != "")
                {
                    wordsAppearance[index].word = newSentence[i];
                    wordsAppearance[index].appearance = 1;
                    for (int j = i + 1; j < newSentence.Length; j++)
                    {
                        if (newSentence[j] == newSentence[i])
                        {
                            wordsAppearance[index].appearance += 1;
                            newSentence[j] = "";
                        }
                    }
                    index += 1;
                }
            }
            var max = 0;
            var wordAux = wordsAppearance[0].word;
            var countAux = wordsAppearance[0].appearance;
            for (int i = 0; i < wordsAppearance.Length - 1; i++) // ordoneaza struct-ul dupa numarul de aparitii
            {
                for (int j = i + 1; j < wordsAppearance.Length; j++)
                {
                    if (max < wordsAppearance[j].appearance)
                    {
                        max = wordsAppearance[j].appearance;
                        index = j;
                    }
                }
                wordAux = wordsAppearance[i].word;
                wordsAppearance[i].word = wordsAppearance[index].word;
                wordsAppearance[index].word = wordAux;
                countAux = wordsAppearance[i].appearance;
                wordsAppearance[i].appearance = wordsAppearance[index].appearance;
                wordsAppearance[index].appearance = countAux;
                max = 0;
            }
            index = 0;
            for (int i = 0; i < wordsAppearance.Length; i++)// ordoneaza cuvintele dupa numarul de aparitii
            {
                for (int j = 0; j < wordsAppearance[i].appearance; j++)
                {
                    newSentence[index] = wordsAppearance[i].word;
                    index += 1;
                }
            }
            return newSentence;
        }
    }
}
