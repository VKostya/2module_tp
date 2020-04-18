using System;

namespace MyClass
{
    public delegate void ProcessMagazineDelegate(Magazine mag, DateTime dt);

    public class Magazine : Item, IPubs
    {
        public static event ProcessMagazineDelegate Subscribe = null;

        public bool IfSubs { get; set; }

        public void Subs()
        {
            IfSubs = true;
            if (Subscribe != null)
            {
                Subscribe(this, DateTime.Now);
            }
        }

        public override string ToString()
        {
            string bs = String.Format("\nЖурнал:\nТом: {0}\nНомер:{1}\n" +
                                      "Название: {2}\nГод выпуска: {3} \n" +
                                      "Статус подписки: {4}", Volume, Number,
                                                               Title, Year, IfSubs);
            return bs;
        }

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
        
    }
}
