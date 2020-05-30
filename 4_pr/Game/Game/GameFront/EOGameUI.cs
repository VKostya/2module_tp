using System;
using System.IO;

namespace Game
{
    public class EOGameUI
    {
        public void Menu(Player player)
        {
            Console.Clear();
            Console.WriteLine("Ваш баланс равен " + player.Balance.ToString());
            Console.WriteLine("\t\tИгра Чет-Нечет");
            Console.WriteLine("Нажмите [A] чтобы добавить очки к балансу");
            Console.WriteLine("Нажмите [W] чтобы снять очки с баланса");
            Console.WriteLine("Нажмите [P] чтобы начать игру");
            Console.WriteLine("Нажмите [D] чтобы посмотреть список игроков");
            Console.WriteLine("Нажмите [Q] чтобы выйти из игры");
        }

        public void GameMenu(Player player)
        {
            Console.Clear();
            Console.WriteLine("Your balance is {0:c}", player.Balance);
            Console.WriteLine("Press [E] for even or [O] for odd number or [Q] to quit and then enter your bet");
        }

        public void PlayersList()
        {
            Console.Clear();

            using (StreamReader sr = File.OpenText(EvenOddGame.path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.WriteLine("Press any key to go to menu");
            string exit = Console.ReadLine();
            return;
        }


    }
}
