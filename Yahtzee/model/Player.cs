namespace Yahtzee.model
{
    public class Player
    {
        private Die _die;

        public Player(Die die)
        {
            _die = die;
        }

        public Die GetDice() => _die;
    }
}
