namespace TaskPattern
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting Test!");
            var concreteTask = new ConcreteTask();

            concreteTask.Execute();

            for (var i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("Runing code in Main: " + i);
            }

            concreteTask.WaitForFinish();
            Console.WriteLine("End");
        }
    }
}

