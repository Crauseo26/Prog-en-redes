namespace Ejercicio_3_4_MonitorWithConditions
{
    internal class PingPong
    {
        public void ping(bool running)
        {
            lock (this)
            {
                if (!running)
                {
                    Monitor.Pulse(this); //notify any waiting threads
                    return;
                }
                Thread.Sleep(1200);
                Console.WriteLine("Ping");
                Monitor.Pulse(this); // let pong() run
                Monitor.Wait(this); // wait for pong() to complete
            }

        }

        public void pong(bool running)
        {
            lock (this)
            {
                if (!running)
                {
                    Monitor.Pulse(this); //notify any waiting threads
                    return;
                }
                Thread.Sleep(1200);
                Console.WriteLine("Pong");
                Monitor.Pulse(this); // let pong() run
                Monitor.Wait(this); // wait for pong() to complete
            }
        }
    }
}
