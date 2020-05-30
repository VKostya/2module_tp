using System;
namespace Game
{
    public class EOFabric : Fabric
    {
        public EOFabric() 
        {
            Info = "Угадай чет/нечет";    
        }
        public string Info { get; set; }

        public IRunner GetGame(Player player) => new EvenOddGame(player, new EOGameUI());
    }
}
