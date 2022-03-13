Task t1 = new Task(Method1);
t1.Start();
Task t2 = new Task(Method2);
t2.Start();

void Method1()
{
    for (int i = 0; i < 1000; i++)
    {
        
        Console.WriteLine("Method 1");
    }
}
void Method2()
{
    for (int i = 0; i < 1000; i++)
    {
        Console.WriteLine("Method 2");
    }
}
