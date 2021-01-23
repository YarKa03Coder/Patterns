using System;
using Patterns.Behavioral.Visitor.ConcreteElements;

namespace Patterns.Behavioral.Visitor.ConcreteVisitors
{
    public class ConcreteVisitor : IVisitor
    {
        public void PrintBooks(Books books)
        {
            for (var i = 0; i < books.Count; i++)
            {
                Console.WriteLine(books[i]);
            }
            
            Console.WriteLine();
        }

        public void PrintMagazines(Magazines magazines)
        {
            for (var i = 0; i < magazines.Count; i++)
            {
                Console.WriteLine(magazines[i]);
            }
            
            Console.WriteLine();
        }
    }
}