using Bridge.Interfaces;

namespace Bridge.Renderers
{
    // Конкретна реалізація
    class VectorRenderer : IRenderer
    {
        public void RenderCircle(double radius)
        {
            Console.WriteLine($"Drawing a circle of radius {radius} using vector graphics.");
        }
    }
}
