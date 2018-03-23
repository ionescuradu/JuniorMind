namespace JsonTests
{
    public class Sequance :Pattern
    {
        readonly Pattern[] pattern;
        readonly MatchesArray successArray = new MatchesArray();

        public Sequance( params Pattern[] pattern)
        {
            this.pattern = pattern;
        }

        public (Match, string) Match(string input)
        {
            var aux = input;
            if (input == "")
            {
                return (new NoText(input), input);
            }   
            for (int i = 0; i < pattern.Length; i++)
            {
                var (match, remaining) = pattern[i].Match(aux);
                if (!match.Success)
                {
                    return (new NoMatch(aux, input.Length - remaining.Length, match as NoMatch), input);
                }
                successArray.Add(match);
                aux = remaining;
            }
            return (successArray, aux);
        }
    }
}
