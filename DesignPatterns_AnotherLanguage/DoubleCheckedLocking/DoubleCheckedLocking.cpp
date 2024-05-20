#include <iostream>
#include <mutex>
#include <thread>

class Singleton {
public:
    static Singleton* getInstance() {
        if (instance == nullptr) {
            std::lock_guard<std::mutex> lock(mutex_);
            if (instance == nullptr) {
                instance = new Singleton();
            }
        }
        return instance;
    }

    void doSomething() {
        std::cout << "Doing something!" << std::endl;
    }

private:
    Singleton() = default;
    ~Singleton() = default;

    Singleton(const Singleton&) = delete;
    Singleton& operator=(const Singleton&) = delete;

    static Singleton* instance;
    static std::mutex mutex_;
};

Singleton* Singleton::instance = nullptr;
std::mutex Singleton::mutex_;

void threadFunction() {
    Singleton* singleton = Singleton::getInstance();
    singleton->doSomething();
}

int main() {
    std::thread t1(threadFunction);
    std::thread t2(threadFunction);

    t1.join();
    t2.join();

    return 0;
}
