using Xunit;
using ProjectEuler.Models;
using System.Collections.Generic;

namespace ProjectEuler.Tests
{
    // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    // Find the sum of all the multiples of 3 or 5 below 1000.
    public class Problem1Tests
    {
        [Theory]
        [InlineData(10, 23, 3, 5)]
        [InlineData(1000, 233168, 3, 5)]
        public void SumNaturalNumbersMultipleOfGivenBelowGiven_ResultsExpectedSum(int below, int expected, params int[] multiple)
        {      
            //Act
            var actual = Problem1.SumNaturalNumbersMultipleOfGivenBelowGiven(below, multiple);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(GetDataForNaturalNumbersLists))]
        public void NaturalNumbers_BelowGivenNumber(int below, IEnumerable<int> expected)
        {
            //Act
            var result = Problem1.GetNaturalNumbersBelow(below);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(GetDataForMultiples))]
        public void IsMultipleOfAny(int number, bool expected, params int[] multiple)
        {
            //Act
            bool result = number.IsMultipleOfAny(multiple);

            //Assert
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> GetDataForNaturalNumbersLists =>
            new List<object[]>
            {  
                new object[] {10, new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9}},
                new object[] {9, new int[]{1, 2, 3, 4, 5, 6, 7, 8}},
                new object[] {5, new int[]{1, 2, 3, 4}},
                new object[] {22, new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21}},
                new object[] {1, new int[]{}},
                new object[] {2, new int[]{1}}
            };

        public static IEnumerable<object[]> GetDataForMultiples =>
            new List<object[]>
            {  
                new object[] { 3,  true,  3     },
                new object[] { 6,  true,  3     },
                new object[] { 9,  true,  3     },
                new object[] { 0,  true,  3     },
                new object[] { 12, true,  3     },
                new object[] { 5,  true,  5     },
                new object[] { 0,  true,  5     },
                new object[] { 10, true,  5     },
                new object[] { 15, true,  5     },
                new object[] { 20, true,  5     },
                new object[] { 15, true,  3, 5  },
                new object[] { 6,  true,  3, 5  },
                new object[] { 1,  false, 3     },
                new object[] { 2,  false, 3     },
                new object[] { 4,  false, 3     },
                new object[] { 14, false, 3     },
                new object[] { 1,  false, 5     },
                new object[] { 2,  false, 5     },
                new object[] { 4,  false, 5     },
                new object[] { 14, false, 5     },
                new object[] { 14, false, 3, 5  }
            };
    }
}
