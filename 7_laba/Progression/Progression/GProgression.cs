using System;

namespace Progression
{
    class GProgression : Progression
    {
        public GProgression(double fe, double k) : base(fe, k)
        { }

        public override double GetElement(int num)
        {
            return num > 0 ? (FirstElem * Math.Pow(K, num - 1)) :
                             GetElement(Solve());
        }
    }
}
