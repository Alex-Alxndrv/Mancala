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
                var p2 = new HumanPlayer("Vasya");
                var myGame = new Game(p1,p2);

                myGame.GameMessage += MyGame_GameMessage;

                myGame.Start();

            }






            

            Console.ReadLine();
        }

        private static void MyGame_GameMessage(string msg)
        {
            Console.WriteLine(msg);
            
        }
    }
}
