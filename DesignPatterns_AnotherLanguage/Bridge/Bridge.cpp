#include <iostream>

// Implementor
class Renderer {
public:
    virtual void renderCircle(float x, float y, float radius) = 0;
    virtual ~Renderer() = default;
};

// Concrete Implementor
class VectorRenderer : public Renderer {
public:
    void renderCircle(float x, float y, float radius) override {
        std::cout << "Rendering circle as vector at (" << x << ", " << y << ") with radius " << radius << std::endl;
    }
};

// Concrete Implementor
class RasterRenderer : public Renderer {
public:
    void renderCircle(float x, float y, float radius) override {
        std::cout << "Rendering circle as raster at (" << x << ", " << y << ") with radius " << radius << std::endl;
    }
};

// Abstraction
class Shape {
protected:
    Renderer& renderer;
public:
    Shape(Renderer& renderer) : renderer(renderer) {}
    virtual void draw() = 0;
    virtual ~Shape() = default;
};

// Refined Abstraction
class Circle : public Shape {
private:
    float x, y, radius;
public:
    Circle(Renderer& renderer, float x, float y, float radius)
        : Shape(renderer), x(x), y(y), radius(radius) {}

    void draw() override {
        renderer.renderCircle(x, y, radius);
    }
};

int main() {
    VectorRenderer vectorRenderer;
    RasterRenderer rasterRenderer;

    Circle vectorCircle(vectorRenderer, 5, 5, 3);
    Circle rasterCircle(rasterRenderer, 10, 10, 5);

    vectorCircle.draw();
    rasterCircle.draw();

    return 0;
}
