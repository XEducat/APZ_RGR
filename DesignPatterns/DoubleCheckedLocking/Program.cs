namespace DoubleCheckedLocking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Використання Singleton через метод GetInstance
            Singleton singleton1 = Singleton.GetInstance();
            singleton1.DisplayMessage();

            // Перевірка на те, що отримуємо той самий екземпляр
            Singleton singleton2 = Singleton.GetInstance();
            Console.WriteLine(ReferenceEquals(singleton1, singleton2)); // Виведе true

            Console.ReadLine();
        }
    }
}
