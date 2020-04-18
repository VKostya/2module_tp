using System;
using System.Collections.Generic;

namespace Progression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Progression> Progressions = new List<Progression>
            {
                new AProgression(2, 2),
                new GProgression(3, 3),
                new GProgression(1, -1)
            };
            foreach (Progression prog in Progressions)
            {
                Console.Write("Enter progression's element number ");
                Console.WriteLine(prog.GetElement
                    (Int16.Parse(Console.ReadLine())));
            }
        }
    }
}
