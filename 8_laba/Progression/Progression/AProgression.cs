using System;

namespace Progression
{
    class AProgression : Progression
    {
        public AProgression(double fe, double k)
        {
            FirstElem = fe;
            K = k;
        }

        protected int Solve()
        {
            int n;
            Console.WriteLine("Enter n > 0");
            n = Int16.Parse(Console.ReadLine());
            return n;
        }

        protected double FirstElem { get; set; }
        protected double K { get; set; }

        public double GetElement(int num)
        {
            return num > 0? FirstElem + ((num - 1) * K) :
                            GetElement(Solve());
        }
    }
}
