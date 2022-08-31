void Print()
{
    Console.WriteLine("Initializing printing...");
    for (var i = 0; i < 100; i++)
    {
        Thread.Sleep(250);
        Console.Write("0");
    }
    Console.WriteLine();
}

Console.WriteLine("Starting Main process");
Console.WriteLine("Creating SEcondary thread");
ThreadStart worker1 = new ThreadStart(Print);
Thread t1 = new Thread(worker1);
Console.WriteLine("Starting Secondary Thread");
t1.Start();
t1.Join();
Console.WriteLine("Secondary thread already finished");
