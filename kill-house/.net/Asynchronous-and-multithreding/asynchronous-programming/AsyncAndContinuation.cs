using System;
using System.Threading;
using System.Threading.Tasks;

namespace asynchronous_programming
{
    public static class AsyncAndContinuation
    {
        public static void ShowExample(){            
            CpuBoundOperation(1, false);                        
            CpuBoundOperation(2, false);
            CpuBoundOperation(3, false);

            Thread.Sleep(2000);
        }

        // There is no synchronization context so execution is done on next thread from thredpool
        public static void ShowExampleWithContinuation(){            
            CpuBoundOperation(1, true);                        
            CpuBoundOperation(2, true);
            CpuBoundOperation(3, true);

            Thread.Sleep(2000);
        }

        static async void CpuBoundOperation(int index, bool executeDelay) {
            System.Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}][Cpu Bound operation {index}] - start");

            if (executeDelay)
            {
                await Task.Delay(100);
                System.Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}][Cpu Bound operation {index}] - continuation on some thread");
            }

            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}][Cpu Bound operation {index}] - loop - {i}");
                Thread.Sleep(500);
            }
        }
    }
}