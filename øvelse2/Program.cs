using System;
using System.Threading;

namespace øvelse2
{
    class Program
    {

        static Thread t1 = new Thread(SayEasy);
        static Thread t2 = new Thread(SayMore);
        static void Main(string[] args)
        {
            t1.Name = "Thread1";
            t1.Start();

            t2.Name = "Thread2";
            t2.Start();


            Console.Read();
        }

        static void SayEasy()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("[{0}] C# trådning er nemt", Thread.CurrentThread.Name);
                Thread.CurrentThread.Join(1000);
            }
        }

        static void SayMore()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("[{0}] Også med flere tråde..", Thread.CurrentThread.Name);
                Thread.CurrentThread.Join(1000);
            }
        }

    }
}
