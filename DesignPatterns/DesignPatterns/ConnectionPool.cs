using ObjectPool.Models;

namespace DesignPatterns
{
    // Клас, що представляє пул об'єктів для керування з'єднаннями з базою даних
    class ConnectionPool
    {
        private int maxConnections;
        private Queue<Connection> connections;

        public ConnectionPool(int maxConnections)
        {
            this.maxConnections = maxConnections;
            connections = new Queue<Connection>();
            InitializePool();
        }

        private void InitializePool()
        {
            for (int i = 1; i <= maxConnections; i++)
            {
                Connection connection = new Connection(i);
                connections.Enqueue(connection);
            }
        }

        public Connection GetConnection()
        {
            if (connections.Count == 0)
            {
                Console.WriteLine("All connections are busy. Please try again later.");
                return null;
            }
            return connections.Dequeue();
        }

        public void ReleaseConnection(Connection connection)
        {
            connections.Enqueue(connection);
        }
    }
}
