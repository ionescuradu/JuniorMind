using TcpHtmlVerify;
using Xunit;
namespace TcpTextVerifyTests
{
    public class MethodPatternTests
    {
        [Fact]
        public void MatchesAGETMethod()
        {
            var pattern = new MethodPattern();
            var (match, remaining) = pattern.Match("GET");
            Assert.True(match.Success);
        }

        [Fact]
        public void TheMatchIsOfTypeMethodMatch()
        {
            var pattern = new MethodPattern();
            var (match, remaining) = pattern.Match("GET");
            Assert.IsType<MethodMatch>(match);
        }

        [Theory]
        [InlineData(Method.GET, "GET")]
        [InlineData(Method.DELETE, "DELETE")]
        [InlineData(Method.POST, "POST")]
        [InlineData(Method.PUT, "PUT")]
        public void TheMatchHasTheParsedMethod(
            Method expectedMethod, 
            string textToMatch)
        {
            var pattern = new MethodPattern();
            var (match, remaining) = pattern.Match(textToMatch);
            var methodMatch = (MethodMatch) match;
            Assert.Equal(expectedMethod, methodMatch.Method);
        }

        [Fact]
        public void DoesNOTMatchAnInvalidMethod()
        {
            var pattern = new MethodPattern();
            var (match, remaining) = pattern.Match("GEX");
            Assert.False(match.Success);
        }

        [Fact]
        public void TheRemainingTextIsSetProperly()
        {
            var pattern = new MethodPattern();
            var (match, remaining) = pattern.Match("GET abc");
            Assert.Equal(" abc", remaining);
        }
    }
}
