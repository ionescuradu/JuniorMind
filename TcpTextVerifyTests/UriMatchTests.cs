using System;
using Xunit;


namespace TcpHtmlVerify
{
    public class UriMatchTests
    {
        [Fact]
        public void IsSuccessMatch()
        {
            var uriMatch = new UriMatch("/messages/D5B6JPDK2/");
            Assert.True(uriMatch.Success);
        }

        [Fact]
        public void HasHttpUriProperty()
        {
            var uriMatch = new UriMatch("messages/D5B6JPDK2/");
            Assert.Equal("messages/D5B6JPDK2/", uriMatch.Uri.ToString());
        }

    }
}
