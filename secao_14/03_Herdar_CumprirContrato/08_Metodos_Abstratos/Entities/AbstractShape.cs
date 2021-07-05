using _08_Metodos_Abstratos.Entities;
using _08_Metodos_Abstratos.Entities.Enums;

namespace Course.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}