using System;
using System.Threading;
using System.Threading.Tasks;

namespace asynchronous_programming
{
    class Program
    {        
        static void Main(string[] args)
        {
            AsyncBasics.ShowExample();
            System.Console.WriteLine("==============================================");
            AsyncAndContinuation.ShowExample();
            System.Console.WriteLine("==============================================");
            AsyncAndContinuation.ShowExampleWithContinuation();
        }
    }
}
