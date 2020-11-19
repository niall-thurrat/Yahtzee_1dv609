using Xunit;
using Yahtzee;

namespace YahtzeeTests
{
    public class DieTest
    {
        [Fact]
        public void GetValueShouldReturnOne()
        {
            Die sut = new Die(1);

            var actual = sut._value;
            Assert.Equal(1, actual);
        }

        [Fact]
        public void RollShouldReturnOne()
        {
            Die sut = new Die(1);

            var actual = sut.Roll();
            Assert.Equal(1, actual);
        }
    }
}
