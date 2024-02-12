using System;
using System.Threading;
using System.Threading.Tasks;

Random random = new Random();

int[] mass1 = new int [5];
int[] mass2 = new int[5];
int[] massResult = new int[5];


for (int i = 0; i < 5; i++)
{
    mass1[i] = random.Next(1, 10);
    mass2[i] = random.Next(1, 10);
}

Task task = Task.Run(() =>
{
    for (int i = 0; i < 5; i++)
    {
        massResult[i] = mass1[i] + mass2[i];
    }
});

task.Wait();


Console.Write("mass1: ");
for (int i = 0; i < 5; i++)
{
    Console.Write($"{mass1[i]} ");
    Thread.Sleep(500);
}

Console.Write("\nmass2: ");
for (int i = 0; i < 5; i++)
{
    Console.Write($"{mass2[i]} ");
    Thread.Sleep(500);
}

Console.Write("\nResult: ");
for (int i = 0; i < 5; i++)
{
    Console.Write($"{massResult[i]} ");
    Thread.Sleep(500);
}


Console.ReadKey();