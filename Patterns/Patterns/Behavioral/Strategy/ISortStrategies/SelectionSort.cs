using System;
using System.Collections.Generic;
using System.Linq;
using Patterns.Behavioral.Strategy.Interfaces;

namespace Patterns.Behavioral.Strategy.ISortStrategies
{
    public class SelectionSort : ISort
    {
        public void SortArray<T>(ref T[] collection) where T : struct, IConvertible
        {
            Console.WriteLine("Sort the array using Selection Sort");

            var array = collection.ToArray();

            int Comparison(T element1, T element2) => Comparer<T>.Default.Compare(element1, element2);

            for (int i = 0; i < array.Length - 1; i++)
            {
                int k = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (Comparison(array[k], array[j]) > 0)
                    {
                        k = j;
                    }

                    if (k != i)
                    {
                        var temp = array[k];
                        array[k] = array[i];
                        array[i] = temp;
                    }
                }
            }

            collection = array;
        }
    }
}