using Bridge.Interfaces;

namespace Bridge.Models
{
    // Абстракція
    abstract class Shape
    {
        protected IRenderer renderer;

        public Shape(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public abstract void Draw();
    }
}
