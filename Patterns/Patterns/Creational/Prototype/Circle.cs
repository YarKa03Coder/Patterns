using System;

namespace Patterns.Creational.Prototype
{
    public class Circle : PrototypeShape
    {
        private readonly int _radius;
        
        public Circle(int radius)
        {
            _radius = radius;
        }
        
        /// <summary>
        /// Return clone of the Circle class (MemberwiseClone's return value casts to Circle)
        /// </summary>
        /// <returns></returns>
        public override PrototypeShape Clone()
        {
            return (Circle)this.MemberwiseClone();
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"A value of radius for the {this.GetType().Name} instance: {_radius}");
        }
    }
}