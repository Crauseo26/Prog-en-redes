
using Threads___Ejercicio_1;

static void Main()
{
    var implementations = new ThreadSyncImplementations();

    void Method1()
    {

        Console.WriteLine("Initializing Method 1");
        Console.WriteLine("Executing Method 1");
        implementations.ImplementationOne("x");
    }
    void Method2()
    {

        Console.WriteLine("Initializing Method 2");
        Console.WriteLine("Executing Method 2");
        implementations.ImplementationOne("y");
    }
    void Method3()
    {

        Console.WriteLine("Initializing Method 3");
        Console.WriteLine("Executing Method 3");
        implementations.ImplementationTwo("x");
    }
    void Method4()
    {

        Console.WriteLine("Initializing Method 4");
        Console.WriteLine("Executing Method 4");
        implementations.ImplementationTwo("y");
    }

    ThreadStart worker1 = new ThreadStart(Method1);
    ThreadStart worker2 = new ThreadStart(Method2);
    ThreadStart worker3 = new ThreadStart(Method3);
    ThreadStart worker4 = new ThreadStart(Method4);

    Console.WriteLine("Principal -creando hilos de ejecucion secundarios");

    Thread t1 = new Thread(worker1);
    Thread t2 = new Thread(worker2);
    Thread t3 = new Thread(worker3);
    Thread t4 = new Thread(worker4);

    t1.Start();
    t2.Start();
    t2.Join();
    t3.Start();
    t3.Join();
    t4.Start();
}

Main();


