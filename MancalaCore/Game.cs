using Mancala.Players;
using System;

namespace Mancala
{
    

    public class Game
    {
        public IPlayer[] Players;

        public int[] Baskets = new int[14];

        public int ActivePlayer=0;
        public int TurnCount = 0;
        public int DefaultBeansCount = 4;

        public Game(IPlayer player1, IPlayer player2)
        {
            Players= new IPlayer[] { player1, player2};

            player1.Init(P1Turn);
            player2.Init(P2Turn);
        }

        private void P1Turn(int x)
        {

            
        }

        private void P2Turn(int x)
        {

        }

        private void MoveBeans(int x)
        {
            
        }

        public void Start()
        {
            GameMessage.Invoke("Game started!");

            ActivePlayer = new Random().Next(2);

            ResetBaskets();
            GameMessage.Invoke(GetStateString());
            GameMessage.Invoke(string.Format("Player {0} does first turn", Players[ActivePlayer].Name));

            Iteration();
        }

        private void Iteration()
        {
            Players[ActivePlayer].Move();

        }


        


        private void ResetBaskets()
        {
            for(int i=0;i<6;i++)
            {
                Baskets[i] = DefaultBeansCount;
            }

            for (int i = 7; i < 13; i++)
            {
                Baskets[i] = DefaultBeansCount;
            }
        }

        private string GetStateString()
        {
            var st = string.Format("    ({0}) ({1}) ({2}) ({3}) ({4}) ({5})", Baskets[12], Baskets[11], Baskets[10], Baskets[9], Baskets[8], Baskets[7]) + Environment.NewLine +
                     string.Format("({0})*************************({1})", Baskets[13],Baskets[6]) + Environment.NewLine +
                     string.Format("    ({0}) ({1}) ({2}) ({3}) ({4}) ({5})", Baskets[0], Baskets[1], Baskets[2], Baskets[3], Baskets[4], Baskets[5]);
            return st;
        }

        public delegate void GameMessageDelegate(string msg);
        public event GameMessageDelegate GameMessage;

        


    }
}