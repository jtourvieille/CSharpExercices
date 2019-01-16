using System;

namespace CS.Impl._04_Advanced
{
    public abstract class Shape
    {
        public abstract double GetArea();

        public abstract double GetPerimeter();

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }

    public class Circle : Shape
    {
        public Circle(double radius)
        {
            throw new NotImplementedException();
        }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }

        public override double GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }

    public class Rectangle : Shape
    {
        public Rectangle(double length, double width)
        {
            throw new NotImplementedException();
        }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }

        public override double GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }

    public class Square : Shape
    {
        public Square(double sideLength)
        {
            throw new NotImplementedException();
        }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }

        public override double GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }
}