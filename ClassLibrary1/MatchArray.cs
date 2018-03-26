using System.Collections;
using System.Collections.Generic;
using System.Text;
using JsonTests;

namespace JsonTests
{
    public class MatchesArray : Match, IEnumerable<Match>
    {
        private List<Match> successMatches;


        public MatchesArray()
        {
            successMatches = new List<Match>();
        }

        public void Add(Match successMatch)
        {
            successMatches.Add(successMatch);
        }

        public IEnumerator<Match> GetEnumerator()
        {
            foreach (var item in successMatches)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Success => true;

        public override string ToString()
        {
            var text = new StringBuilder();
            foreach (var item in successMatches)
            {
                text.Append(item);
            }
            return text.ToString();
        }
    }
}
