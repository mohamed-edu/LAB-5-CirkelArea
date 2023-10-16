// namn mohamed mohamud
// klass:Net23

namespace CirkelArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5); // skapar ett objekt
            Circle circle2 = new Circle(6); //__

            double area1 = circle1.getArea(); // anropar getarea metoden
            double area2 = circle2.getArea();

            Console.WriteLine("the Area of a circle with a radius of 5 is :"+ area1); // skriver ut area1
            Console.WriteLine("the Area of a circle with a radius of 6 is :"+ area2); // skriver ut area2

        }
    }
    class Circle
    {
        public float _pi = 3.141f;
        public int _Radius;
        public Circle (int Radius) // här är constructor
        {
            _Radius = Radius;
        }
        public double getArea()
        {
            double Area = _Radius * _pi * _Radius;
            return Area; // returnerar area
        }
    }

}