using JsonTests;

namespace TcpHtmlVerify
{
    public class FieldsParsing : Pattern
    {
        private readonly Pattern pattern;

        public FieldsParsing()
        {
            var anyChar = new Many(
                new Choice(
                    new Range('!', '9'),
                    new Range(';', '~')));
            var elementList = new Sequance(
                    new Many(new Character(' ')),
                        anyChar,
                        new Many(new Character(' ')),
                        new Character(':'),
                        new Many(new Character(' ')),
                        anyChar,
                        new Many(new Character(' ')));
            pattern = new List(elementList, new Text("\n"));
        }
        public (Match, string) Match(string input)
        {
            var (match, remaining) = pattern.Match(input);
            if (match.Success)
            {
                return (new FieldsMatch(match.ToString()), remaining);
            }
            return (match, remaining);
        }
    }
}
