using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Buba.Game;

namespace Buba.Game.Nim
{

    /// <summary>
    /// 
    /// </summary>
    public class NimGame : IGame
    {
        private int Steine { get; set; }

        private bool GameOver => Steine <= 0;

        private int zug;

        public NimGame()
        {
            zug = 0;
            Steine = 23;
        }

        public void Play()
        {
            while (!GameOver)
            {
                PlayRound();
            }
        }

        private void PlayRound()// Integration
        {
            Spielerzug();
            Computerzug();
        }

        private void Computerzug()// 
        {
            if (GameOver) return;

            int[] zuege = { 3, 1, 1, 2 };
            
          
            zug = zuege[Steine%4];
            Console.WriteLine("Computer nimmt " + zug + " Steine");


            terminateTurn("Computer");
        }

        private void Spielerzug()
        {
            if (GameOver) return;
            
            while (true)
            {
                Console.WriteLine("Es gibt " + Steine + " Steine. Bitte nehmen Sie 1,2 oder 3!");
                zug = Int32.Parse(Console.ReadLine());
                if (zug >= 1 && zug <= 3) break;
                Console.WriteLine("Ungueltiger Zug");
            }

            terminateTurn( "Mensch");
        }

        private void terminateTurn( string spielername)
        {
            Steine -= zug;
            if (GameOver)
                Console.WriteLine(spielername + " hat verloren");
        }
    }
}
