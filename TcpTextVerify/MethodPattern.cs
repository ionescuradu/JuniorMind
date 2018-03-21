using System;
using JsonTests;
using TcpTextVerifyTests;

namespace TcpHtmlVerify
{
    public class MethodPattern : Pattern
    {
        private readonly Pattern pattern;

        public MethodPattern()
        {
            pattern = new Choice(
                new Text("GET"),
                new Text("POST"),
                new Text("PUT"),
                new Text("DELETE"));
        }

        public (Match, string) Match(string input)
        {
            var (match, remaining) = pattern.Match(input);
            if (match.Success)
            {
                var successMatch = (SuccessMatch)match;
                return (ToMethod(successMatch.MachedText), remaining);
            }
            return (match, remaining);
        }

        private static MethodMatch ToMethod(string successMatchText)
        {
            var method = (Method)Enum.Parse(typeof(Method), successMatchText);
            return new MethodMatch(method);
        }
    }
}
