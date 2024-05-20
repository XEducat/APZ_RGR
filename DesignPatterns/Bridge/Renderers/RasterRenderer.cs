using Bridge.Interfaces;

namespace Bridge.Renderers
{
    // Ще одна конкретна реалізація
    class RasterRenderer : IRenderer
    {
        public void RenderCircle(double radius)
        {
            Console.WriteLine($"Drawing a circle of radius {radius} using raster graphics.");
        }
    }

}
