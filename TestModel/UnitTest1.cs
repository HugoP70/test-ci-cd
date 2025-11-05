using Metier;

namespace TestModel
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Test test = new Test();
            Assert.True(test.returnTrue);
        }
    }
}
