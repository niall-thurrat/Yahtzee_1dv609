using System.Collections.Generic;

namespace Yahtzee.model
{
    public class Player
    {
        private List<Die> _dice = new List<Die>();

        public Player(List<Die> dice)
        {
            _dice = dice;
        }

        public List<Die> GetDice() => _dice;
    }
}
