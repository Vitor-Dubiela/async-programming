using System.Diagnostics;

namespace AsyncProgramming
{
    class Program
    {
        private static Stopwatch _sw = new Stopwatch();

        static async Task Main()
        {
            _sw = Stopwatch.StartNew();
            Console.WriteLine("----------------- PrepareCoffee ----------------");
            Console.WriteLine($"PrepareCoffee - Started preparing the coffee \nTime running: {_sw.ElapsedMilliseconds}ms \nThread: {Thread.CurrentThread.ManagedThreadId}\n\n");

            PrepareCoffee();

            Console.WriteLine($"PrepareCoffee - Finished preparing the coffee \nTime running: {_sw.ElapsedMilliseconds}ms \nThread: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("----------------- PrepareCoffee ----------------\n\n\n");
            _sw.Stop();
            
            _sw = Stopwatch.StartNew();
            Console.WriteLine("----------------- PrepareCoffeeAsync ----------------");
            await Console.Out.WriteLineAsync($"Started preparing the coffee Async \nTime running: {_sw.ElapsedMilliseconds}ms \nThread: {Thread.CurrentThread.ManagedThreadId}\n\n");

            await PrepareCoffeeAsync();

            await Console.Out.WriteLineAsync($"Finished preparing the coffee Async \nTime running: {_sw.ElapsedMilliseconds}ms \nThread: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("----------------- PrepareCoffeeAsync ----------------");
            _sw.Stop();
        }

        private static void PrepareCoffee()
        {
            BoilWater();

            PrepareTable();
        }

        private static void BoilWater()
        {
            Console.WriteLine($"BoilWater - Started boiling the water \nTime running: {_sw.ElapsedMilliseconds}ms \nThread: {Thread.CurrentThread.ManagedThreadId}\n\n");

            Task.Delay(10000).Wait();

            Console.WriteLine($"BoilWater - Finished boiling the water \nTime running: {_sw.ElapsedMilliseconds}ms \nThread: {Thread.CurrentThread.ManagedThreadId}\n\n");
        }

        private static void PrepareTable()
        {
            Console.WriteLine($"PrepareTable - Started preparing the table \nTime running: {_sw.ElapsedMilliseconds}ms \nThread: {Thread.CurrentThread.ManagedThreadId}\n\n");

            Task.Delay(5000).Wait();

            Console.WriteLine($"PrepareTable - Finished preparing the table \nTime running: {_sw.ElapsedMilliseconds}ms \nThread: {Thread.CurrentThread.ManagedThreadId}\n\n");
        }

        private static async Task PrepareCoffeeAsync()
        {
            var task = BoilWaterAsync();

            await PrepareTableAsync();

            await task;
        }

        private static async Task BoilWaterAsync()
        {
            Console.WriteLine($"BoilWaterAsync - Started boiling the water \nTime running: {_sw.ElapsedMilliseconds}ms \nThread: {Thread.CurrentThread.ManagedThreadId}\n\n");

            await Task.Delay(10000);

            Console.WriteLine($"BoilWaterAsync - Finished boiling the water \nTime running: {_sw.ElapsedMilliseconds}ms \nThread: {Thread.CurrentThread.ManagedThreadId}\n\n");
        }

        private static async Task PrepareTableAsync()
        {
            Console.WriteLine($"PrepareTableAsync - Started preparing the table \nTime running: {_sw.ElapsedMilliseconds}ms \nThread: {Thread.CurrentThread.ManagedThreadId}\n\n");

            await Task.Delay(5000);

            Console.WriteLine($"PrepareTableAsync - Finished preparing the table \nTime running: {_sw.ElapsedMilliseconds}ms \nThread: {Thread.CurrentThread.ManagedThreadId}\n\n");
        }
    }
}