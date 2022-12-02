using Figures.Interfaces;
using Figures.Validation;

namespace Figures.Implementation
{
    public class Circle : ICircle, ITwoDimensionalShape
    {
        public double Radius { get; private set; }

        public Circle(double R)
        {
            FigureValidation.CheckIfLessOrEqualZero(R);

            Radius = R;
        }

        public double GetRadius() => Radius;

        public double GetPerimeter() => 2 * Math.PI * Radius; // 2PiR

        public double GetArea() => Math.PI * Math.Pow(Radius, 2); // 2PiR^2
    }
}
