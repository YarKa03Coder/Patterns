using System;
using Patterns.Behavioral.Strategy.Interfaces;

namespace Patterns.Behavioral.Strategy.IPrintStrategies
{
    public class PrintDirectOrder : IPrint
    {
        public void PrintArray<T>(T[] collection) where T : struct, IConvertible
        {
            foreach (var element in collection)
            {
                Console.Write("{0}{1}",element,' ');
            }

            Console.WriteLine();
        }
    }
}