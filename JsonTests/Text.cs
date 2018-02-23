using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class Text : Pattern
    {
        private Character[] chars;
        private string givenText;

        public Text(string givenText)
        {
            this.givenText = givenText;
            chars = new Character[givenText.Length];
            for (int i = 0; i < givenText.Length; i++)
            {
                chars[i] = new Character(givenText[i]);
            }
        }

        public (Match, string) Match(string input)
        {
            return new Sequance(chars).Match(input);
        }
    }
}
