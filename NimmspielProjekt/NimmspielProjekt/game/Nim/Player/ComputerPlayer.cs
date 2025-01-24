using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NimmspielProjekt.game.Nim.Player
{
    public class ComputerPlayer: AbstractNimGamePlayer
    {
        private readonly int[] _zuege = { 3, 1, 1, 2 };
        public ComputerPlayer():base()
        {
        }

        public ComputerPlayer(string name) : base(name)
        {
        }

        public override int DoTurn(int stones)
        {
            int zug = _zuege[stones % 4];
            Console.WriteLine("Computer nimmt " + zug + " Steine");
            return zug;
        }
    }
}
