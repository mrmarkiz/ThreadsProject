using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsProject
{
    public static class Task4
    {
        public static void Run()
        {
            Random rnd = new Random();
            int[] arr = new int[10000];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100000, 100000);
            }
            Thread threadMax = new Thread(Max);
            Thread threadMin = new Thread(Min);
            Thread threadAvg = new Thread(AVG);
            threadMax.Start(arr);
            threadMin.Start(arr);
            threadAvg.Start(arr);
        }
        public static void Max(object array)
        {
            int[] arr = (int[])array;
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                    max = arr[i];
            }
            Console.WriteLine($"Max: {max}");
        }

        public static void Min(object array)
        {
            int[] arr = (int[])array;
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                    min = arr[i];
            }
            Console.WriteLine($"Min: {min}");
        }

        public static void AVG(object array)
        {
            int[] arr = (int[])array;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"AVG: {(double)sum / arr.Length}");
        }
    }
}
