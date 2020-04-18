using System;

namespace Progression
{
    class AProgression : Progression
    {
        public AProgression(double fe, double k) : base (fe, k)
        { }

        public override double GetElement(int num)
        {
            return num > 0? FirstElem + ((num - 1) * K) :
                            GetElement(Solve());
        }
    }
}
