namespace Mancala.Players
{
    public class HumanPlayer : IPlayer
    {
        public HumanPlayer(string name) : base(name)
        {
        }

        public override void Move()
        {
            _moveCallback(SelectBasket.Invoke(Name));
        }

        public delegate int SelectBasketDelegate(string name);
        public event SelectBasketDelegate SelectBasket;
    }
}
