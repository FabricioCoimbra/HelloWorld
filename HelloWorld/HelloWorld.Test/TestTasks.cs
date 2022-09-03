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
            var action = () => handler.DivideByZero();

            //assert
            Assert.Throws<DivideByZeroException>(action);
        }
    }
}