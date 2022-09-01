internal class ThreadScheduleApp
{
    public static void WorkerThreadMethod1()
    {
        Console.WriteLine("Hilo de ejecucion secundario iniciado");
        Console.WriteLine("Hilo de ejecucion secundaria - contando lentamente de 1 a 10");
        for (int i = 1; i < 11; i++)
        {

            for (int j = 1; j < 11; j++)
            {
                Console.Write(".");
            }
            Console.Write("{0}", i);
        }

        Console.WriteLine("Hilo de ejecucion secundario finalizado");
    }

    public static void WorkerThreadMethod2()
    {
        Console.WriteLine("Hilo de ejecucion secundario iniciado");
        Console.WriteLine("Hilo de ejecucion secundaria - contando lentamente de 11 a 20");
        for (int i = 11; i < 20; i++)
        {

            for (int j = 1; j < 100; j++)
            {
                Console.Write(".");
            }
            Console.Write("{0}", i);
        }

        Console.WriteLine("Hilo de ejecucion secundario finalizado");
    }

    public static void Main()
    {
        ThreadStart worker1 = new ThreadStart(WorkerThreadMethod1);
        ThreadStart worker2 = new ThreadStart(WorkerThreadMethod2);

        Console.WriteLine("Principal -creando hilos de ejecucion secundarios");

        Thread t1 = new Thread(worker1);
        Thread t2 = new Thread(worker2);

        t1.Priority = ThreadPriority.Highest;
        t2.Priority = ThreadPriority.Lowest;

        t1.Start();
        t2.Start();
    }

}