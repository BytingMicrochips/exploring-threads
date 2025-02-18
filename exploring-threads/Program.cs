namespace exploringThreads
{
    public class Program
    {
        static void Main()
        {
            Task backgroundTask = new Task(() =>
            {
                Console.WriteLine("Background task is starting");
                bool result = SomethingAsync();
                Console.WriteLine($"Background task has completed: {result}");
            });

            Console.WriteLine("Main thread is running");
            backgroundTask.Start();
            Thread.Sleep(2000);
            Console.WriteLine("Main thread is completed");
            backgroundTask.Wait();
        }

        static bool SomethingAsync()
        {
            Thread.Sleep(3000);
            return true;
        }
    }
}

// wait all
// timer
// kill itself after timer