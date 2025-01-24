using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NimmspielProjekt.game.Nim.Player
{
    public class HumanPlayer: AbstractNimGamePlayer
    {
        public HumanPlayer():base()
        {
        }

        public HumanPlayer(string name) : base(name)
        {
        }

        public override int DoTurn(int stones)
        {
            Console.WriteLine("Es gibt " + stones + " Steine. Bitte nehmen Sie 1,2 oder 3!");
            return Int32.Parse(Console.ReadLine());
        }
    }
}
