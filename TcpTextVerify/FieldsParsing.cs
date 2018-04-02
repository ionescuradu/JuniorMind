using JsonTests;

namespace TcpHtmlVerify
{
    public class FieldsParsing : Pattern
    {
        private readonly Pattern fields;

        public FieldsParsing()
        {
            var fieldName = new Many(new Choice(
                new Range('!', '9'),
                new Range(';', '~')));
            var fieldValue = new Many(
                new Range(' ', '~'));
            var elementList = new Sequance(
                    new Many(new Character(' ')),
                    fieldName,
                    new Many(new Character(' ')),
                    new Character(':'),
                    new Many(new Character(' ')),
                    fieldValue);
            fields = new List(elementList, new Text("\r\n"));
        }
        public (Match, string) Match(string input)
        {
            var (match, remaining) = fields.Match(input);
            if (match.Success)
            {
                return (new FieldsMatch(match.ToString()), remaining);
            }
            return (match, remaining);
        }
    }
}
