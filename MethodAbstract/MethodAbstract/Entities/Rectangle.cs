using MethodAbstract.Entities;

namespace MethodAbstract
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area(double width, double heigth)
        {
            return 0;
        }
    }
}
