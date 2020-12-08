using Xunit;
using ProjectEuler.Models;
using System.Collections.Generic;

namespace ProjectEuler.Tests
{
    // Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
    // 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
    // By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
    public class Problem2Tests
    {
        [Theory]
        [InlineData(0, 1, 1)]
        [InlineData(1, 1, 2)]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 5)]
        [InlineData(3, 5, 8)]
        [InlineData(5, 8, 13)]
        [InlineData(8, 13, 21)]
        [InlineData(13, 21, 34)]
        [InlineData(21, 34, 55)]
        [InlineData(34, 55, 89)]
        public void GetNextFibonacciElement(int previous, int number, int expected)
        {      
            //Assert
            Assert.Equal(expected, number.GetNextFibonacciElement(previous));
        }
        
        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, false)]
        [InlineData(5, false)]
        [InlineData(8, true)]
        [InlineData(13, false)]
        [InlineData(21, false)]
        [InlineData(34, true)]
        [InlineData(55, false)]
        [InlineData(89, false)]
        public void IsEven(int number, bool expected)
        {      
            Assert.Equal(expected, number.IsEven());
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 2)]
        [InlineData(3, 2)]
        [InlineData(5, 2)]
        [InlineData(8, 10)]
        [InlineData(13, 10)]
        [InlineData(21, 10)]
        [InlineData(34, 44)]
        [InlineData(55, 44)]
        [InlineData(89, 44)]
        [InlineData(4000000, 4613732)]
        public void SumEvenValuedFibonacciNumbersUntil_GivenLimit(int limit, int expected)
        {      
            Assert.Equal(expected, Problem2.SumEvenValuedFibonacciNumbersUntil(limit));
        }
    }
}