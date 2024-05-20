# Шаблони проектування
[Пул об'єктів](#object-pool-пул-обєктів)

## Object Pool (Пул об'єктів)
### Опис:
Шаблон Object Pool використовується для підтримки пула об'єктів, який забезпечує готовість до використання та перевикористання об'єктів замість їх створення і знищення.

### Графічне подання:
#### Статична модель (діаграма класів):
```mermaid
classDiagram
    class ObjectPool {
        - availableObjects: List<Object>
        - inUseObjects: List<Object>
        + getObject(): Object
        + releaseObject(object: Object)
    }
```
#### Динамічна модель (діаграма взаємодії):
```
sequenceDiagram
    participant Client
    participant Abstraction
    participant Implementor
    Client->>Abstraction: operation()
    Abstraction->>Implementor: operationImpl()
```

## Bridge (Міст)
### Опис:
Шаблон Bridge використовується для розділення абстракції від її реалізації, так що обидва можуть змінюватись незалежно.

### Графічне подання:
#### Статична модель (діаграма класів):
```mermaid
classDiagram
    class Abstraction {
        + implementor: Implementor
        + operation()
    }
    class RefinedAbstraction {
        + operation()
    }
    class Implementor {
        + operationImpl()
    }
    class ConcreteImplementorA {
        + operationImpl()
    }
    class ConcreteImplementorB {
        + operationImpl()
    }
    Abstraction <|-- RefinedAbstraction
    Abstraction -- Implementor
    Implementor <|.. ConcreteImplementorA
    Implementor <|.. ConcreteImplementorB
```

#### Динамічна модель (діаграма взаємодії):
```
sequenceDiagram
    participant Client
    participant Abstraction
    participant Implementor
    Client->>Abstraction: operation()
    Abstraction->>Implementor: operationImpl()
```

## Memento (Моменто)
### Опис:
Шаблон Memento використовується для зберігання стану об'єкту таким чином, щоб в майбутньому можна було відновити цей стан без розкриття внутрішньої структури об'єкта.

### Графічне подання:
#### Статична модель (діаграма класів):
```mermaid
classDiagram
    class Originator {
        - state
        + createMemento(): Memento
        + restoreFromMemento(memento: Memento)
    }
    class Memento {
        - state
        + getState()
    }
    class Caretaker {
        - mementos: List<Memento>
        + addMemento(memento: Memento)
        + getMemento(index: int): Memento
    }
    Originator *-- Memento
    Caretaker o-- Memento
```

#### Динамічна модель (діаграма взаємодії):
```
sequenceDiagram
    participant Client
    participant Originator
    participant Memento
    participant Caretaker
    Client->>Originator: createMemento()
    Originator->>Memento: getState()
    Originator->>Caretaker: addMemento(Memento)
    Client->>Caretaker: getMemento(index)
    Caretaker->>Memento: getState()
    Caretaker->>Originator: restoreFromMemento(Memento)
```

## Double Checked Locking (Подвійна перевірка блокування)
### Опис:
Шаблон Double Checked Locking використовується для оптимізації доступу до глобальних ресурсів шляхом перевірки блокування перед введенням в критичну секцію.

### Графічне подання:
#### Статична модель (діаграма класів):
```mermaid
classDiagram
    class Singleton {
        - static instance: Singleton
        + static getInstance(): Singleton
    }
```

#### Динамічна модель (діаграма взаємодії):
```
sequenceDiagram
    participant Client
    participant Singleton
    Client->>Singleton: getInstance()
```
