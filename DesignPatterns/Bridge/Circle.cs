using Bridge.Interfaces;
using Bridge.Models;

namespace Bridge
{
    // Реалізація абстракції
    class Circle : Shape
    {
        private readonly double radius;

        public Circle(double radius, IRenderer renderer) : base(renderer)
        {
            this.radius = radius;
        }

        public override void Draw()
        {
            renderer.RenderCircle(radius);
        }
    }
}
