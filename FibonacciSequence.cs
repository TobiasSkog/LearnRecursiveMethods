namespace LearnRecursiveMethods
{
    // Fibonacci Sequence (Intermediate):Implement a recursive function to generate
    // the nth number in the Fibonacci sequence. Begin with a small value of n.
    public static class FibonacciSequence
    {
        public static int Fibonacci(int n)
        {
            // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34
            // F0 = 0, F1 = 1, F2 = 2, F3 = 2, F4 = 3, F5 = 5, F6 = 8, F7 = 13, F8 = 21, F9 = 34
            // Fn = Fn-1 + Fn-2 for every n > 1
            // F2 = F1 + F0
            // F3 = F2 + F1
            // F4 = F3 + F2

            //  F0 = 0, F1= 1, Fn = Fn-1 + Fn-2, where n > 1.

            // Recursive until we reach 0 and add all values together?
            if (n > 1)
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
            else
            {
                return n;
            }
        }
    }
}
