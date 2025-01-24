using Buba.client;
using Buba.Game;
using Buba.Game.Nim;

namespace Buba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IGame game = new NimGame();
            GameClient client = new GameClient(game);
            client.Go();
        }
    }
}
