using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerenLib.Math
{
    public static class Math
    {
        public const double PI = 3.141592653589793d;
    }

    public static class Shapes
    {
        public static class Circle
        {
            public static double GetArea(double radius) => Math.PI * (radius * radius);
            public static double Circumference(double diameter) => Math.PI * diameter;
        }
        public static class Triangle
        {
            public static double GetArea(double height, double width) => (height * width) / 2.0d;
        }
    }
}
