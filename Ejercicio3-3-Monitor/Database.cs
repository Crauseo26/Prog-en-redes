namespace Ejercicio3_3_Monitor
{
    internal class Database
    {
        public void SaveData(string text)
        {
            Monitor.Enter(this);
            Console.WriteLine("Database.SaveData -Iniciado");

            Console.WriteLine("Database.SaveData -Ejecutandose");

            throw new Exception("Error");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                Console.Write(text);
            }

            Console.WriteLine("\nDatabase.SaveData -Finalizado");
            Monitor.Exit(this);
        }
    }
}
