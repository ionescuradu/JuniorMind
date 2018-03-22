using System;
using JsonTests;

namespace TcpHtmlVerify
{
    public class UriParsing : Pattern
    {
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
            if (match.Success)
            {
                var successMatch = (SuccessMatch)match;
                if (Uri.IsWellFormedUriString(successMatch.MachedText, UriKind.RelativeOrAbsolute))
                {
                    return (match, remaining);
                }
            }
            return (match, remaining);
            
        }
    }
}
