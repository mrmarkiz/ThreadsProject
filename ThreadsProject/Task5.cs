using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsProject
{
    public static class Task5
    {
        public static void Run()
        {
            Random rnd = new Random();
            int[] arr = new int[10000];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100000, 100000);
            }
            List<string> result = new List<string>();
            Thread threadMax = new Thread(Max);
            Thread threadMin = new Thread(Min);
            Thread threadAvg = new Thread(AVG);
            Tuple <int[], List<string>> t = new Tuple<int[], List<string>>(arr, result);
            threadMax.Start(t);
            threadMin.Start(t);
            threadAvg.Start(t);

            threadMax.Join();
            threadMin.Join();
            threadAvg.Join();

            Thread threadWriter = new Thread(() =>
            {
                using (FileStream fs = new FileStream("task5.txt", FileMode.OpenOrCreate))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine($"Max: {t.Item2[0]}, Min: {t.Item2[1]}, AVG: {t.Item2[0]}");
                    }
                }
            });
            threadWriter.Start();
        }
        public static void Max(object array)
        {
            Tuple<int[], List<string>> t = (Tuple < int[], List<string>>)array;
            int[] arr = t.Item1.ToArray();
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                    max = arr[i];
            }
            t.Item2.Add(max.ToString());
        }

        public static void Min(object array)
        {
            Tuple<int[], List<string>> t = (Tuple<int[], List<string>>)array;
            int[] arr = t.Item1.ToArray();
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                    min = arr[i];
            }
            t.Item2.Add(min.ToString());
        }

        public static void AVG(object array)
        {
            Tuple<int[], List<string>> t = (Tuple<int[], List<string>>)array;
            int[] arr = t.Item1.ToArray();
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            t.Item2.Add(((double)sum / arr.Length).ToString());
        }
    }
}
