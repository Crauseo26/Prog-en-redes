using TaskPatternDelegate;

Console.WriteLine("Starting Test");
var concreteTask = new ConcreteTask();

concreteTask.Execute(PrintFinishedTask);

for (var i = 0; i < 10; i++)
{
    Thread.Sleep(100);
    Console.WriteLine("Running code in Main: " + i);
}

static void PrintFinishedTask(AbstractTask abstractTask)
{
    Console.WriteLine("Task Finished task ------> " + abstractTask);
}
