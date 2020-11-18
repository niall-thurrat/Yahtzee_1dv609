using System;
using Xunit;
using Yahtzee;

namespace YahtzeeTests
{
    public class DieTest
    {
        [Fact]
        public void GetValueShouldReturnOne()
        {
            Die d = new Die();

            var actual = d.GetValue();
            Assert.Equal(1, actual);
        }
    }
}