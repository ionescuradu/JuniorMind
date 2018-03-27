using System.Collections.Generic;
using JsonTests;
using Xunit;
namespace TcpHtmlVerify
{
    public class RequestTests
    {

        [Fact]
        public void IsASuccessMatch()
        {
            var request = new Request(new List<Match>());
            Assert.True(request.Success);
        }
    }
}
