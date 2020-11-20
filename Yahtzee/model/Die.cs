using System;

namespace Yahtzee
{
    public class Die
    {
        private Random _random;

        private int _value;

        public Die(Random random)
        {
            _random = random;
            _value = 1;
        }

        public int GetValue() => _value;

        public void Roll()
        {
            _value = _random.Next(1, 7);
        }
    }
}
