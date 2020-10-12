using AbstracMethod.Entities.Enums;

namespace AbstracMethod.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public void Shape(Color color)
        {
            Color = color;

        }

        abstract public double area();

    }
}
