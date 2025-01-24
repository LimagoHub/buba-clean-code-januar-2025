using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NimmspielProjekt.game.Player;

namespace NimmspielProjekt.game.Nim.Player
{
    public abstract class AbstractNimGamePlayer: AbstractGamePlayer<int,int>
    {
        protected AbstractNimGamePlayer():base()
        {
           
        }
        protected AbstractNimGamePlayer(string name):base (name)
        {
           
        }

       
        
        
    }
}
