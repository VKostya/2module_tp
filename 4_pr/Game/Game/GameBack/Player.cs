using System;
namespace Game
{
    public class Player
    {
        private int balance;
        private string nickname;
        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if ((value >= 10000) || (value < 0))
                {
                    while ((value >= 10000) || (value < 0))
                    {
                        Console.WriteLine("Баланс должен быть не больше 9999");
                        value = int.Parse(Console.ReadLine());
                    }
                }
                balance = value;
            } 
        }

        public string NickName {
            get 
            {
                return nickname;
            }
            set 
            {
                if (value.Length > 15)
                {
                    while (value.Length > 15)
                    {
                        Console.WriteLine("Имя должно быть не длиннее 15 символов");
                        value = Console.ReadLine();
                    }
                }
                nickname = value;
            } 
        }

        public Player(string nick, int balance)
        {
            NickName = nick;
            Balance = balance;
        }

        public bool CheckBalance()
        {
            return Balance > 0;
        }

        public void ChangeBalance(int changer)
        {
            Balance -= changer;
        }
        public bool CheckWin(int key, int number)
        {
            return ((number % 2) - key == 0);
        }

        public void AWChangeBalance(int key)
        {
            int m = (int)uint.Parse(Console.ReadLine());
            Console.Clear();
            if (Balance - (key * m) > 0 && Balance - key*m <= 9999)
            {
                ChangeBalance((key * m));
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Успешно");
                System.Threading.Thread.Sleep(1250);
            }
            else
            {
                Console.WriteLine("Нельзя снять/положить такую сумму");
            }
        }
    }
}
