using AsynchronousApp1;

callMethod();

static async Task callMethod()
{
    Method1();
    Method2();
    Method3(3);
}

static async Task Method1()
{
    await Task.Run(() =>
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(" Method 1");
            // Do something
            Task.Delay(1000).Wait();
        }
    });

}

static async Task Method2()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(" Method 2");
        // Do something
        Task.Delay(100).Wait();
    }
}

static void Method3(int count)
{
    Console.WriteLine("Total count is " + count);
}