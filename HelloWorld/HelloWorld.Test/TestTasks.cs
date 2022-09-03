using HelloWorld.Core.WorkWithTasks;

namespace HelloWorld.Test
{
    public class TestTasks
    {
        [Fact]
        public void TestDivideByZero()
        {
            //arrange
            var handler = new UnhandledError();

            //act
            Assert.Throws<Exception>(() => handler.DivideByZero());
            //assert
        }
    }
}