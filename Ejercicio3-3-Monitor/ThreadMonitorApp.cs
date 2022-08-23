namespace Ejercicio3_3_Monitor
{
    internal class ThreadMonitorApp
    {
        public static Database db = new Database();
        public static void WorkerThreadMethod1()
        {
            Console.WriteLine("Hilo de ejecucion secundario #1 -iniciado");
            Console.WriteLine("Hilo de ejecucion secundario #1 -invocando Database.SaveData");
            try
            {
                db.SaveData("x");
            }
            catch
            {

            }

            Console.WriteLine("Hilo de ejecucion secundario #1 -retornando desde Output");
        }
        public static void WorkerThreadMethod2()
        {
            Console.WriteLine("Hilo de ejecucion secundario #2 -iniciado");
            Console.WriteLine("Hilo de ejecucion secundario #2 -invocando Database.SaveData");
            try
            {
                db.SaveData("o");
            }
            catch
            {

            }
            Console.WriteLine("Hilo de ejecucion secundario #2 -retornando desde Output");
        }

        public static void Main()
        {
            ThreadStart worker1 = new ThreadStart(WorkerThreadMethod1);
            ThreadStart worker2 = new ThreadStart(WorkerThreadMethod2);

            Console.WriteLine("Principal - Creando hilos de ejecucion secundarios");

            Thread t1 = new Thread(worker1);
            Thread t2 = new Thread(worker2);

            t1.Start();
            t2.Start();
        }
    }
}
