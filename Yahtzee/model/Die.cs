using System;

namespace Yahtzee
{
    public class Die
    {
        private static Random _random = new Random();

        public Die() => _value = _random.Next(1, 7);

        public Die(int value) => _value = value;

        public int _value { get; }

        public int Roll()
        {
            return _value;
        }
    }
}
