namespace TaskPatternDelegate
{
    public delegate void FinishTask(AbstractTask abstractTask);
    public abstract class AbstractTask
    {
        private Thread m_Thread = null;

        private FinishTask m_CallBack = null;

        public void Execute(FinishTask callback)
        {
            this.m_CallBack = callback;
            this.m_Thread = new Thread(new ThreadStart(this.FinishTask));
            this.m_Thread.Start();
        }

        public void WaitForFinish()
        {
            if (this.m_Thread != null)
            {
                this.m_Thread.Join();
            }
        }

        private void FinishTask()
        {
            this.Process();
            if (this.m_CallBack != null)
            {
                this.m_CallBack.Invoke(this);
            }
        }

        protected abstract void Process();
    }
}
