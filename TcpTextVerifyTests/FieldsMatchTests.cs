using System.Collections.Generic;
using Xunit;

namespace TcpHtmlVerify
{
    public class FieldsMatchTests
    {
        [Fact]
        public void KeyValuePairTest1()
        {
            var keyValueMatch = new FieldsMatch(
                "Server: nginx/1.13.9\r\nContent-Lenght: 112\r\n\r\n");
            Assert.True(keyValueMatch.Success);
        }

    }
}
