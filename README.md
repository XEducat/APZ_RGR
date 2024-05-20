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

#### Статична модель (діаграма класів):
```mermaid
classDiagram
sequenceDiagram
    participant Client
    participant ObjectPool
    Client->>ObjectPool: getObject()
    ObjectPool->>Client: Object
    Client->>ObjectPool: releaseObject(Object)
```
