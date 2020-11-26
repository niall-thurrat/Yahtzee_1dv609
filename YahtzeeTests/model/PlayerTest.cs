using System;
using Xunit;
using Xunit.Sdk;
using Moq;
using Yahtzee.model;
using System.Collections.Generic;

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

        [Fact]
        public void GetDiceShouldReturnTwoDie()
        {
            var random = new Random();
            var mockDice = new List<Die>();

            for (int i = 0; i < 2; i++)
            {
                var mockDie = new Die(random);
                mockDice.Add(mockDie);
            }

            var sut = new Player(mockDice);

            var actual = sut.GetDice().Count;
            
            Assert.Equal(2, actual);
        }
    }
}
