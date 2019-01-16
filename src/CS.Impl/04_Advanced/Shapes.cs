using System;

namespace CS.Impl._04_Advanced
{
    public abstract class Shape
    {
        public abstract double GetArea();

        public abstract double GetPerimeter();

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }

    public class Circle : Shape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.Round(Math.PI * Math.Pow(_radius, 2));
        }

        public override double GetPerimeter()
        {
            return Math.Round(2 * Math.PI * _radius);
        }
    }

    public class Rectangle : Shape
    {
        private readonly double _length;
        private readonly double _width;

        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }

        public override double GetArea()
        {
            return _length * _width;
        }

        public override double GetPerimeter()
        {
            return 2 * _length + 2 * _width;
        }
    }

    public class Square : Shape
    {
        private readonly double _sideLength;

        public Square(double sideLength)
        {
            _sideLength = sideLength;
        }

        public override double GetArea()
        {
            return Math.Pow(_sideLength, 2);
        }

        public override double GetPerimeter()
        {
            return 4 * _sideLength;
        }
    }
}