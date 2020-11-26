using System;

namespace Yahtzee.model
{
    public class Die
    {
        private Random _random;

        private int _value;

        public Die(Random random)
        {
            if (random == null)
                throw new ArgumentNullException();

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
