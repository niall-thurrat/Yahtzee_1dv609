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
            var actual = Die.GetValue();
            Assert.Equal(1, actual);
        }
    }
}