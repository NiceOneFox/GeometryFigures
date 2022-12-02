using Figures.Implementation;
using FluentAssertions;
using NUnit.Framework;

namespace FiguresTests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void Get_circle_radius()
        {
            double approximation = 0.001;
            var sut = new Circle(3);

            var area = sut.GetArea();

            area.Should().BeApproximately(28.2743, approximation);
        }

        [Test]
        public void Get_circle_perimeter()
        {
            double approximation = 0.001;
            var sut = new Circle(3.4);

            var perimeter = sut.GetPerimeter();

            perimeter.Should().BeApproximately(21.36283, approximation);
        }
    }
}