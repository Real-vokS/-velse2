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
            //giver t1 et navn og starter den
            t1.Name = "Thread1";
            t1.Start();

            //giver t2 et navn og starter den
            t2.Name = "Thread2";
            t2.Start();


            Console.Read();
        }

        static void SayEasy()
        {
            //udskriver en string i Console.WriteLine og timeouter tråden i 1 sek før den fortsætter
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("[{0}] C# trådning er nemt", Thread.CurrentThread.Name);
                //timeouter Tråden i 1 sek
                Thread.CurrentThread.Join(1000);
            }
        }

        static void SayMore()
        {
            //udskriver en string i Console.WriteLine og timeouter tråden i 1 sek før den fortsætter
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("[{0}] Også med flere tråde..", Thread.CurrentThread.Name);
                //timeouter Tråden i 1 sek
                Thread.CurrentThread.Join(1000);
            }
        }

    }
}
