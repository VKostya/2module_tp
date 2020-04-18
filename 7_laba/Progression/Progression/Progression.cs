using System;

namespace Progression
{
    abstract class Progression
    {
        public Progression(double fe, double k)
        {
            FirstElem = fe;
            K = k;
        }

        public abstract double GetElement(int num);

        protected double FirstElem { get; set; }
        protected double K { get; set; }

        #region n <= 0
        protected int Solve()
        {
            int n;
            Console.WriteLine("Enter n > 0");
            n = Int16.Parse(Console.ReadLine());
            return n;
        }

        #endregion
    }
}
