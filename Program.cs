using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int fac = Factorial(n);
            Console.WriteLine("Factorial de: {0} es: {1}", n, fac );
        }

        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return (n * Factorial(n - 1));
            
        }
    }
}
