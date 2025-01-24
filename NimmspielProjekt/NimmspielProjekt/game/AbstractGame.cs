using Buba.Game;
using NimmspielProjekt.game.Player;

namespace NimmspielProjekt.game
{
    public abstract class AbstracGame<BOARD,TURN>: IGame

    {
        protected IList<IPlayer<BOARD, TURN>> Players { get; } = new List<IPlayer<BOARD, TURN>>();

        protected IPlayer<BOARD, TURN> CurrentPlayer { get; private set; }


        protected BOARD Board { get; set; }

        protected TURN Turn { get; set; }

        public void AddPlayer(IPlayer<BOARD, TURN> player)
        {
            Players.Add(player);
        }
        public void RemovePlayer(IPlayer<BOARD, TURN> player)
        {
            Players.Remove(player);
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
            foreach (var player in Players)
            {
                CurrentPlayer = player;
                PlaySingleTurn();
            }

        }
        private void PlaySingleTurn()
        {
            if (GameOver) return;

            DoCurrentPlayersTurn();

            TerminateTurn();
        }
        private void TerminateTurn()// Integration
        {
            UpdateBoard();
            PrintGameoverMessageIfGameIsOver();
        }

        private void PrintGameoverMessageIfGameIsOver() // Operation
        {
            if (GameOver)
                Console.WriteLine(CurrentPlayer.Name + " hat verloren");
        }

        private void DoCurrentPlayersTurn()
        {
            do
            {
                Turn = CurrentPlayer.DoTurn(Board);
            } while (UserTurnIsNotValid());
        }



        private bool UserTurnIsNotValid()
        {
            if (IsTurnValid()) return false;
            Console.WriteLine("Ungueltiger Zug");
            return true;

        }


        //--------------------------------------------------------
        protected abstract void UpdateBoard();
        protected abstract bool IsTurnValid();
        protected abstract bool GameOver { get; }
    }
}
