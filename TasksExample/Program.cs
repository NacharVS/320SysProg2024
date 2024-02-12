using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TasksExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] array1 = new int[10];
            //int[] array2 = new int[10];
            //int[] sumArray = new int[10];

            //Random random = new Random();

            //Thread thread1 = new Thread(() =>
            //{
            //    for (int i = 0; i < array1.Length; i++)
            //    {
            //        array1[i] = random.Next(1, 100);
            //        Console.WriteLine("Array1: " + array1[i]);
            //        Thread.Sleep(500);
            //    }
            //});

            //Thread thread2 = new Thread(() =>
            //{
            //    for (int i = 0; i < array2.Length; i++)
            //    {
            //        array2[i] = random.Next(1, 100);
            //        Console.WriteLine("Array2: " + array2[i]);
            //        Thread.Sleep(500);
            //        sumArray[i] = array1[i] + array2[i];
            //        Console.WriteLine("SumArray: " + sumArray[i]);
            //        Thread.Sleep(500);
            //    }
            //});

            //Thread thread3 = new Thread(() =>
            //{
            //    for (int i = 0; i < sumArray.Length; i++)
            //    {
            //        for (int j = 0; j < array2.Length; j++)
            //        {
            //            sumArray[i] = array1[i] + array2[j];
            //            Console.WriteLine("SumArray: " + sumArray[i]);
            //            Thread.Sleep(500);
            //        }
            //    }
            //});

            // Запускаем оба потока
            //thread1.Start();
            //thread2.Start();
            //thread3.Start();

            // Ждем завершения обоих потоков
            //thread1.Join();
            //thread2.Join();
            //thread3.Join();


            //Task task1 = new Task(() =>
            //{
            //    for (int i = 0; i < 15; i++)
            //    {
            //        Console.WriteLine($"task {i}");
            //        Thread.Sleep(500);
            //    }
            //});
            //Task.WaitAll(
            //    Task.Run(() =>
            //    {
            //        for (int i = 0; i < 15; i++)
            //        {
            //            Console.WriteLine($"task {i}");
            //            Thread.Sleep(500);
            //        }
            //    })
            //    );

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"main {i}");
            //    Thread.Sleep(500);
            //}
            int[] array1 = GenerateRandomArray(5);
            int[] array2 = GenerateRandomArray(5);

            Thread thread = new Thread(() =>
            {
                for (int i = 0; i < Math.Min(array1.Length, array2.Length); i++)
                {
                    int sum = array1[i] + array2[i];
                    Console.WriteLine($"Сумма {i + 1}-го числа: {sum}");
                }
            });

            thread.Start();
            thread.Join(); // Ждем завершения потока
            Console.ReadLine();
        }

        static int[] GenerateRandomArray(int length)
        {
            Random random = new Random();
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(1, 101); // Генерация случайного числа от 1 до 100
            }
            return array;


        }
    }
}
