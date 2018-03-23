using System.Collections.Generic;
using System.Linq;
using JsonTests;

namespace TcpHtmlVerify
{
    public class FieldsMatch: Match
    {
        private readonly Dictionary<string, string> dictionary;

        public FieldsMatch(string input)
        {
            var x = input.Split(":".ToCharArray());
            dictionary = input
                .Split("\n".ToCharArray())
                .Where(s => !string.IsNullOrEmpty(s.Trim()))
                .Select(s => s.Split(":".ToCharArray()))
                .ToDictionary(s => s[0].Trim(), s => s[1].Trim());
        }

        public Dictionary<string, string> Dictionary => dictionary;

        public bool Success => true;
    }
}
