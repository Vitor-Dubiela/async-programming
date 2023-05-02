using System.Diagnostics;

namespace AsyncProgramming
{
    class Program
    {
        static async Task Main()
        {
            Stopwatch sw = Stopwatch.StartNew();
            await PrepareCoffeeAsync();
            sw.Stop();

            Console.WriteLine($"PrepareCoffeeAsync() - Time running: {sw.ElapsedMilliseconds}ms\n\n");

            sw = Stopwatch.StartNew();
            PrepareCoffee();
            sw.Stop();

            Console.WriteLine($"PrepareCoffee() - Time running: {sw.ElapsedMilliseconds}ms");
        }

        private static void PrepareCoffee()
        {
            Console.WriteLine("Started preparing coffee...");

            var boiledWater = BoilWater();

            GetItensForPreparing();

            var water = boiledWater;

            Console.WriteLine($"Pouring the {water} to make the coffee...");
            Task.Delay(8000).Wait();

            Console.WriteLine("The coffee is ready ;D");
        }

        private static async Task PrepareCoffeeAsync()
        {
            Console.WriteLine("Started preparing coffee...");

            var boiledWater = BoilWaterAsync();

            await GetItensForPreparingAsync();

            var water = await boiledWater;

            Console.WriteLine($"Pouring the {water} to make the coffee...");
            Task.Delay(8000).Wait();

            Console.WriteLine("The coffee is ready ;D");
        }

        private static void GetItensForPreparing()
        {
            Console.WriteLine("Taking the itens to prepare the coffee...");
            Task.Delay(2000).Wait();
            Console.WriteLine("Got all the itens.");
        }

        private static async Task GetItensForPreparingAsync()
        {
            Console.WriteLine("Taking the itens to prepare the coffee...");
            await Task.Delay(2000);
            Console.WriteLine("Got all the itens.");
        }

        private static string BoilWater()
        {
            Console.WriteLine("Start heating the kettle...");
            Task.Delay(5000).Wait();
            Console.WriteLine("The kettle is ready.");

            return "boiled water";
        }

        private static async Task<string> BoilWaterAsync()
        {
            Console.WriteLine("Start heating the kettle...");
            await Task.Delay(5000);
            Console.WriteLine("The kettle is ready.");

            return "boiled water";
        }
    }
}