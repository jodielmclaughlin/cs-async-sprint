using System.Linq.Expressions;
using System.Diagnostics;

namespace cs__async_sprint
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            
            Random rnd = new Random();
            CancellationTokenSource source = new CancellationTokenSource();
            CancellationToken token = source.Token;
            
            //Stopwatch stopwatch = Stopwatch.StartNew();

            Task<string> task1 = Task.Run(async () =>
            {
                //stopwatch.Start();
                await Task.Delay(rnd.Next(1000, 10000),token);
                return "Hello...";
            });

            Task<string> task2 = Task.Run(async () =>
            {
                await Task.Delay(rnd.Next(1000, 10000),token);
                return "...World!";
                //stopwatch.Stop();
            });


            try
            {
                source.CancelAfter(5000);
                var combinedTask = await Task.WhenAll(task1, task2);
                Console.WriteLine(combinedTask[0] + combinedTask[1]);
                
            }
            catch (OperationCanceledException ex) 
            {
                Console.WriteLine($"{ex.Message}");
            }
            
            
                
               

        }
    }
}
