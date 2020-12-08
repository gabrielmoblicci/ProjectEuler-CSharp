namespace ProjectEuler.Models
{
    public static class Problem2
    {
        public static int GetNextFibonacciElement(this int number, int previous) => number + previous;

        public static bool IsEven(this int number) => number.IsMultipleOfAny(2);

            // Note 1: Variables were initialized with these values in order to attend the problem requirement of starting  
            // sequence with [1, 2] (while in a regular Fibonacci sequence it starts with [1, 1]).
            // Note 2: These variables could be created using something like an unique int array, using the array 
            // positions for the previous, current and next terms, but I let this way to improve the method readability.
        public static int SumEvenValuedFibonacciNumbersUntil(int limit)
        {
            int result = 0;
            int previous = 0;
            int current = 1;

            while (current < limit)
            {
                var next = current.GetNextFibonacciElement(previous);
                previous = current;
                current = next;

                if(current.IsEven())
                    result += current;
            }

            return result;
        }
    }
}
