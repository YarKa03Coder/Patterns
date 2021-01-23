using System;
using System.Collections.Generic;
using System.Linq;
using Patterns.Behavioral.Strategy.Interfaces;

namespace Patterns.Behavioral.Strategy.ISortStrategies
{
    public class BubbleSort : ISort
    {
        public void SortArray<T>(ref T[] collection) where T : struct, IConvertible
        {
            Console.WriteLine("Sort the array using Bubble Sort");

            var array = collection.ToArray();

            int Comparison(T element1, T element2) => Comparer<T>.Default.Compare(element1, element2);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (Comparison(array[j], array[j + 1]) > 0)
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            collection = array;
        }
    }
}