Task task1 = new Task(() =>
{
    for (int i = 0; i < 15; i++)
    {
        Console.WriteLine($"task {i}");
        Thread.Sleep(500);
    }
});
Task.WaitAll(
    Task.Run(() =>
    {
        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine($"task {i}");
            Thread.Sleep(500);
        }
    })
    );

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"main {i}");
    Thread.Sleep(500);
}


