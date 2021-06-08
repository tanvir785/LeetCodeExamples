using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace test1.Solutions
{
    class DeadLockExample
    {
        static object obj1 = new object();
        static object obj2 = new object();
        public static void DeadLock1()
        {
            lock (obj1)
            {
                Console.WriteLine("Thread 1 got locked");
                Thread.Sleep(5000);
                lock (obj2)
                {
                    Console.WriteLine("Thread 2 got locked");
                }
            }
        }
        public static void DeadLock2()
        {
            lock (obj2)
            {
                Console.WriteLine("Thread 2 got locked");
                Thread.Sleep(500);
                lock (obj1)
                {
                    Console.WriteLine("Thread 1 got locked");
                }
            }
        }
    }
}
