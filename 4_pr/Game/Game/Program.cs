using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var fabrics = new List<Fabric>
            {
                new EOFabric()
            };

            Console.WriteLine("Выберите номер игры");

            int i = 0;
            foreach (Fabric x in fabrics)
            {
                i++;
                Console.WriteLine(i.ToString()
                                  + ". "
                                  + x.Info);
            } //перебор игр 

            int SelectGame = int.Parse(Console.ReadLine());
            SelectGame--;

            if ((SelectGame < 0) || (SelectGame >= fabrics.Count))
            {
                while ((SelectGame < 0) || (SelectGame >= fabrics.Count()))
                {
                    Console.WriteLine("Некорректный ввод");
                    SelectGame = int.Parse(Console.ReadLine());
                    SelectGame--;
                }
            }

            Console.Clear();

            #region Player's data
            string nick;
            int balance;
            Console.WriteLine("Введите имя");
            nick = Console.ReadLine();
            Console.WriteLine("Введите стартовый баланс");
            balance = int.Parse(Console.ReadLine());
            #endregion

            Player player = new Player(nick, balance);

            IRunner runner = fabrics[SelectGame].GetGame(player);

            runner.RunGame();

            Console.Clear();

            runner.RunGame();
        }
    }
}
