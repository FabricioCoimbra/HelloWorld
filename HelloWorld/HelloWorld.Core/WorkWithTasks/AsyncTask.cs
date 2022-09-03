namespace HelloWorld.Core.WorkWithTasks;

public class AsyncTask
{
    public async Task CallTask()
    {
        try
        {
            await Task.Run(() =>
            {
                try
                {
                    new UnhandledError().DivideByZero();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro tratado dentro da Task " + e.Message);
                    throw;
                }
            });
        }
        catch (Exception e)
        {
            Console.WriteLine("Erro tratado fora da Task " + e.Message);
        }
        //not return false task if is real async function.
        //return Task.CompletedTask;
    }
}
