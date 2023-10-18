using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsProject
{
    public static class Task2
    {
        public static void Run()
        {
            int start, end;
            Console.Write("Enter bounds of output: ");
            string[] input = Console.ReadLine().Split(' ');
            if(input.Length != 2)
            {
                return;
            }

            if (int.Parse(input[0]) < int.Parse(input[1]))
            {
                start = int.Parse(input[0]);
                end = int.Parse(input[1]);
            }
            else
            {
                start = int.Parse(input[1]);
                end = int.Parse(input[0]);
            }
            Thread thread = new Thread(Task2.printDiap);
            thread.Start(new int[] {start, end});
        }
        private static void printDiap(object bounds)
        {
            int[] boundsConv = (int[])bounds;
            for (int i = boundsConv[0]; i < boundsConv[1] + 1; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
