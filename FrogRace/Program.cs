using System;
using System.Threading;

namespace FrogRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            Thread thread1 = new Thread(FrogJump);
            thread1.Name = "T_One";
            thread1.Start(1);

            Thread thread2 = new Thread(FrogJump);
            thread2.Name = "T_Two";
            thread2.Start(2);

            Thread thread3 = new Thread(FrogJump);
            thread3.Name = "T_Three";
            thread3.Start(3);


            thread1.Join();
            thread2.Join();
            thread3.Join();
        }

        private static void FrogJump(object o)
        {
            int num = (int)o;
            string name = Thread.CurrentThread.Name;

            Random random = new Random(num);

            for(int i = 0; i < 10; i++)
            {
                Thread.Sleep(random.Next(1001));
                Console.WriteLine($"\nRã {num} deu salto {i+1} (thread {name})");
            }

            Console.WriteLine($"\nRã {num} terminou e morreu! RIP\n");
        }
    }
}
