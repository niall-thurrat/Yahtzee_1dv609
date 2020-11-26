using System;
using Xunit;
using Xunit.Sdk;
using Moq;
using Yahtzee.model;

namespace YahtzeeTests.model
{
    public class PlayerTest
    {
        [Fact]
        public void GetDiceShouldReturnADie()
        {
            Random random = new Random();
            var mockD = new Die(random);
            var player = new Player(mockD);

            var expected = mockD;
            var actual = player.GetDice();
            
            Assert.Equal(expected, actual);
        }
    }
}
