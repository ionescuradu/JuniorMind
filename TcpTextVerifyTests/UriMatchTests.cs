using Xunit;


namespace TcpHtmlVerify
{
    public class UriMatchTests
    {
        [Fact]
        public void IsNotSuccessMatch()
        {
            var uriMatch = new UriMatch(" /messages/D5B6JPDK2/");
            Assert.False(uriMatch.Success);
        }

        [Fact]
        public void HasHttpUriProperty()
        {
            var uriMatch = new UriMatch("/messages/D5B6JPDK2/");
            Assert.Equal("/messages/D5B6JPDK2/", uriMatch.IsUri());
        }

    }
}
