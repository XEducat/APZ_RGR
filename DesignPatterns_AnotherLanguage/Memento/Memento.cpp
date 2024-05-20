#include <iostream>
#include <string>
#include <vector>

// Memento
class Memento {
public:
    Memento(const std::string& state) : state(state) {}
    std::string getState() const { return state; }
private:
    std::string state;
};

// Originator
class Originator {
public:
    void setState(const std::string& state) {
        this->state = state;
        std::cout << "State set to: " << state << std::endl;
    }

    std::string getState() const {
        return state;
    }

    Memento saveStateToMemento() {
        return Memento(state);
    }

    void getStateFromMemento(const Memento& memento) {
        state = memento.getState();
        std::cout << "State restored to: " << state << std::endl;
    }

private:
    std::string state;
};

// Caretaker
class Caretaker {
public:
    void addMemento(const Memento& memento) {
        mementos.push_back(memento);
    }

    Memento getMemento(int index) {
        return mementos.at(index);
    }

private:
    std::vector<Memento> mementos;
};

int main() {
    Originator originator;
    Caretaker caretaker;

    originator.setState("State1");
    caretaker.addMemento(originator.saveStateToMemento());

    originator.setState("State2");
    caretaker.addMemento(originator.saveStateToMemento());

    originator.setState("State3");
    originator.getStateFromMemento(caretaker.getMemento(0));

    return 0;
}