namespace cs__async_sprint
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await DelayPrint();
            static async Task DelayPrint()
            {
                await Task.Delay(2000);
                Console.WriteLine("Hello, World!");
            }
        }
    }
}
