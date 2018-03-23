using Xunit;
namespace JsonTests
{
    public class SuccessMatchArrayTests
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
    }
}
