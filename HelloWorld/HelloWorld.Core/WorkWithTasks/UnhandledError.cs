namespace HelloWorld.Core.WorkWithTasks;

public class UnhandledError
{
    public int Id { get; set; } = 0;
    public void DivideByZero()
    {
        var i = 2 / Id;
    }
}
