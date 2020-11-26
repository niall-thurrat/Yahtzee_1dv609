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
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        public void GetDiceShouldReturnDice(int diceCount, int expected)
        {
            var random = new Random();
            var mockDice = new List<Die>();

            for (int i = 0; i < diceCount; i++)
            {
                var mockDie = new Die(random);
                mockDice.Add(mockDie);
            }

            var sut = new Player(mockDice);
            var actual = sut.GetDice().Count;

            Assert.Equal(expected, actual);
        }
    }
}
