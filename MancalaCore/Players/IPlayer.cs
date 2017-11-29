using System;

namespace Mancala.Players
{
    public abstract class IPlayer
    {
        public IPlayer(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        internal Game _gameInstance { get; set;}
        internal int _number;

        public void Init(Game game, int number, Action<int> callback)
        {
            _moveCallback = callback;
            _gameInstance = game;
            _number = number;
        }

        internal Action<int> _moveCallback;

        public abstract void Move();
    }
}
