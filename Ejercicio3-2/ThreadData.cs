namespace PR_Ejercicio3
{
    internal class ThreadData
    {
        public static void Main()
        {
            Console.WriteLine("[Main] Instantiating the Sum object and passing it the values to add");
            Sum sum = new Sum(6, 42);
            Console.WriteLine("[Main] starting thread using a Sum delegate");

            Thread thread = new Thread(new ThreadStart(sum.Add));
            thread.Start();
            // Here we're simulating doing some work before
            // blocking on the Add method's completion
            Console.WriteLine("[Main] Doing other work");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                Console.Write(".");
            }

            Console.WriteLine("\n[Main] Waiting for Add to finish");
            //thread.Join();
            Console.WriteLine("[Main] the result is {0}", sum.result);
            Console.ReadLine();

        }
    }
}
