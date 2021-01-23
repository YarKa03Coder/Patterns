using System;
using System.Collections.Generic;
using System.Linq;
using Patterns.Behavioral.Strategy.Interfaces;

namespace Patterns.Behavioral.Strategy.ISortStrategies
{
    public class InsertionSort : ISort
    {
        public void SortArray<T>(ref T[] collection) where T : struct, IConvertible
        {
            Console.WriteLine("Sort the array using Insertion Sort");

            var array = collection.ToArray();

            int Comparison(T element1, T element2) => Comparer<T>.Default.Compare(element1, element2);

            for (int i = 1; i < array.Length; i++)
            {
                int j = i - 1;
                var buffer = array[i];

                while (j >= 0 && Comparison(array[j], buffer) > 0)
                {
                    array[j + 1] = array[j];
                    j -= 1;
                }

                array[j + 1] = buffer;
            }

            collection = array;
        }
    }
}