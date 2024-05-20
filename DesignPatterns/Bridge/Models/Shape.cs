using Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
