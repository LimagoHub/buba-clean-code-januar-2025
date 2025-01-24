using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimmspielProjekt.game.Player
{
    public interface IPlayer<TBOARD, TTURN>
    {
        string Name { get; }
        TTURN DoTurn(TBOARD board);
    }
}
