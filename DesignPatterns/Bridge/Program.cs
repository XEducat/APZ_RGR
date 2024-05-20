using Bridge;
using Bridge.Renderers;

class Program
{
    static void Main(string[] args)
    {
        // Створюємо об'єкти залежно від типу рендерера
        var vectorCircle = new Circle(5, new VectorRenderer());
        var rasterCircle = new Circle(10, new RasterRenderer());

        // Відображаємо коло залежно від типу рендерера
        vectorCircle.Draw();
        rasterCircle.Draw();
    }
}
