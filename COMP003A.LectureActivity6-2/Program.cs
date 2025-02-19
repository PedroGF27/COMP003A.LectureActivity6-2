// Pedro Garcia
// COMP003A
// Jonathan Cruz
// 
namespace COMP003A.LectureActivity6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeCalculator calculator = new ShapeCalculator();
            Console.WriteLine($"Circle Area: {calculator.CalculateArea(5)}");
            Console.WriteLine($"Rectangle Area {calculator.CalculateArea(5, 10)}");
            Console.WriteLine($"Triangle Area: {calculator.CalculateArea(5, 10, true)}");

            Shape myCircle = new Circle(7);

            Shape myRectangle = new Rectangle(4, 8);

            myCircle.DisplayArea();
            myRectangle.DisplayArea();
        }
    }
}
