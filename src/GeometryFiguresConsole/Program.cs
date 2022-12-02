using Figures.Implementation;

Console.WriteLine("Triangle area and perimeter");
Triangle triangle = new Triangle(8.2, 7.3, 9.2);
Console.WriteLine("Area: " + triangle.GetArea());
Console.WriteLine("Perimeter" + triangle.GetPerimeter());

Console.WriteLine("Circle area and perimeter");
Circle circle = new Circle(7.32);
Console.WriteLine("Area: " + circle.GetArea());
Console.WriteLine("Perimeter " + circle.GetPerimeter());
