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

            static async Task DelayHello()
            {
                await Task.Delay(3000);
                Console.WriteLine("Hello");
            }

            static async Task DelayWorld()
            {
                await Task.Delay(3000);
                Console.WriteLine("World!");
            }
            await Task.WhenAll(DelayHello(), DelayWorld());            

        }
    }
}
