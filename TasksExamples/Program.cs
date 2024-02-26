async Task FActorialAsync()
{
    await Task.Run(() =>
    {
        int res = 1;
        for (int i = 1; i <= 10; i++)
        {
            res *= i;
            Console.WriteLine(res);
            Thread.Sleep(1000);
        }
    });
}
FActorialAsync();
Console.ReadLine();
Console.ReadLine();

