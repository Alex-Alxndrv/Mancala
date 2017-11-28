using System;
using Mancala.Players;

namespace Mancala
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mancala! ");

            //while(true)
            {
                var p1 = new HumanPlayer("Alex");
                p1.SelectBasket += P1_SelectBasket;
                var p2 = new HumanPlayer("Vasya");
                p2.SelectBasket += P1_SelectBasket;
                var myGame = new Game(p1,p2);

                myGame.GameMessage += MyGame_GameMessage;

                myGame.Start();
            }
            

            Console.ReadLine();
        }

        private static int P1_SelectBasket(string name)
        {
            Console.WriteLine(string.Format("{0}, please choose basket", name));
            var numStr = Console.ReadLine();

            return int.Parse(numStr);
        }

        private static void MyGame_GameMessage(string msg)
        {
            Console.WriteLine(msg);
            
        }
    }
}
