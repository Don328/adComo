using adComo.Data;

namespace adComo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Task.Delay(1000);
            var state = new State();
            DisplayNewTasks(state);
            await Task.Delay(1000);
            DisplayActiveTasks(state);
            await Task.Delay(1000);
            DisplayPendingTasks(state);
            await Task.Delay(1000);
            DisplayCompletedTasks(state);
        }

        private static void DisplayNewTasks(State state)
        {
            foreach (var opus in state.Novus)
            {
                Console.WriteLine($"Title: {opus.Title}");
                Console.WriteLine($"Id: {opus.OpusId}");
                Console.WriteLine($"Status: {opus.Status}");
                Console.WriteLine();
            }
        }

        private static void DisplayActiveTasks(State state)
        {
            foreach (var opus in state.Accedant)
            {
                Console.WriteLine($"Title: {opus.Title}");
                Console.WriteLine($"Id: {opus.OpusId}");
                Console.WriteLine($"Status: {opus.Status}");
                Console.WriteLine();
            }
        }

        private static void DisplayPendingTasks(State state)
        {
            foreach (var opus in state.Pendente)
            {
                Console.WriteLine($"Title: {opus.Title}");
                Console.WriteLine($"Id: {opus.OpusId}");
                Console.WriteLine($"Status: {opus.Status}");
                Console.WriteLine();
            }
        }

        private static void DisplayCompletedTasks(State state)
        {
            foreach (var opus in state.Completum)
            {
                Console.WriteLine($"Title: {opus.Title}");
                Console.WriteLine($"Id: {opus.OpusId}");
                Console.WriteLine($"Status: {opus.Status}");
                Console.WriteLine();
            }
        }
    }
}