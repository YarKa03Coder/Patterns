using System;
using System.Linq;
using Patterns.Behavioral.Strategy.Interfaces;

namespace Patterns.Behavioral.Strategy.IPrintStrategies
{
    public class PrintReverseOrder : IPrint
    {
        public void PrintArray<T>(T[] collection) where T : struct, IConvertible
        {
            foreach (var element in collection.Reverse())
            {
                Console.Write("{0}{1}", element, ' ');
            }

            Console.WriteLine();
        }
    }
}