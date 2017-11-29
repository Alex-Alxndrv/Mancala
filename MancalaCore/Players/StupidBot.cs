using System;

namespace Mancala.Players
{
    public class StupidBot : IPlayer
    {
        public StupidBot(string name) : base(name)
        {
        }

        public override void Move()
        {
            var choice = new Random().Next(6) ;

            while(_gameInstance.Baskets[_number][choice]==0)
                choice = new Random().Next(6) ;

            SelectBasket(Name, choice+1);

            _moveCallback(choice+1);
        }

        public delegate void SelectBasketDelegate(string name, int choice);
        public event SelectBasketDelegate SelectBasket;
    }
}
