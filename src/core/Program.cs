namespace adComo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello");
            await Task.Delay(1000);
            Console.WriteLine("World");
        }
    }
}