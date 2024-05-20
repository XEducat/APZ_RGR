#include <iostream>
#include <vector>

class PooledObject {
public:
    void use() {
        std::cout << "Using pooled object" << std::endl;
    }
};

class ObjectPool {
public:
    PooledObject* acquireObject() {
        if (availableObjects.empty()) {
            std::cout << "Creating new pooled object" << std::endl;
            return new PooledObject();
        }
        else {
            std::cout << "Reusing existing pooled object" << std::endl;
            PooledObject* obj = availableObjects.back();
            availableObjects.pop_back();
            return obj;
        }
    }

    void releaseObject(PooledObject* obj) {
        obj->reset();
        availableObjects.push_back(obj);
    }

    ~ObjectPool() {
        for (PooledObject* obj : availableObjects) {
            delete obj;
        }
    }

private:
    std::vector<PooledObject*> availableObjects;
};

int main() {
    ObjectPool pool;

    // Acquire objects from the pool
    PooledObject* obj1 = pool.acquireObject();
    PooledObject* obj2 = pool.acquireObject();

    // Use objects
    obj1->use();
    obj2->use();

    // Release objects back to the pool
    pool.releaseObject(obj1);
    pool.releaseObject(obj2);

    // Acquire objects again to see reuse
    PooledObject* obj3 = pool.acquireObject();
    PooledObject* obj4 = pool.acquireObject();

    obj3->use();
    obj4->use();

    // Release objects back to the pool
    pool.releaseObject(obj3);
    pool.releaseObject(obj4);

    return 0;
}
