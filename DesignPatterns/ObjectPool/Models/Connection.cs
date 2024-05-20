namespace ObjectPool.Models
{
    // Клас, що представляє об'єкт з'єднання з базою даних
    class Connection
    {
        public int ConnectionId { get; }

        public Connection(int connectionId)
        {
            ConnectionId = connectionId;
        }

        public void ExecuteQuery(string query)
        {
            Console.WriteLine($"Executing query '{query}' on connection {ConnectionId}");
        }
    }
}
