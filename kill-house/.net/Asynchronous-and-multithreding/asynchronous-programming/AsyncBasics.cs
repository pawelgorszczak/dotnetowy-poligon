using System;
using System.Threading;
using System.Threading.Tasks;

namespace asynchronous_programming
{
    public static class AsyncBasics
    {
        public static void ShowExample(){
            AsyncOperation(1, 100, 100);
            PerformBlockingSleep(1, 150);
            AsyncOperation(2, 50, 100);
            PerformBlockingSleep(2, 50);
            PerformBlockingSleep(3, 100);
        }

        public static void ShowExampleWithTask(){
            AsyncOperationWithTask(1, 100, 100);
            PerformBlockingSleep(1, 150);
            AsyncOperationWithTask(2, 50, 100);
            PerformBlockingSleep(2, 50);
            PerformBlockingSleep(3, 100);
        }

        public static void ShowExampleWithFinishedTask(){
            AsyncOperationWithTask(1, 100, 100, true);
            PerformBlockingSleep(1, 150);
            AsyncOperationWithTask(2, 50, 100, false);
            PerformBlockingSleep(2, 50);
            PerformBlockingSleep(3, 100);
        }
       
        private static void PerformBlockingSleep(int index, int sleepTime){
            System.Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}][Blocking Operation {index}] - start");
            Thread.Sleep(sleepTime);
            System.Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}][Blocking Operation {index}] - end");
        }

        private static async void AsyncOperation(int index, int blockingSleepTime, int asyncSleepTime){
            System.Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}][Async Operaation {index}] - starting blocking");
            Thread.Sleep(blockingSleepTime);
            System.Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}][Async Operaation {index}] - starting async - returning control to caller");
            await Task.Delay(asyncSleepTime);
            System.Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}][Async Operaation {index}] - stop async - continuation");
        }

        private static async Task AsyncOperationWithTask(int index, int blockingSleepTime, int asyncSleepTime, bool returnFinishedTask = false) {            
            System.Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}][Async Operaation {index}] - starting blocking");
            Thread.Sleep(blockingSleepTime);
            var startAsyncMessage = returnFinishedTask ? "" : " - returning control to caller";
            System.Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}][Async Operaation {index}] - starting async{startAsyncMessage}");
            if (returnFinishedTask)
            {
                await FinishedTask();
            }
            else{
                await Task.Delay(asyncSleepTime);
            }
            
            System.Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}][Async Operaation {index}] - stop async - continuation");
        }

        private static Task FinishedTask() => Task.CompletedTask;
    }
}