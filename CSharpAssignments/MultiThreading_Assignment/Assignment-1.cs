using System;
using System.Collections.Generic;
using System.Threading;

namespace ParallelNumberProcessing
{
    class Program
    {
        static int[] partialSums = new int[5]; // store sums from 5 threads

        static void Main()
        {
            // 1. Create list 1 to 50
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 50; i++)
            {
                numbers.Add(i);
            }

            // 2. Split into 5 parts (10 numbers each)
            Thread[] threads = new Thread[5];

            for (int i = 0; i < 5; i++)
            {
                int start = i * 10;
                int end = start + 10;

                int threadIndex = i;

                threads[i] = new Thread(() =>
                {
                    int sum = 0;

                    Console.WriteLine($"\nThread {threadIndex + 1} processing:");

                    for (int j = start; j < end; j++)
                    {
                        Console.Write(numbers[j] + " ");
                        sum += numbers[j];
                    }

                    partialSums[threadIndex] = sum;
                    Console.WriteLine($"\nThread {threadIndex + 1} Sum: {sum}");
                });

                threads[i].Start();
            }

            // 3. Wait for all threads to complete
            foreach (var t in threads)
            {
                t.Join();
            }

            // 4. Final Sum
            int finalSum = 0;
            foreach (var sum in partialSums)
            {
                finalSum += sum;
            }

            Console.WriteLine($"\nFinal Sum: {finalSum}");
        }
    }
}