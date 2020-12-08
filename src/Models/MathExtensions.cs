using System.Linq;

namespace ProjectEuler.Models
{
    public static class MathExtensions
    {
        public static bool IsMultipleOfAny(this int number, params int[] multiple) => multiple.Any(m => number % m is 0);
    }
}
