using System;
using Xunit;

namespace Aircoin
{
    public class Aircoin
    {
        [Fact]
        public void shouldReturnAmountOfAircoin()
        {
            //Given an aircoin
            //When get amount of the aircoin
            //Then return the amount of the aircoin
        }
        [Fact]
        public void shouldThrowErrorWhenCreateAircoinWithAmountExceedLimit()
        {
            //Given an aircoin
            //When try to create an aircoin with amount exceed 0.2 billion
            //Then throw error
        }
        [Fact]
        public void shouldThrowErrorWhenCreateAircoinWithAmountLessThanZero()
        {
            //Given an aircoin
            //When try to create an aircoin with amount exceed 0.2 billion
            //Then throw error
        }
        [Fact]
        public void shouldReturnTrueWhenComparingTwoAircoinWithSameAmount()
        {
            //Given two aircoin with the same amount
            //When compare them
            //Then return true
        }
        [Fact]
        public void shouldReturnFalseWhenComparingTwoAircoinWithDifferentAmount()
        {
            //Given two aircoin with the different amount
            //When compare them
            //Then return false
        }
    }
}
