using System;
using JsonTests;

namespace TcpHtmlVerify
{
    public class UriParsing : Pattern
    {
        //private readonly string uriText;
        private readonly Pattern pattern;

        public UriParsing()
        {
            pattern = new Many(
                new Choice(
                    new Range('!', '9'),
                    new Range(';', '~')));
        }

        public (Match, string) Match(string input)
        {
            var (match, remaining) = pattern.Match(input);
            if (Uri.TryCreate(input, UriKind.Absolute, out Uri outUri))
            {
                return (match, remaining);
            }
            return (match, input);
            
        }
    }
}
