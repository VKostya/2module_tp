using System;
namespace Game
{
    public interface Fabric
    {
        string Info { get; set; }

        IRunner GetGame(Player player);
    }
}
