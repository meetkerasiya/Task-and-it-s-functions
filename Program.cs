using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

class MyClass
{
    static void Main(string[] args)
    {
        Calculate();
        Console.ReadLine();
    }

    private static void Calculate()
    {
        Task<int> task1 = Task.Run(() =>
        {
            return Calculate1();

        });

        TaskAwaiter<int> awaiter1 = task1.GetAwaiter();
        awaiter1.OnCompleted(() =>
        {
            int result1 = awaiter1.GetResult();
            Calculate2(result1);
        });


        Calculate3();

    }

    private static int Calculate1()
    {
        Thread.Sleep(3000);
        Console.WriteLine("Calculating result1");
        return 50;
    }

    private static int Calculate2(int result1)
    {
        Console.WriteLine("Calculating result2");
        return 150+result1;
    }

    private static int Calculate3()
    {
        Console.WriteLine("Calculating result3");
        return 179;
    }
}