# Шаблони проектування

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
    Abstraction *-down-> Implementor
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
