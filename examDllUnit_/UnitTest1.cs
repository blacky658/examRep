using examDll;
namespace examDllUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int expected = 5;
            int actual = Class1.sum(2, 3);
            Assert.Equal(expected, actual);
        }
    }
}