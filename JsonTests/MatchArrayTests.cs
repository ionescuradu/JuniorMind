using Xunit;
namespace JsonTests
{
    public class MatchArrayTests
    {

        [Fact]
        public void SuccessMatchArraySuccessProperty()
        {
            var success = new MatchesArray();
            Assert.True(success.Success);
        }

        [Fact]
        public void SuccessMatchArray1LayerOfSuccessMatch()
        {
            var firstSequance = new Sequance(
                new Range('a', 'z'),
                new Range('a', 'z')
                );
            var (match, remaining) = firstSequance.Match("radu");
            var successMatchArray = (MatchesArray)match;
            Assert.True(successMatchArray.Success);

        }

        [Fact]
        public void MatchArrayToString()
        {
            var firstSequance = new Sequance(
                new Character('a'),
                new Character('b'));
            var (match, remaining) = firstSequance.Match("ab");
            Assert.Equal("ab", match.ToString());
        }
    }
}
