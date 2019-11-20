using System;
using Xunit;

namespace Aircoin
{
    public class AircoinTest
    {
        [Fact]
        public void shouldReturnAmountOfAircoin()
        {
            //Given an aircoin
            int amount = 1;
            Aircoin coin = new Aircoin(amount);
            //When get amount of the aircoin
            int fetchedAmount = coin.amount;
            //Then return the amount of the aircoin
            Assert.Equal(amount, fetchedAmount);
        }
        [Fact]
          public void shouldThrowErrorWhenCreateAircoinWithAmountExceedLimit()
        {
            //Given an aircoin
            int invalidAmount = 2000000001;
            //When try to create an aircoin with amount exceed 0.2 billion
            //Then throw error
            Assert.Throws<NotValidAmountException>(() => new Aircoin(invalidAmount));
        }
        [Fact]
        public void shouldThrowErrorWhenCreateAircoinWithAmountLessThanZero()
        {
            //Given an aircoin
            int negativeAmount = -1;
            //When try to create an aircoin with amount exceed 0.2 billion
            //Then throw error
            Assert.Throws<NotValidAmountException>(() => new Aircoin(negativeAmount));
        }
        [Fact]
        public void shouldReturnTrueWhenComparingTwoAircoinWithSameAmount()
        {
            //Given two aircoin with the same amount
            int amount = 100;
            Aircoin coinA = new Aircoin(amount);
            Aircoin coinB = new Aircoin(amount);
            //When compare them
            bool comparationResult = coinA.hasSameAmountWith(coinB); 
            //Then return true
            Assert.True(comparationResult);
        }
        [Fact]
        public void shouldReturnFalseWhenComparingTwoAircoinWithDifferentAmount()
        {
            //Given two aircoin with the different amount
            int amount = 100;
            int differentAmount = 101;
            Aircoin coinA = new Aircoin(amount);
            Aircoin coinB = new Aircoin(differentAmount);
            //When compare them
            bool comparationResult = coinA.hasSameAmountWith(coinB);
            //Then return false
            Assert.False(comparationResult);
        }
    }
}
