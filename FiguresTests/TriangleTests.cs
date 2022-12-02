using Figures.Implementation;
using FluentAssertions;
using NUnit.Framework;

namespace FiguresTests
{
    [TestFixture]
    public class TriangleTests
    {

        [Test]
        public void Get_triangle_area()
        {
            double approximation = 0.001;
            var sut = new Triangle(3.1, 4.2, 5.5);

            var area = sut.GetArea();

            area.Should().BeApproximately(6.4667, approximation);
        }

        [Test]
        public void Get_perimeter()
        {
            var sut = new Triangle(4, 5, 6);

            var perimeter = sut.GetPerimeter();

            perimeter.Should().Be(15);
        }
    }
}
