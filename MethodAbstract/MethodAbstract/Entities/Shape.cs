using MethodAbstract.Entities.Enums;

namespace MethodAbstract.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public abstract double Area();

    }
}
