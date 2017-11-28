using System;

namespace Mancala
{
    class Program
    {
        static void Main(string[] args)
        {
            var myGame= new Game();

            myGame.GameMessage += MyGame_GameMessage;

            myGame.Start();

            Console.ReadLine();
        }

        private static void MyGame_GameMessage(string msg)
        {
            Console.WriteLine(msg);
            
        }
    }
}
