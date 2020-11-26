using System;
using Xunit;
using Xunit.Sdk;
using Moq;
using Yahtzee.model;

namespace YahtzeeTests.model
{
    public class DieTest
    {
        [Fact]
        public void GetValueShouldReturnOne()
        {
            Random random = new Random();
            Die sut = new Die(random);

            var actual = sut.GetValue();
            Assert.Equal(1, actual);
        }

        [Fact]
        public void RollShouldChangeValueToTwo()
        {
            var mockR = new Mock<Random>();
            mockR.Setup(r => r.Next(1, 7)).Returns(2);
            var sut = new Die(mockR.Object);

            sut.Roll();

            var actual = sut.GetValue();
            Assert.Equal(2, actual);
        }

        [Fact]
        public void constructorShouldThrowWhenNoArg()
        {
            try
            {
                Die sut = new Die(null);
                throw new XunitException("constructor doesn't throw exception");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}