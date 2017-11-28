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

        public Game GameInstance { get; set; }

        public void Init(Action<int> callback)
        {
            _moveCallback = callback;
        }

        internal Action<int> _moveCallback;

        public abstract void Move();
    }
}
