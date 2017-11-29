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
                //var p1 = new HumanPlayer("Alex");
                //p1.SelectBasket += P1_SelectBasket;
                var p1 = new StupidBot("AlexStupidBot");
                p1.SelectBasket += P2_SelectBasket1;


                var p2 = new StupidBot("VasyaStupidBot");
                p2.SelectBasket += P2_SelectBasket1;


                var myGame = new Game(p1,p2);

                myGame.GameMessage += MyGame_GameMessage;

                myGame.Start();
            }

            Console.ReadLine();
        }

        private static void P2_SelectBasket1(string name, int choice)
        {
            Console.WriteLine(string.Format("{0}, please choose basket: {1}", name, choice));
         //   Console.ReadLine();
        }

        private static void P2_SelectBasket(string name)
        {
            Console.Write(string.Format("{0}, please choose basket:", name));
        }

        private static int P1_SelectBasket(string name)
        {
            Console.Write(string.Format("{0}, please choose basket:", name));
            var numStr = Console.ReadLine();

            return int.Parse(numStr);
        }

        private static void MyGame_GameMessage(string msg)
        {
            Console.WriteLine(msg);
            
        }
    }
}
