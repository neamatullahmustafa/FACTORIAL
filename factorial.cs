using System;
namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t************* factorial task ***************");
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter a number");
            uint number = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("\t ************* factorial by recursive ************");
            //Get the time of system before start execution
            long milliseconds1_rec = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            double fact_rec = faktorial_Rec(number);
            //Get the time of system after execution
            long milliseconds2_rec = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            //get the execution time
            long executionTime_rec = (milliseconds2_rec - milliseconds1_rec) * 1000;
            //print 
            Console.WriteLine("{0} factorial is {1}", number, fact_rec);
            Console.WriteLine("The execution time is {0} " + "Microseconds", executionTime_rec);
            Console.WriteLine("\t************* factorial by for loop *************");
            //Get the time of system before start execution
            long milliseconds1_loop = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            double fact_loop = faktorial_loop(number);
            //Get the time of system after execution
            long milliseconds2_loop = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            //get the execution time
            long executionTime_loop = (milliseconds2_loop - milliseconds1_loop) * 1000;
            //print 
            Console.WriteLine("{0} factorial is {1}", number, fact_loop);
            Console.WriteLine("The execution time is {0} " + "Microseconds", executionTime_loop);
            Console.ReadKey();
        }
        private static double faktorial_Rec(double n)
        {
            if ((n == 0) || (n == 1))
                return (1);
            else
                return (n * faktorial_Rec(n - 1));
        }
        private static double faktorial_loop(double x)
        {
            double factL = 1;
            for (int i = 1; i <= x; i++)
                factL = factL * i;
            return factL;
        }
    }
}

