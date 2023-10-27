namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();

            circle.Area();

            Square square = new Square();

            square.Area();

            Rectangle rectangle = new Rectangle();

            rectangle.Area();

            Ellipse ellipse = new Ellipse();

            ellipse.Area();

            Parallellogram parallellogram = new Parallellogram();

            parallellogram.Area();
        }
    }
}