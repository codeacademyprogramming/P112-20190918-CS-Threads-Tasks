using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //   ThreadStart threadStart = new ThreadStart(Demo1);
            //   Thread myLittleThread = new Thread(threadStart);
            //   myLittleThread.Start();

            //   ThreadState threadState = myLittleThread.ThreadState;
            ////   Thread.Sleep(3000);

            //   Demo2();

            Task task = new Task(Demo1);
            task.Start();
            Task task2 = new Task(Demo2);
            task2.Start();
            Task task3 = new Task(Demo3);
            task3.Start();

            //Task t2 = Task.Run(()=> {
            //    Console.WriteLine("Task t2 RUN");
            //});

            task.Wait();

            Console.WriteLine("TASK 2 Finished");

            Console.ReadLine();
        }

        static public void Demo1()
        {
           // Thread.Sleep(3000);

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        static public void Demo2()
        {
            for (int i = 1000; i < 2000; i++)
            {
                Console.WriteLine(i);
            }
        }
        static public void Demo3()
        {
            for (int i = 10000; i < 10100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
