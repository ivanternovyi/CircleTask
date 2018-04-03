using System;

namespace TaskApp
{
    
    public class Circle : IComparable<Circle>
    {
        private double x;
        private double y;
        private double radius;

        public Circle(double x1, double y1, double r)
        {
            x = x1;
            y = y1;
            radius = r;
        }

        public double CalculateSquare()
        {
            return Math.PI * radius * radius;
        }

        public int CompareTo(Circle orderToCompare)
        {
            if (orderToCompare.CalculateSquare() > CalculateSquare())
            {
                return 1;
            }
            if (orderToCompare.CalculateSquare() < CalculateSquare())
            {
                return -1;
            }
            return 0;
        }

        public bool LiesInFirstQuater()
        {
            return x > 0 && y > 0 && radius <= Math.Min(x, y);
        }

        public double CalculateLength()
        {
            return 2 * Math.PI * radius;
        }

        public bool IsIntercepted(Circle obj)
        {
            var distance = Math.Sqrt(Math.Pow((x - obj.x), 2) + Math.Pow((y - obj.y), 2));
            var diff = Math.Abs(radius - obj.radius);
            if (distance <= diff)
            {
                return false;
            }
            return distance <= (radius + obj.radius);
        }

        public override string ToString()
        {
            return $"Coordinates: {x}, {y}; Radius: {radius}; ";
        }

    }    
}