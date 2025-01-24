using System;
using System.Collections.Generic;
using System.Linq;
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
        public int Steine { get; set; }
        public bool GameOver { get; set; }
        public NimGame()
        {
            GameOver = false;
            Steine = 23;
        }

        public void Play()
        {
            while (!GameOver)
            {
                PlayRound();
            }
        }

        private void PlayRound()
        {
            Spielerzug();
            Computerzug();
        }

        private void Computerzug()
        {
            int[] zuege = { 3, 1, 1, 2 };

            if (Steine < 1)
            {
                Console.WriteLine("Du Loser!");
                GameOver = true;
                return;
            }
            if (Steine == 1)
            {
                Console.WriteLine("Du hast nur Glueck gehabt!");
                Steine--;
                GameOver = true;
                return;
            }
            int zug = zuege[Steine%4];
            Console.WriteLine("Computer nimmt " + zug + " Steine");

            Steine -= zug;
        }

        private void Spielerzug()
        {
            int zug;
            while (true)
            {
                Console.WriteLine("Es gibt " + Steine + " Steine. Bitte nehmen Sie 1,2 oder 3!");
                zug = Int32.Parse(Console.ReadLine());
                if (zug >= 1 && zug <= 3) break;
                Console.WriteLine("Ungueltiger Zug");
            }

            Steine -= zug;
        }
    }
}
