using System;

namespace MyClass
{
    public class Magazine : Item
    {
        public override void Return()
        {
            taken = true;
        }
        public override void Print()
        {
            Console.WriteLine(this);
            base.Print();
        }

        public Magazine(string volume, string title, int
                    number, int year, long invNumber, bool taken)
                                        : base(invNumber, taken)
        {
            Volume = volume;
            Title = title;
            Number = number;
            Year = year;
        }

        public Magazine() : base()
        { }

        public string Volume { get; set; } // том
        public int Number { get; set; } // номер
        public string Title { get; set; } // название
        public int Year { get; set; } // год выпуска

        public override string ToString()
        {
            string bs = String.Format("\nЖурнал:\nТом: {0}\nНомер: {1}"+
                "\nНазвание: {2} \nГод выпуска: {3}", Volume, Number, Title, Year);
            return bs;
        }

        
    }
}
