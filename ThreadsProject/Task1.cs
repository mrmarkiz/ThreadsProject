using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsProject
{
    public static class Task1
    {
        public static void Run()
        {
            Thread thread = new Thread(print);
            thread.Start();
        }
        private static void print()
        {
            for (int i = 0; i < 51; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
