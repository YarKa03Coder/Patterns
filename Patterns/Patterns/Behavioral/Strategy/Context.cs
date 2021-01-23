using System;
using Patterns.Behavioral.Strategy.Interfaces;

namespace Patterns.Behavioral.Strategy
{
    public class Context<T> where T : struct, IConvertible
    {
        public IPrint Print { get; set; }

        public ISort Sort { get; set; }

        private T[] _array;

        public Context(ISort sort, IPrint print)
        {
            Sort = sort;
            Print = print;
        }

        public void SortArray()
        {
            if (_array is null)
            {
                Console.WriteLine("Can not sort empty array. Initialize it first");
            }
            else
            {
                Sort.SortArray(ref _array);
            }
        }

        public void InitializeArray(T[] array)
        {
            _array = array;
        }

        public void PrintArray()
        {
            if (_array is null)
            {
                Console.WriteLine("Initialize array!!! It is empty");
            }
            else
            {
                Print.PrintArray(_array);
            }
        }
    }
}