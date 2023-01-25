using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

class MyClass
{
    static void Main(string[] args)
    {
        Calculate();
    }

    private static void Calculate()
    {
        Task<int> task1=Task.Run(() =>
        {
            return Calculate1();

        });

        Task<int> task2=Task.Run(() =>
        {
            return Calculate2();

        });
        
        Task.WaitAll(task1,task2);
        TaskAwaiter<int> awaiter1=task1.GetAwaiter();
        TaskAwaiter<int> awaiter2=task2.GetAwaiter();

        int result1=awaiter1.GetResult();
        int result2=awaiter2.GetResult();

        Calculate3(result1,result2);

    }

    private static int Calculate1()
    {
        Thread.Sleep(3000);
        Console.WriteLine("Calculating result1");
        return 50;
    }

    private static int Calculate2()
    {
        Console.WriteLine("Calculating result2");
        return 150;
    }

    private static int Calculate3(int result1,int result2)
    {
        Console.WriteLine("Calculating result3");
        return result1+ result2;
    }
}