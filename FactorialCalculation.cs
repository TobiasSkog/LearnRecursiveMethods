namespace LearnRecursiveMethods
{
    // Factorial Calculation (Easy)
    // Write a recursive function to calculate the factorial of a non-negative
    // integer. Start with small numbers to understand the concept.
    public static class FactorialCalculation
    {
        public static int Factorial(int n)
        {
            // n! = n * (n-1) * ... * 1
            // The factorial function (symbol: !) says to multiply all whole numbers from our chosen number down to 1.
            // Examples:
            // 4! = 4 × 3 × 2 × 1 = 24
            // 7! = 7 × 6 × 5 × 4 × 3 × 2 × 1 = 5040
            // 1! = 1

            if (n == 1)
            {
                return n;
            }

            n *= Factorial(n - 1);

            return n;

        }
    }
}
