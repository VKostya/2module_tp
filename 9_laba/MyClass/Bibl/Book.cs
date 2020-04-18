using System;
namespace MyClass
{
    public class Book: Item, IPr
    {
        public void SetPrice(double price)
        {
            Price = price;
        }

        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }

        public override string ToString()
        {
            string bs = String.Format("\nКнига:\nАвтор: {0}\nНазвание: {1}\n" +                                        "Год издания: {2}\n{3}стр.\nСтоимость аренды: {4}\n" +                                        "Издательство{5}", Author, Title, Year, Pages,
                                        Book.price, Publisher.ToString());
            return bs;
        }

        public string Author { get; set; } // автор
        public string Title { get; set; } // название
        public Publisher Publisher { get; set; } // издательство
        public int Pages { get; set; } // кол-во страниц
        public int Year { get; set; } // год издания

        public Book(string author, string title, Publisher publisher, int
                   pages, int year, long invNumber, bool taken)
                                       : base(invNumber, taken)
        {
            this.Author = author;
            this.Title = title;
            this.Publisher = publisher;
            this.Pages = pages;
            this.Year = year;
        }

        public bool returnSrok { get; private set; }
        public void ReturnSrok()
        {
            returnSrok = true;
        }
        public override void Return()
        {
            if (returnSrok == true) taken = true;
            else
                taken = false;
        }

        public override void Print()
        {
            Console.WriteLine(this);
            base.Print();
        }

       
        private static double price = 9;
        public static double Price {
            get { return price; } set { if(value > 9) price = value; }
        }

        public Book() { }
        static Book() { Price = 9; }
        public Book(string author, string title, Publisher publisher, int pages, int year)
        {
            this.Author = author; this.Title = title;
            this.Publisher = publisher; this.Pages = pages; this.Year = year;
        }
        public Book(string author, string title)
        {
            this.Author = author;
            this.Title = title;
        }

        public void SetBook(string author, string title, Publisher publisher,
                            int pages, int year)
        {
            this.Author = author; this.Title = title;
            this.Publisher = publisher; this.Pages = pages; this.Year = year;
        }

        
    }
}
