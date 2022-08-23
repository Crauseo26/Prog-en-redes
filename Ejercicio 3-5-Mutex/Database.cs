namespace Ejercicio_3_5_Mutex
{
    internal class Database
    {
        public static Mutex mutex = new Mutex(false);

        public static void SaveData(string txt)
        {
            mutex.WaitOne();

            Console.WriteLine("Database.SaveData  -started");
            Console.WriteLine("Database.SaveData  -working");

            for (int i = 0; i < 100; i++)
            {
                Console.Write(txt);
            }
            Console.WriteLine("\n Database.SaveData -ended");
            mutex.ReleaseMutex();
        }
    }
}
