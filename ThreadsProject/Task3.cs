using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsProject
{
    public static class Task3
    {
        public static void Run()
        {
            int start, end, threadsNum;
            Console.Write("Enter bounds of output: ");
            string[] input = Console.ReadLine().Split(' ');
            if (input.Length != 2)
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

            do
            {
                Console.Write("Enter Threads num: ");
                threadsNum = int.Parse(Console.ReadLine());
            } while (threadsNum < 1 || threadsNum > end - start);

            int segment = (end - start) / threadsNum;
            Thread thread;
            for (int i = 0; i < threadsNum - 1; i++)
            {
                thread = new Thread(printDiap);
                thread.Start(new int[] {start + segment * i, start + segment * (i + 1), i});
            }
            thread = new Thread(printDiap);
            thread.Start(new int[] {start + segment * (threadsNum - 1), end + 1, threadsNum - 1});
        }
        private static void printDiap(object bounds)
        {
            int[] boundsConv = (int[])bounds;
            int tabsNum = boundsConv[2];
            string tab = new string('\t', tabsNum);
            for (int i = boundsConv[0]; i < boundsConv[1]; i++)
            {
                Console.WriteLine($"{tab}{i}");
            }
        }
    }
}
