namespace Ejercicio_3_4_MonitorWithConditions
{
    internal class MyThread
    {
        public Thread thread;
        private readonly PingPong pingPongObj;

        public MyThread(string name, PingPong pp)
        {
            this.thread = new Thread(new ThreadStart(this.run));
            this.pingPongObj = pp;
            this.thread.Name = name;
            this.thread.Start();

        }

        public void run()
        {
            if (this.thread.Name == "Ping")
            {
                for (int i = 0; i < 5; i++)
                {
                    this.pingPongObj.ping(true);
                }
                this.pingPongObj.ping(false);
            }
            else
            {
                for (int j = 0; j < 5; j++)
                {
                    this.pingPongObj.pong(true);
                }

                this.pingPongObj.pong(false);
            }
        }
    }
}
