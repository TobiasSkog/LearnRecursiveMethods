using System.Diagnostics;

namespace LearnRecursiveMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            var breaker = "\n-----------------------------------------------\n";
            var nextCalc = "\n===============================================\n";



            Console.WriteLine(nextCalc);

            stopwatch.Start();
            var a = FactorialCalculation.Factorial(4);
            stopwatch.Stop();
            Console.WriteLine("\t~~ Factorial Calculation ~~");
            Console.WriteLine($"\t\t   !4 \n\tExpected result: 21 \n\tResult: {a} \n\tTime spent calculating: {stopwatch.ElapsedMilliseconds}m");

            Console.WriteLine(breaker);

            stopwatch.Restart();
            a = FactorialCalculation.Factorial(7);
            stopwatch.Stop();
            Console.WriteLine($"\t\t   !7 \n\tExpected result: 5040 \n\tResult: {a} \n\tTime spent calculating: {stopwatch.ElapsedMilliseconds}ms");

            Console.WriteLine(nextCalc);

            Console.WriteLine("\t~~ Fibonacci Sequence of nth term ~~");
            stopwatch.Restart();
            var b = FibonacciSequence.Fibonacci(6);
            Console.WriteLine($"\t\t   n = 6 \n\tExpected result: 8 \n\tResult: {b} \n\tTime spent calculating: {stopwatch.ElapsedMilliseconds}ms");
            stopwatch.Stop();

            Console.WriteLine(breaker);

            stopwatch.Restart();
            b = FibonacciSequence.Fibonacci(18);
            Console.WriteLine($"\t\t   n = 18 \n\tExpected result: 2584 \n\tResult: {b} \n\tTime spent calculating: {stopwatch.ElapsedMilliseconds}ms");
            stopwatch.Stop();

            Console.WriteLine(nextCalc);


        }
    }
}