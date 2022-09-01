namespace TaskPattern
{
    public abstract class AbstractTask
    {
        private Thread _thread = null;

        public void Execute()
        {
            this._thread = new Thread(new ThreadStart(this.Process));
            this._thread.Start();
        }

        public void WaitForFinish()
        {
            if (this._thread != null)
            {
                this._thread.Join();
            }
        }

        protected abstract void Process();
    }
}
