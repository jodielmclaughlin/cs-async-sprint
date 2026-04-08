using System.Linq.Expressions;

namespace cs__async_sprint
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //await DelayPrint();
            //static async Task DelayPrint()
            //{
            //    await Task.Delay(2000);
            //    Console.WriteLine("Hello, World!");
            //}

            Task<string> task1 = Task.Run(async () =>
            {
                await Task.Delay(3000);
                //Console.WriteLine("Hello...");
                return "Hello...";
            });

            Task<string> task2 = Task.Run(async () =>
            {
                await Task.Delay(3000);
                //Console.WriteLine("...World!");
                return "...World!";
            });

            //await Task.WhenAll(task1, task2);
            var combinedTask = await Task.WhenAll(task2, task1);
            Console.WriteLine(combinedTask[0]+ combinedTask[1]);
            

        }
    }
}
