using Figures.Interfaces;
using Figures.Validation;

namespace Figures.Implementation
{
    public class Triangle : ITwoDimensionalShape
    {
        // Three sides of triangle
        public double SideA { get; private set; }

        public double SideB { get; private set; }

        public double SideC { get; private set; }

        public Triangle(double a, double b, double c)
        {
            FigureValidation.CheckIfLessOrEqualZero(a);
            FigureValidation.CheckIfLessOrEqualZero(b);
            FigureValidation.CheckIfLessOrEqualZero(c);
            FigureValidation.CheckIfTriangle(a, b, c);

            SideA = a;
            SideB = b;
            SideC = c;
        }
        /// <summary>
        /// Gets area of triange using 3 sides
        /// </summary>
        public double GetArea()
        {
            double p = GetPerimeter() / 2; // semiperimeter
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC)); //Heron Formula
        }

        public double GetPerimeter() => SideA + SideB + SideC;

        /// <summary>
        /// Check if triangle is rectangular
        /// </summary>
        public bool IsRightTriangle() => Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2);
    }
}
