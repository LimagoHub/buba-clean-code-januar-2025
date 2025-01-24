using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buba.Game;

namespace Buba.client
{
    public class GameClient
    {
        private IGame game;

        public GameClient(IGame game)
        {
            this.game = game;
        }

        public void Go()
        {
            game.Play();
        }
    }
}
