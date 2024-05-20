using DesignPatterns;
using ObjectPool.Models;

class Program
{
    static void Main(string[] args)
    {
        // Приклад використання
        ConnectionPool pool = new ConnectionPool(maxConnections: 5);

        // Отримання підключення з пула та виконання запиту
        Connection connection1 = pool.GetConnection();
        if (connection1 != null)
        {
            connection1.ExecuteQuery("SELECT * FROM Users");
            // Повернення підключення назад у пул
            pool.ReleaseConnection(connection1);
        }

        // Отримання ще одного підключення та виконання запиту
        Connection connection2 = pool.GetConnection();
        if (connection2 != null)
        {
            connection2.ExecuteQuery("SELECT * FROM Products");
            // Повернення підключення назад у пул
            pool.ReleaseConnection(connection2);
        }
    }
}
