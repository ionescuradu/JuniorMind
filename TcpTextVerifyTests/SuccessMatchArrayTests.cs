using Xunit;
namespace TcpHtmlVerify
{
    public class SuccessMatchArrayTests
    {

        [Fact]
        public void SuccessMatchArray2Sequance()
        {
            var aux = new SuccessMatchArray();
            Assert.True(aux.Success);
        }
    }
}
