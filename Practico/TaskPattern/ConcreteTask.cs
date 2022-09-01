namespace TaskPattern
{
    internal class ConcreteTask : AbstractTask
    {
        protected override void Process()
        {
            Console.WriteLine("Starting Concrete Task!");
            for (var i = 0; i < 20; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("Running Task iteration: " + i);
            }
            Console.WriteLine("Finishing concrete Task");
        }
    }
}
