namespace Ejercicio3_3_Monitor
{
    internal class Database
    {
        public void SaveData(string text)
        {
            lock (this)
            {
                Console.WriteLine("Database.SaveData -Iniciado");

                Console.WriteLine("Database.SaveData -Ejecutandose");
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                    Console.Write(text);
                }

                Console.WriteLine("\nDatabase.SaveData -Finalizado");
            }
        }
    }
}
