using Mancala.Players;
using System;

namespace Mancala
{
    public class Game
    {
        public IPlayer[] Players;

        private int[][] baskets = new []{ new int[7], new int[7]};
        public int Side;
        public int ActivePlayer=0;
        public int TurnCount = 0;
        public int DefaultBeansCount = 4;

        public int[][] Baskets { get => baskets; set => baskets = value; }

        public Game(IPlayer player1, IPlayer player2)
        {
            Players= new IPlayer[] { player1, player2};

            player1.Init(this, 0 , MoveBeans);
            player2.Init(this, 1, MoveBeans);
        }

        private void MoveBeans(int x)
        {
            x--;

            Side = ActivePlayer;

            var beans = Baskets[Side][x];
            Baskets[Side][x] = 0;
            var i = x ;
            while(beans>0)
            {
                i++;
                if (i == 7)
                {
                    i = 0;
                    Side = 1 - Side;
                }
                Baskets[Side][i]++;
                beans--;
            }

            if (i != 6 && baskets[Side][i] == 1 && Side == ActivePlayer && baskets[1 - ActivePlayer][5 - i] != 0)
            {
                baskets[ActivePlayer][6] += baskets[1 - ActivePlayer][5 - i];
                baskets[1 - ActivePlayer][5 - i] = 0;
                GameMessage("Capture!");
            }
                
            

            GameMessage(GetStateString());

            if (CheckEmptyBaskets(1 - ActivePlayer) && CheckEmptyBaskets(ActivePlayer))
                End();
            else
            {
                if (i == 6 && !CheckEmptyBaskets(ActivePlayer))
                    GameMessage("Free turn!");
                else
                {
                

                    if (CheckEmptyBaskets(1 - ActivePlayer))
                        GameMessage(string.Format("{0} moves again", Players[ActivePlayer].Name));
                    else
                        ActivePlayer = 1 - ActivePlayer;
                }

                Iteration();
            }
        }

        private void End()
        {
            GameMessage.Invoke(GetStateString());

            if (baskets[0][6] == baskets[1][6])
                GameMessage(string.Format("{0}[{1}]:{2}[{3}] — Draw!", Players[0].Name, baskets[0][6], Players[1].Name, baskets[1][6]));
            else
            {
                var winner = (baskets[0][6] > baskets[1][6]) ? 0 : 1;

                GameMessage(string.Format("{0}[{1}]:{2}[{3}] — {4} wins", Players[0].Name, baskets[0][6], Players[1].Name, baskets[1][6], Players[winner].Name));
            }
        }

        private bool CheckEmptyBaskets(int side)
        {
            int sum = 0;

            for (int i=0;i<6;i++)
            {
                sum += baskets[side][i];
            }

            return sum == 0;
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
            for(int i=0;i<2;i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Baskets[i][j] = DefaultBeansCount;
                }
            }
        }

        private string GetStateString()
        {
            var st = Environment.NewLine+
                     string.Format(@"{0} (|/) (;,,,;) (|/)", Players[1].Name) + Environment.NewLine +
                     string.Format("    #6  #5  #4  #3  #2  #1") + Environment.NewLine +
                     string.Format("    ({0}) ({1}) ({2}) ({3}) ({4}) ({5})", Baskets[1][5], Baskets[1][4], Baskets[1][3], Baskets[1][2], Baskets[1][1], Baskets[1][0]) + Environment.NewLine +
                     string.Format("({0})*************************({1})", Baskets[1][6], Baskets[0][6]) + Environment.NewLine +
                     string.Format("    ({0}) ({1}) ({2}) ({3}) ({4}) ({5})", Baskets[0][0], Baskets[0][1], Baskets[0][2], Baskets[0][3], Baskets[0][4], Baskets[0][5]) + Environment.NewLine +
                     string.Format("    #1  #2  #3  #4  #5  #6") + Environment.NewLine +
                     string.Format(@"{0}                     (\|) (;,,,;) (\|)", Players[0].Name) + Environment.NewLine;
            return st;
        }

        public delegate void GameMessageDelegate(string msg);
        public event GameMessageDelegate GameMessage;
    }
}