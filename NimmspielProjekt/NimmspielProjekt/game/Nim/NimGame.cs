using NimmspielProjekt.game;

namespace Buba.Game.Nim
{

    /// <summary>
    /// 
    /// </summary>
    public class NimGame : AbstractGame<int,int>
    {
   

        public NimGame()
        {

            Board = 23;
        }
      

        // Implementierungssumpf ----------------------------------------------------

        protected override void UpdateBoard()// Operation
        {
            Board -= Turn;
        }
        protected override bool IsTurnValid()
        {
            return Turn >= 1 && Turn <= 3;
        }
        protected override bool GameOver => Board <= 0 || Players.Count == 0;
    }
}
