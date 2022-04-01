using adComo.Data;

namespace adComo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Task.Delay(1000);
            var seed = new Seed();
            var opera = seed.SeedOpera();
            foreach (var opus in opera)
            {
                Console.WriteLine( $"Title: {opus.Title}");
                Console.WriteLine( $"Id: {opus.OpusId}");
                Console.WriteLine();
            }
        }
    }
}