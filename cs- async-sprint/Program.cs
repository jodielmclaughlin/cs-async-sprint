using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq.Expressions;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace cs__async_sprint
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            AsyncFileManager manager = new AsyncFileManager();
            var print = manager.ReadFile("SuperSecretFile.txt");
            var file1 = manager.ReadFile("ReallySuperSecretTextFile.txt");
            var file2 = manager.ReadFile("SuperTopSecretTextFile.txt");
            var allContent = await Task.WhenAll(print, file1, file2);
            string newmessage = "";
            //Needs to be refactored to methods
            foreach (var content in allContent)
            {
                for (int i = 0; i < content.Length; i++)
                {
                    if (content[i] == ' ')
                    {
                        newmessage += content[i];
                    }
                    if (content[i] >= 'a' && content[i] <= 'z')
                    {
                        char something = content[i] == 'z' ? 'a' : (char)(content[i] + 1);
                        newmessage = newmessage + something;
                    }
                    if (content[i] >= 'A' && content[i] <= 'Z')
                    {
                        char something = content[i] == 'Z' ? 'A' : (char)(content[i] + 1);
                        newmessage = newmessage + something;
                    }
                }
            }

            manager.WriteFile("DecryptedMessage.txt", newmessage);


            //string data = "85671 34262 92143 50984 24515 68356 77247 12348 56789 98760";
            //List<BigInteger> stringToBigInteger = data.Split(' ').Select(x => BigInteger.Parse(x)).ToList();

            //List<Task<BigInteger>> tasks = stringToBigInteger.Select(biginteger => Task.Run(() => Exercises.CalculateFactorial(biginteger))).ToList();
            //var results = await Task.WhenAll(tasks);
            //foreach (var result in results)
            //{
            //    Console.WriteLine(result);
            //}

            //Approach with ContinueWith included:
            //var tasks = data.Split(' ')
            //    .Select(x => BigInteger.Parse(x))
            //    .Select(biginteger => Task.Run(() => Exercises.CalculateFactorial(biginteger)))
            //    .Select(task => task.ContinueWith(t => Console.WriteLine(t.Result))).ToList();
            //var task1 = Task.WhenAll(tasks);



            //Exercises exercises = new Exercises();
            //var task2 = exercises.PrintStoryByWord();

            //await Task.WhenAll(task1,task2);

            //Task 3 - Combining Asynchronous Results
            //Random rnd = new Random();
            //CancellationTokenSource source = new CancellationTokenSource();
            //CancellationToken token = source.Token;

            ////Stopwatch stopwatch = Stopwatch.StartNew();

            //Task<string> task1 = Task.Run(async () =>
            //{
            //    //stopwatch.Start();
            //    await Task.Delay(rnd.Next(1000, 10000),token);
            //    return "Hello...";
            //});

            //Task<string> task2 = Task.Run(async () =>
            //{
            //    await Task.Delay(rnd.Next(1000, 10000),token);
            //    return "...World!";
            //    //stopwatch.Stop();
            //});

            // Task 4 - Asynchronous Error Handling
            //try
            //{
            //    source.CancelAfter(5000);
            //    var combinedTask = await Task.WhenAll(task1, task2);
            //    Console.WriteLine(combinedTask[0] + combinedTask[1]);

            //}
            //catch (OperationCanceledException ex) 
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}

        }
    }
}
