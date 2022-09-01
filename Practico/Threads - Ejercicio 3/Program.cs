
using Threads___Ejercicio_3;

Sum sum_two_elements = new(25, 41);
Sum sum_three_elements = new(25, 41, 19);

void Method1()
{
    Console.WriteLine("Initializing Method 1");
    sum_two_elements.AddTwoElements();
}

void Method2()
{
    Console.WriteLine("Initializing Method 2");
    sum_three_elements.AddThreeElements();
}

ThreadStart worker1 = new ThreadStart(Method1);
ThreadStart worker2 = new ThreadStart(Method2);

Thread t1 = new Thread(worker1);
Thread t2 = new Thread(worker2);

t1.Start();
t2.Start();
t2.Join();

Console.WriteLine("The results of Sum two elements is: " + sum_two_elements.result);
Console.WriteLine("The results of Sum three elements is: " + sum_three_elements.result);
