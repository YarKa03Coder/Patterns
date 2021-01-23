using System;

namespace Patterns.Creational.Prototype
{
    public class Rectangle: PrototypeShape
    {
        private readonly int _width;
        private readonly int _height;

        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }

        /// <summary>
        /// Return clone of the Rectangle class (MemberwiseClone's return value casts to Rectangle)
        /// </summary>
        /// <returns></returns>
        public override PrototypeShape Clone()
        {
            return (Rectangle)this.MemberwiseClone();
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"A values of width and height respectively for the {this.GetType().Name} instance: {_width}, {_height}");
        }
    }
}