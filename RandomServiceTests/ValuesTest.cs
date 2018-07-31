using Xunit;

namespace RandomServiceTests
{
    public class ValuesTest
    {
        [Fact]
        public void Test1()
        {
        //Given
            var result = 5;
        //When

        //Then
            Assert.Equal(5, result);
        }
    }
}