using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimmspielProjekt.game.Player
{
    public abstract class AbstractGamePlayer<BOARD, TURN>: IPlayer<BOARD, TURN>
    {
        protected AbstractGamePlayer()
        {
            Name = this.GetType().Name;
        }
        protected AbstractGamePlayer(string name)
        {
            Name = name;
        }

        public virtual string Name { get; }
        
        public abstract TURN DoTurn(BOARD board);
    }
}
