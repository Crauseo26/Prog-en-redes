namespace Threads___Ejercicio_3
{
    public class Sum
    {
        private readonly int sum_one;
        private readonly int sum_two;
        private readonly int sum_three;
        public int result { get; set; }

        public Sum(int n1, int n2, int n3 = 0)
        {
            Console.WriteLine("[Sum.Sum] Instantiated with values of {0}, {1} and {2}", n1, n2, n3);
            this.sum_one = n1;
            this.sum_two = n2;
            this.sum_three = n3;
        }

        public void AddTwoElements()
        {
            this.result = this.sum_one + this.sum_two;
        }

        public void AddThreeElements()
        {
            this.result = this.sum_one + this.sum_two + this.sum_three;
        }
    }
}
