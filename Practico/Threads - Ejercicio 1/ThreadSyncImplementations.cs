namespace Threads___Ejercicio_1
{
    public class ThreadSyncImplementations
    {
        public void ImplementationOne(string print)
        {
            lock (this)
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(200);
                    Console.Write(print);
                }
                Console.WriteLine();
            }
        }

        public void ImplementationTwo(string print)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                Console.Write(print);
            }
            Console.WriteLine();
        }

    }
}
