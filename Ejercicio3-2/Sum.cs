namespace PR_Ejercicio3
{
    internal class Sum
    {
        private readonly int op1;
        private readonly int op2;
        public int result { get; set; }

        public Sum(int op1, int op2)
        {
            Console.WriteLine("[Sum.Sum] Instantiated with values of {0} and {1}", op1, op2);
            this.op1 = op1;
            this.op2 = op2;
        }

        public void Add()
        {
            // Simulate work
            Thread.Sleep(5000);
            this.result = this.op1 + this.op2;
        }
    }
}
