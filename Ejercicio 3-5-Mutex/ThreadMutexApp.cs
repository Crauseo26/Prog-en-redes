namespace Ejercicio_3_5_Mutex
{
    internal class ThreadMutexApp
    {
        public static void WorkerThreadMethod1()
        {
            Console.WriteLine("worker thread #1 -started");
            Console.WriteLine("worker thread #1 - Calling Database.SaveData");
            Database.SaveData("x");
            Console.WriteLine("worker thread #1 -returned from output");
        }

        public static void WorkerThreadMethod2()
        {
            Console.WriteLine("worker thread #2 -started");
            Console.WriteLine("worker thread #2 - Calling Database.SaveData");
            Database.SaveData("o");
            Console.WriteLine("worker thread #2 -returned from output");
        }

        public static void Main()
        {
            ThreadStart worker1 = new ThreadStart(WorkerThreadMethod1);
            ThreadStart worker2 = new ThreadStart(WorkerThreadMethod2);

            Thread t1 = new Thread(worker1);
            Thread t2 = new Thread(worker2);
            t1.Start();
            t2.Start();
        }
    }
}
