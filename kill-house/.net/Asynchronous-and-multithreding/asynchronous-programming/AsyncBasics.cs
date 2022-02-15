using System;
using System.Threading;
using System.Threading.Tasks;

namespace asynchronous_programming
{
    public static class AsyncBasics
    {
        public static void ShowExample(){
            AsyncOperation1();
            PerformBlockingSleep(1, 150);
            AsyncOperation2();
            PerformBlockingSleep(2, 50);
            PerformBlockingSleep(3, 100);
        }

        private static void PerformBlockingSleep(int index, int sleepTime){
            System.Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}][Blocking Operation {index}] - start");
            Thread.Sleep(sleepTime);
            System.Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}][Blocking Operation {index}] - end");
        }

        private static async void AsyncOperation1(){
            System.Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}][Async Operaation 1] - starting blocking");
            Thread.Sleep(100);
            System.Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}][Async Operaation 1] - starting async - returning control to caller");
            await Task.Delay(100);
            System.Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}][Async Operaation 1] - stop async - continuation");
        }

        private static async void AsyncOperation2(){
            System.Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}][Async Operaation 2] - starting blocking");
            Thread.Sleep(50);
            System.Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}][Async Operaation 2] - starting async - returning control to caller");
            await Task.Delay(100);
            System.Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}][Async Operaation 2] - stop async - continuation");
        }
    }
}