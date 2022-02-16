using System;
using System.Threading;
using System.Threading.Tasks;

namespace asynchronous_programming
{
    class Program
    {        
        static void Main(string[] args)
        {
            System.Console.WriteLine("==============================================");
            AsyncBasics.ShowExample();                        
            System.Console.WriteLine("==============================================");
            AsyncBasics.ShowExampleWithTask();
            System.Console.WriteLine("==============================================");
            AsyncBasics.ShowExampleWithFinishedTask();
            System.Console.WriteLine("==============================================");
            AsyncAndContinuation.ShowExample();
            System.Console.WriteLine("==============================================");
            AsyncAndContinuation.ShowExampleWithContinuation();
        }
    }
}
