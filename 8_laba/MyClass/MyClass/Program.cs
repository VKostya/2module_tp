using System;
using System.Collections.Generic;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Audit.RunAudit();
            Magazine mag1 = new Magazine
                            ("О природе", "Земля и мы", 5, 2014, 1235, true);
            mag1.Subs();
            Audit.StopAudit();
            Magazine mag2 = new Magazine
                            ("О природе", "Земля и мы", 6, 2014, 12356, true);
            mag2.Subs();
        }
    }
}

