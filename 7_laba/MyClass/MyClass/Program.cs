using System;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publ = new Publisher("Наука и жизнь", "nauka@mail.ru", 1234,
                                            new DateTime(2014, 12, 14));
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", publ,
                                1234, 2013, 101, true);
            Console.WriteLine(b2);
        }
    }
}
