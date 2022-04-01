using adComo.Data;

namespace adComo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Task.Delay(1000);
            var state = new State();
            foreach (var opus in state.Opera)
            {
                Console.WriteLine( $"Title: {opus.Title}");
                Console.WriteLine( $"Id: {opus.OpusId}");
                Console.WriteLine( $"Status: {opus.Status}");
                Console.WriteLine();
            }
        }
    }
}