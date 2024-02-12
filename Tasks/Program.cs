using System;

int[] a = new int[10];
Random rand = new Random();
for (int i = 0; i < 10; i++)
{
    a[i] = rand.Next(1, 20);
    Console.WriteLine(a[i]);
}