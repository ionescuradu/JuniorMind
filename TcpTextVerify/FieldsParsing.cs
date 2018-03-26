using JsonTests;

namespace TcpHtmlVerify
{
    public class FieldsParsing : Pattern
    {
        private readonly Pattern fields;

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
            fields = new List(elementList, new Text("\n"));
        }
        public (Match, string) Match(string input)
        {
            var (match, remaining) = new Optional(new Text("\n")).Match(input);
            if (match.Success)
            {
                (match, remaining) = fields.Match(remaining);
                if (match.Success)
                {
                    return (new FieldsMatch(match.ToString()), remaining);
                }
            }
            return (match, remaining);
        }
    }
}
