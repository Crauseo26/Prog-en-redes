namespace Ejercicio_3_4_MonitorWithConditions
{
    internal class BouncingBall
    {
        public static void Main()
        {
            PingPong pp = new PingPong();
            Console.WriteLine("The ball is dropped... \n");
            MyThread myThread1 = new MyThread("Ping", pp);
            MyThread myThread2 = new MyThread("Pong", pp);
            myThread1.thread.Join();
            myThread2.thread.Join();
            Console.WriteLine("\n The ball stop bouncing");
            Console.Read();
        }
    }
}
