﻿using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Models
{
    public static class Problem1
    {
        public static IEnumerable<int> GetNaturalNumbersBelow(int below) => Enumerable.Range(1, below - 1);

        public static object SumNaturalNumbersMultipleOfGivenBelowGiven(int below, params int[] multiple) 
            => GetNaturalNumbersBelow(below)
                .Where(n => n.IsMultipleOfAny(multiple))
                .Sum();
    }
}
