using Buba.client;
using Buba.Game;
using Buba.Game.Nim;
using NimmspielProjekt.game.Nim.Player;
using NimmspielProjekt.game.Player;

namespace Buba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPlayer<int, int> human = new HumanPlayer();
            IPlayer<int, int> computerPlayer = new ComputerPlayer();


            NimGame game = new NimGame();
            game.AddPlayer(human);
            game.AddPlayer(computerPlayer);

            GameClient client = new GameClient(game);
            client.Go();
        }
    }
}
